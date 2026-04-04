using CityVisitorFinaly.AppData;
using CityVisitorFinaly.Services;
using SkiaSharp;
using SkiaSharp.Views.Maui;
using Svg.Skia;
using System.Diagnostics;
using System.Reflection;
using System.Xml;

namespace CityVisitorFinaly;

public partial class MapsPage : ContentPage
{
    private List<SVGHelp> mPaths = new List<SVGHelp>();
    private Dictionary<string, RegionsRF> regionDictionary = new Dictionary<string, RegionsRF>();

    private SKMatrix _currentMatrix = SKMatrix.CreateIdentity();
    private SKMatrix _startMatrix = SKMatrix.CreateIdentity(); // Для стабильных жестов

    private SKRect _svgBounds;
    private float _lineThickness = 1.5f; // Поставил чуть меньше, чтобы было аккуратнее
    private bool _isFirstLayout = true; // Флаг для первой центровки


   
    private float _minScaleX, _minScaleY;
    private float _startTransX, _startTransY;
    private float _startScaleValue;
    public MapsPage()
    {
        InitializeComponent();
        LoadSvgGeometry();

        var pan = new PanGestureRecognizer();
        pan.PanUpdated += OnPanUpdated;
        canvasView.GestureRecognizers.Add(pan);

        var pinch = new PinchGestureRecognizer();
        pinch.PinchUpdated += OnPinchUpdated;
        canvasView.GestureRecognizers.Add(pinch);

        var tap = new TapGestureRecognizer { NumberOfTapsRequired = 1 };
        tap.Tapped += OnTapTapped;
        canvasView.GestureRecognizers.Add(tap);
    }
    protected override void OnDisappearing()
    {
        base.OnDisappearing();

        if (DeviceInfo.Current.Platform == DevicePlatform.Android || DeviceInfo.Current.Platform == DevicePlatform.iOS)
        {
            var orientationService = Handler.MauiContext.Services.GetService<IOrientationService>();
            orientationService?.SetPortrait(); 
        }

        canvasView.PaintSurface -= OnCanvasViewPaintSurface;
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        // ✅ ПОВОРАЧИВАЕМ ЭКРАН ТОЛЬКО НА МОБИЛКАХ
        if (DeviceInfo.Current.Platform == DevicePlatform.Android || DeviceInfo.Current.Platform == DevicePlatform.iOS)
        {
            var orientationService = Handler.MauiContext.Services.GetService<IOrientationService>();
            orientationService?.SetLandscape();
        }
        await LoadDbData();
        canvasView.PaintSurface += OnCanvasViewPaintSurface;
        canvasView.InvalidateSurface();
    }

    private void LoadSvgGeometry()
    {
        try
        {
            Assembly assembly = GetType().GetTypeInfo().Assembly;
            string res = "CityVisitorFinaly.Resources.Images.test3.svg";
            using (var s = assembly.GetManifestResourceStream(res))
            {
                using var svg = new SKSvg();
                svg.Load(s);
                _svgBounds = svg.Picture.CullRect;
            }
            using (var s = assembly.GetManifestResourceStream(res))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(s);
                foreach (XmlElement el in doc.GetElementsByTagName("path"))
                {
                    string id = el.GetAttribute("id");
                    string d = el.GetAttribute("d");
                    if (!id.StartsWith("path")) continue;
                    var path = SKPath.ParseSvgPathData(d);
                    if (path != null) mPaths.Add(new SVGHelp(id, path));
                }
            }
            if (mPaths.Count > 5) mPaths.RemoveRange(0, 5);
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
    }

    private async Task LoadDbData()
    {
        regionDictionary.Clear();
        var regions = await App.Db.GetRegions();
        var allCities = await App.Db.GetAllCitiesAsync();
        var grouped = allCities.GroupBy(c => c.Regionid).ToDictionary(g => g.Key, g => g.ToList());
        foreach (var r in regions)
        {
            var reg = new RegionsRF(r);
            if (grouped.TryGetValue(r.Id, out var cList)) reg.AddCities(cList);
            if (!string.IsNullOrEmpty(reg.IdRegionsMaps)) regionDictionary[reg.IdRegionsMaps] = reg;
        }
    }

   
    private void ClampMatrix()
    {
        float canvasW = (float)canvasView.CanvasSize.Width;
        float canvasH = (float)canvasView.CanvasSize.Height;

        float mapW = _svgBounds.Width * _currentMatrix.ScaleX;
        float mapH = _svgBounds.Height * _currentMatrix.ScaleY;

       
        if (_currentMatrix.ScaleX <= _minScaleX + 0.005f)
        {
            _currentMatrix.TransX = 0;
            _currentMatrix.TransY = 0;
            _currentMatrix.ScaleX = _minScaleX;
            _currentMatrix.ScaleY = _minScaleY;
            return;
        }

        if (mapW <= canvasW)
            _currentMatrix.TransX = (canvasW - mapW) / 2f;
        else
            _currentMatrix.TransX = Math.Clamp(_currentMatrix.TransX, canvasW - mapW, 0);

        if (mapH <= canvasH)
            _currentMatrix.TransY = (canvasH - mapH) / 2f;
        else
            _currentMatrix.TransY = Math.Clamp(_currentMatrix.TransY, canvasH - mapH, 0);
    }
    private void OnPanUpdated(object sender, PanUpdatedEventArgs e)
    {
       
        if (_currentMatrix.ScaleX <= _minScaleX + 0.01f)
            return;

        float density = (float)(canvasView.CanvasSize.Width / canvasView.Width);

        switch (e.StatusType)
        {
            case GestureStatus.Started:
                _startTransX = _currentMatrix.TransX;
                _startTransY = _currentMatrix.TransY;
                break;
            case GestureStatus.Running:
                _currentMatrix.TransX = _startTransX + (float)(e.TotalX * density);
                _currentMatrix.TransY = _startTransY + (float)(e.TotalY * density);

                ClampMatrix();
                canvasView.InvalidateSurface();
                break;
        }
    }

    private void OnPinchUpdated(object sender, PinchGestureUpdatedEventArgs e)
    {
        
        switch (e.Status)
        {
            case GestureStatus.Started:
                _startScaleValue = _currentMatrix.ScaleX;
                _startTransX = _currentMatrix.TransX;
                _startTransY = _currentMatrix.TransY;
                break;
            case GestureStatus.Running:
                float newScale = _startScaleValue * (float)e.Scale;

               
                newScale = Math.Max(newScale, _minScaleX);
                newScale = Math.Min(newScale, 30f);

                float pivotX = (float)(e.ScaleOrigin.X * canvasView.CanvasSize.Width);
                float pivotY = (float)(e.ScaleOrigin.Y * canvasView.CanvasSize.Height);

                float ratio = newScale / _currentMatrix.ScaleX;

                _currentMatrix.TransX = pivotX - (pivotX - _currentMatrix.TransX) * ratio;
                _currentMatrix.TransY = pivotY - (pivotY - _currentMatrix.TransY) * ratio;
                _currentMatrix.ScaleX = _currentMatrix.ScaleY = newScale;

                ClampMatrix();
                canvasView.InvalidateSurface();
                break;
        }
    }

    private void OnTapTapped(object sender, TappedEventArgs e)
    {
        var pos = e.GetPosition(canvasView);
        if (pos == null) return;

        if (_currentMatrix.TryInvert(out var inv))
        {
            float density = (float)(canvasView.CanvasSize.Width / canvasView.Width);
            var p = inv.MapPoint(new SKPoint((float)pos.Value.X * density, (float)pos.Value.Y * density));

            var hit = mPaths.FirstOrDefault(x => x.SKPath.Contains(p.X, p.Y));
            string msg = hit != null && regionDictionary.TryGetValue(hit.IdReg, out var r) ? r.ShowInfo() : "Нажатие мимо региона";
            DisplayAlert("Информационное сообщение", msg, "OK");
        }
    }
    // Метод для общего изменения масштаба
    private void ApplyZoom(float factor, float px, float py)
    {
        float newScale = _currentMatrix.ScaleX * factor;
        if (newScale < _minScaleX)
        {
           
            _currentMatrix.ScaleX = _minScaleX;
            _currentMatrix.ScaleY = _minScaleY;
            _currentMatrix.TransX = 0;
            _currentMatrix.TransY = 0;
        }
        else if (newScale <= 30f)
        {
            var scaleMatrix = SKMatrix.CreateScale(factor, factor, px, py);
            _currentMatrix = _currentMatrix.PostConcat(scaleMatrix);
            ClampMatrix();
        }

        canvasView.InvalidateSurface();
    }


    protected override void OnHandlerChanged()
    {
        base.OnHandlerChanged();
#if WINDOWS
        var nativeView = canvasView.Handler?.PlatformView as Microsoft.UI.Xaml.FrameworkElement;
        if (nativeView != null) {
            nativeView.PointerWheelChanged += (s, e) => {
                var point = e.GetCurrentPoint(nativeView);
                float factor = point.Properties.MouseWheelDelta > 0 ? 1.1f : 0.9f;
                float px = (float)(point.Position.X * (canvasView.CanvasSize.Width / canvasView.Width));
                float py = (float)(point.Position.Y * (canvasView.CanvasSize.Height / canvasView.Height));
                ApplyZoom(factor, px, py);
                e.Handled = true;
            };
        }
#endif
    }
   
    private void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs e)
    {
        var canvas = e.Surface.Canvas;
        canvas.Clear(SKColors.White);

        if (_isFirstLayout)
        {
            _minScaleX = e.Info.Width / _svgBounds.Width;
            _minScaleY = e.Info.Height / _svgBounds.Height;

            _currentMatrix = SKMatrix.CreateScale(_minScaleX, _minScaleY);
            _currentMatrix.TransX = 0;
            _currentMatrix.TransY = 0;
            _isFirstLayout = false;
        }

        canvas.SetMatrix(_currentMatrix);

        float adjustedThickness = _lineThickness / _currentMatrix.ScaleX;
        using var paint = new SKPaint { IsAntialias = true, StrokeWidth = adjustedThickness };

        foreach (var p in mPaths)
        {
            paint.Style = SKPaintStyle.Stroke;
            paint.Color = SKColors.Black;

            if (regionDictionary.TryGetValue(p.IdReg, out var reg))
            {
                if (reg.StateReg == State.Visited.ToString())
                {
                    paint.Style = SKPaintStyle.Fill;
                    paint.Color = Config.ColorFullVisit;
                }
                else if (reg.StateReg == State.VisitedTransit.ToString() && Config.VisiblePassing)
                {
                    paint.Style = SKPaintStyle.Fill;
                    paint.Color = Config.ColorPassingVisit;
                }
            }

            if (paint.Style == SKPaintStyle.Fill)
            {
                canvas.DrawPath(p.SKPath, paint);
                paint.Style = SKPaintStyle.Stroke;
                paint.Color = Config.OutlineColor;
                paint.StrokeWidth = adjustedThickness;
                canvas.DrawPath(p.SKPath, paint);
            }
            else
            {
                canvas.DrawPath(p.SKPath, paint);
            }
        }
    }
}