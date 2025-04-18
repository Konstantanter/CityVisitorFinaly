using CityVisitorFinaly.AppData;
using SkiaSharp;
using SkiaSharp.Views.Maui;
using Svg;
using Svg.Skia;
using System.Diagnostics;
using System.Reflection;
using System.Xml;

namespace CityVisitorFinaly;

public partial class MapsPage : ContentPage
{
    /// <summary>
    /// ������ ��������
    /// </summary>
    List<Regions> RegionList = new List<Regions>();
    /// <summary>
    /// ������� ������ ������
    /// </summary>
    public async Task ReadData()
    {
        var regions = await App.Db.GetRegions();

        foreach (var region in regions)
        {
            Regions newReg = new Regions(region);

            var newListCities = await App.Db.GetCitiesFromRegion(region.Id);
            newReg.AddCities(newListCities);
            RegionList.Add(newReg);
        }

    }
    //������������ �����������
    protected override async void OnAppearing()
    {

        base.OnAppearing();
        await ReadData();
        int cur = RegionList.Count;
        canvasView.InvalidateSurface(); // ��������� �����������
        canvasView.PaintSurface += OnCanvasViewPaintSurface;
        var tap = new TapGestureRecognizer { NumberOfTapsRequired = 1 };
        tap.Tapped += OnTapGestureRecognizerTapped;
        canvasView.GestureRecognizers.Add(tap);
    }
    public MapsPage()
    {
        InitializeComponent();
        XmlDocument doc = new XmlDocument();
        Assembly assembly = GetType().GetTypeInfo().Assembly;
        Stream stream = assembly.GetManifestResourceStream("CityVisitorFinaly.Resources.Images.test3.svg");
        doc.Load(stream);
        XmlNodeList elementsByTagName = doc.GetElementsByTagName("path");
        for (int i = 0; i < elementsByTagName.Count; i++)
        {
            XmlElement element = (XmlElement)elementsByTagName.Item(i);
            var pathData = element.GetAttribute("d");
            var skPath = SkiaSharp.SKPath.ParseSvgPathData(pathData);
            SVGHelp svgHelp = new SVGHelp(element.GetAttribute("id").ToString(), skPath);

            mPaths.Add(svgHelp);
        }
        this.mPaths.RemoveAt(0);
        this.mPaths.RemoveAt(0);
        this.mPaths.RemoveAt(0);
        this.mPaths.RemoveAt(0);
        this.mPaths.RemoveAt(0);
        
        var pinch = new PinchGestureRecognizer();
        pinch.PinchUpdated += PinchGestureRecognizer_PinchUpdated;
        canvasView.GestureRecognizers.Add(pinch);
        var pan = new PanGestureRecognizer();
        pan.PanUpdated += PanGestureRecognizer_PanUpdated;
        canvasView.GestureRecognizers.Add(pan);
    }

    float scaleH, scaleW;
    /// <summary>
    /// ����������� ������� �� �����
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    void OnTapGestureRecognizerTapped(object sender, TappedEventArgs args)
    {
        int cur = 0;
        PointF point = args.GetPosition(relativeTo: (View)sender).Value;
        float x1 = point.X * scaleW;
        float y1 = point.Y * scaleH;
        string str = "";
        for (int i = 0; i < mPaths.Count; i++)
        {
            if (mPaths[i].SKPath.Contains(x1 / scaleX, y1 / scaleY))
            {
                try
                {
                    str = RegionList.First(a => a.IdRegionsMaps.Equals(mPaths[i].IdReg)).ShowInfo();
                }
                catch
                {
                    str = "� ��������� ���� ������ ��� ��������������� �� ������� - " + mPaths[i].IdReg;
                }
                cur = 1;
                break;
            }
        }
        if (cur == 1)
        {
            DisplayAlert("�������������� ���������", $"{str}", "��");
        }
        else
        {
            DisplayAlert("�������������� ���������", "������� ���� �������", "��");
        }
    }
    private T Clamp<T>(T value, T minimum, T maximum) where T : IComparable
    {
        if (value.CompareTo(minimum) < 0)
            return minimum;
        else if (value.CompareTo(maximum) > 0)
            return maximum;
        else
            return value;
    }

    private const double MIN_SCALE = 1;
    private const double MAX_SCALE = 4;
    private const double OVERSHOOT = 0.15;
    private double StartScale;
    private double LastX, LastY;
    private Point? _panStart;
    public bool IsZoomed => this.comicPageContainer?.Scale > 1.0 == true;
    private void PanGestureRecognizer_PanUpdated(object sender, PanUpdatedEventArgs e)
    {
        Debug.WriteLine(",k'n");
        if (this.IsZoomed)
        {
            switch (e.StatusType)
            {
                case GestureStatus.Started:
                    _panStart = new(this.comicPageContainer.TranslationX, this.comicPageContainer.TranslationY);
                    break;
                case GestureStatus.Running:
                    if (_panStart is Point start)
                    {
                        this.comicPageContainer.TranslationX = start.X + (e.TotalX * this.comicPageContainer.Scale);
                        this.comicPageContainer.TranslationY = start.Y + (e.TotalY * this.comicPageContainer.Scale);
                    }
                    break;
                default:
                    _panStart = default;
                    break;
            }
        }
    }

    protected override SizeRequest OnMeasure(double widthConstraint, double heightConstraint)
    {
        Scale = MIN_SCALE;
        TranslationX = TranslationY = 0;
        AnchorX = AnchorY = 0;
        return base.OnMeasure(widthConstraint, heightConstraint);
    }
    private void PinchGestureRecognizer_PinchUpdated(object sender, PinchGestureUpdatedEventArgs e)
    {
        Debug.WriteLine("!!!!");
        var newScale = Math.Clamp(1.0, this.comicPageContainer.Scale * e.Scale, 3.0);
        this.comicPageContainer.Scale = newScale;
        this.comicPageContainer.TranslationX = e.ScaleOrigin.X;
        this.comicPageContainer.TranslationY = e.ScaleOrigin.Y;
       // Debug.WriteLine("Scale: {0}", newScale);
    }
    SKPath transformPath = new SKPath();
    List<SVGHelp> mPaths = new List<SVGHelp>();
    float scaleX, scaleY;

    private void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs e)
    {
        var canvas = e.Surface.Canvas;
        canvas.Clear();
        var _info = e.Info;
        Assembly assembly = GetType().GetTypeInfo().Assembly;
        Stream stream = assembly.GetManifestResourceStream("CityVisitorFinaly.Resources.Images.test3.svg");
        using (SKSvg svg = new SKSvg())
        {
            svg.Load(stream);
            scaleX = (float)_info.Width / svg.Picture.CullRect.Width;
            scaleY = (float)_info.Height / svg.Picture.CullRect.Height;
            scaleW = (float)(e.Info.Width / canvasView.Width);
            scaleH = (float)(e.Info.Height / canvasView.Height);
            SKMatrix matrix = SKMatrix.CreateScale(scaleX, scaleY);
            SKPaint paint = new SKPaint();
            for (int i = 0; i < mPaths.Count; i++)
            {
                paint.Color = SKColors.Black;
                paint.IsAntialias = false;
                paint.StrokeWidth = Config.StrokeWidth;
                paint.Style = SKPaintStyle.Stroke;
                transformPath.Rewind();
                transformPath.AddPath(mPaths[i].SKPath);
                transformPath.Transform(matrix);
                try
                {
                    var reg = RegionList.First(a => a.IdRegionsMaps.Equals(mPaths[i].IdReg));
                    if (reg.StateReg.Equals(State.Visited.ToString()))
                    {
                        paint.Style = SKPaintStyle.Fill;
                        paint.Color = Config.ColorFullVisit;
                        canvas.DrawPath(transformPath, paint);
                        paint.Style = SKPaintStyle.Stroke;
                        paint.Color = Config.OutlineColor;
                        canvas.DrawPath(transformPath, paint);
                    }
                    else if (reg.StateReg.Equals(State.VisitedTransit.ToString()) && Config.VisiblePassing==true)
                    {
                        paint.Style = SKPaintStyle.Fill;
                        paint.Color = Config.ColorPassingVisit;
                        canvas.DrawPath(transformPath, paint);
                        paint.Style = SKPaintStyle.Stroke;
                        paint.Color = Config.OutlineColor;
                        canvas.DrawPath(transformPath, paint);
                    }
                    else
                    {
                        if (reg.Append_Reg.Equals(AppendReg.RegAppend.ToString()))
                        {
                            paint.Style = SKPaintStyle.Fill;
                            paint.Color = Config.ColorAppendReg;
                            canvas.DrawPath(transformPath, paint);
                            paint.Style = SKPaintStyle.Stroke;
                            paint.Color = Config.OutlineColor;
                            canvas.DrawPath(transformPath, paint);
                        }
                        else
                        {
                            canvas.DrawPath(transformPath, paint);
                        }
                    }
                }
                catch
                {
                    canvas.DrawPath(transformPath, paint);
                }
            }
        }
    }
}