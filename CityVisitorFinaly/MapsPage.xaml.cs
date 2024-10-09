
using SkiaSharp;
using SkiaSharp.Views.Maui;
using Svg;
using Svg.Skia;
using System.Reflection;
using CityVisitorFinaly.AppData;
using System.Xml;

namespace CityVisitorFinaly;

public partial class MapsPage : ContentPage
{

    List<Regions> RegionList = new List<Regions>();
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
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await ReadData();
        int cur = RegionList.Count;
        canvasView.PaintSurface += OnCanvasViewPaintSurface;
        // Обновите интерфейс, если необходимо.
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

        
        var tap = new TapGestureRecognizer { NumberOfTapsRequired = 1 };
        tap.Tapped += OnTapGestureRecognizerTapped;
        canvasView.GestureRecognizers.Add(tap);

        var pinch = new PinchGestureRecognizer();
        pinch.PinchUpdated += PinchGestureRecognizer_PinchUpdated;
        canvasView.GestureRecognizers.Add(pinch);

        var pan = new PanGestureRecognizer();
        pan.PanUpdated += PanGestureRecognizer_PanUpdated;
        canvasView.GestureRecognizers.Add(pan);
    }
    void OnTapGestureRecognizerTapped(object sender, TappedEventArgs args)
    {
        // Handle the tap
        //if (args.Buttons == ButtonsMask.Secondary)
        // {
        int cur = 0;
        Point? wind = args.GetPosition((View) sender);

        Point p = (Point)wind;
        float scaledX = (float)(p.X / scaleX); // Преобразование x
        float scaledY = (float)(p.Y / scaleY); // Преобразование y
        string str = "";
        for (int i = 0; i < mPaths.Count; i++)
        {
            if (mPaths[i].SKPath.Contains(scaledX, scaledY))
            {
                try
                {
                    str = RegionList.First(a => a.IdRegionsMaps.Equals(mPaths[i].IdReg)).ShowInfo();
                }
                catch
                {
                    str = "к сожалению этот регион еще инициализирован";
                }
                cur = 1;
                break;
              
            }
        }
        if (cur == 1)
        {
            DisplayAlert("Информационное сообщение", $"{str}", "ок");
        }
        else
        {
            DisplayAlert("Информационное сообщение", "нажатие мимо региона", "ок");
        }
        // Do something
        // }
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

    private void PanGestureRecognizer_PanUpdated(object sender, PanUpdatedEventArgs e)
    {
        switch (e.StatusType)
        {
            case GestureStatus.Started:
                LastX = (1 - AnchorX) * Width;
                LastY = (1 - AnchorY) * Height;
                break;
            case GestureStatus.Running:
                double speedCoefficient = 2.0; // Измените это значение по вашему усмотрению
                AnchorX = Clamp(1 - (LastX + e.TotalX * speedCoefficient) / Width, 0, 1);
                AnchorY = Clamp(1 - (LastY + e.TotalY * speedCoefficient) / Height, 0, 1);
                break;
                //case GestureStatus.
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
        switch (e.Status)
        {
            case GestureStatus.Started:
                StartScale = Scale;
                AnchorX = e.ScaleOrigin.X;
                AnchorY = e.ScaleOrigin.Y;
                break;
            case GestureStatus.Running:
                double current = Scale + (e.Scale - 1) * StartScale;
                Scale = Clamp(current, MIN_SCALE * (1 - OVERSHOOT), MAX_SCALE * (1 + OVERSHOOT));
                break;
            case GestureStatus.Completed:
                if (Scale > MAX_SCALE)
                    this.ScaleTo(MAX_SCALE, 250, Easing.SpringOut);
                else if (Scale < MIN_SCALE)
                    this.ScaleTo(MIN_SCALE, 250, Easing.SpringOut);
                break;
        }
    }

    //void DrawMap()
    //{
    //    SKImageInfo imageInfo = new SKImageInfo(pictureSVG.Width, pictureSVG.Height);
    //    using (SKSvg svg = new SKSvg())
    //    {
    //        svg.Load(svgPath1);
    //        scaleX = imageInfo.Width / svg.Picture.CullRect.Width;
    //        scaleY = imageInfo.Height / svg.Picture.CullRect.Height;
    //        SkiaSharp.SKMatrix matrix = SkiaSharp.SKMatrix.CreateScale(scaleX, scaleY);
    //        using (SKSurface surface = SKSurface.Create(imageInfo))
    //        {
    //            SKCanvas canvas = surface.Canvas;
    //            using (SKPaint paint = new SKPaint())
    //            {
    //                //цвет
    //                paint.Color = SKColors.Black;
    //                //сглаживание
    //                paint.IsAntialias = false;
    //                //ширина обводки
    //                paint.StrokeWidth = Config.StrokeWidth;
    //                //стиль: SKPaintStyle.Stroke - линия, 
    //                paint.Style = SkiaSharp.SKPaintStyle.Stroke;
    //                transformPath.Rewind();
    //                for (int cur = 0; cur < mPaths.Count; cur++)
    //                {
    //                    transformPath.Rewind();
    //                    transformPath.AddPath(mPaths[cur].SKPath);
    //                    transformPath.Transform(matrix);
    //                    // Проверка на количество путей
    //                    if (cur < 10)
    //                    {
    //                        // Установка свойств для первых 10 путей
    //                        paint.Style = SKPaintStyle.Fill; // Для заливки
    //                        paint.Color = Config.ColorFullVisit;
    //                        canvas.DrawPath(transformPath, paint);
    //                        // Теперь рисуем обводку
    //                        paint.Style = SKPaintStyle.Stroke; // Теперь обводка
    //                        paint.Color = Config.OutlineColor; // Цвет обводки
    //                        canvas.DrawPath(transformPath, paint);
    //                    }
    //                    else
    //                    {
    //                        paint.Color = Config.OutlineColor;
    //                        canvas.DrawPath(transformPath, paint);
    //                    }

    //                }
    //            }
    //            using (SKImage image = surface.Snapshot())
    //            using (SKData data = image.Encode(SKEncodedImageFormat.Png, 100))
    //            using (MemoryStream mStream = new MemoryStream(data.ToArray()))
    //            {
    //                Bitmap bm = new Bitmap(mStream, false);
    //                pictureSVG.Image = bm;
    //            }
    //        }
    //    }
    //    Graphics g = this.CreateGraphics();
    //    img = pictureSVG.Image;

    //    // Fit width
    //    zoom = ((float)img.Width / (float)img.Width) *
    //            (img.HorizontalResolution / g.DpiX);

    //    pictureSVG.Paint += new PaintEventHandler(pictureSVG_Paint);
    //}
    SKPath transformPath = new SKPath();
    List<SVGHelp> mPaths = new List<SVGHelp>();


    float scaleX, scaleY;

    private void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs e)
    {

        //var canvas = e.Surface.Canvas;
        ////canvas.Clear();
        //// Рисуем карту России из SVG
        ////canvas.DrawPicture(canvasView.Picture);
        //// Добавляем обработчики событий для нажатий на регионы
        //canvasView.Touch += (touchSender, touchEvent) =>
        //{
        //    // Определяем, на какой регион нажал пользователь
        //    SKPoint touchPoint = touchEvent.Location;
        //    if (IsPointInRegion1(touchPoint))
        //    {
        //        // Пользователь нажал на регион 1
        //    }
        //    // И так далее для остальных регионов
        //};
        //SKImageInfo info = e.Info;
        //SKCanvas canvas = e.Surface.Canvas;
        //Assembly assembly = GetType().GetTypeInfo().Assembly;
        //// Stream stream = assembly.GetManifestResourceStream("test4.Resources.Images.Test3.svg");
        //Stream stream = assembly.GetManifestResourceStream("CityVisitorFinaly.Resources.Images.test3.svg");

        //// Загрузите SVG-файл
        //using (SKSvg svg = new SKSvg())
        //{
        //    svg.Load(stream);
        //    // Масштабируйте SVG в соответствии с размерами холста
        //    float scaleX = info.Width / svg.Picture.CullRect.Width;
        //    float scaleY = info.Height / svg.Picture.CullRect.Height;
        //    SKMatrix matrix = SKMatrix.CreateScale(scaleX, scaleY);
        //    foreach (var t in svg.Model.Commands)
        //    {
        //        if (t is ShimSkiaSharp.DrawPathCanvasCommand)
        //        {
        //            var l = (t as ShimSkiaSharp.DrawPathCanvasCommand);
        //            list.Add(l.Path);
        //        }
        //    }
        //    // Отобразите SVG на холсте
        //    canvas.Clear();
        //    canvas.DrawPicture(svg.Picture, ref matrix);
        //}
        //0DisplayAlert("fwe", $"{list.Count}", "hguifdsag");

        // Получение информации об изображении


        var canvas = e.Surface.Canvas;
        canvas.Clear(); // clears the canvas for every frame
        var _info = e.Info;
        Assembly assembly = GetType().GetTypeInfo().Assembly;
        Stream stream = assembly.GetManifestResourceStream("CityVisitorFinaly.Resources.Images.test3.svg");

        using (SKSvg svg = new SKSvg())
        {
            svg.Load(stream);
            scaleX = _info.Width / svg.Picture.CullRect.Width;
            scaleY = _info.Height / svg.Picture.CullRect.Height;
            SKMatrix matrix = SKMatrix.CreateScale(scaleX, scaleY);
            // _canvas.DrawPath(t1, new SKPaint
            //{
            //     Style = SKPaintStyle.Fill,
            //    Color = SKColors.Aqua,
            //    IsAntialias = true
            //});
            SKPaint paint = new SKPaint();



            for(int i = 0; i < mPaths.Count; i++)
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
                    else if (reg.StateReg.Equals(State.VisitedTransit.ToString()))
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
                        canvas.DrawPath(transformPath, paint);
                    }
                }
                catch
                {
                    canvas.DrawPath(transformPath, paint);
                }
               
            }

        }

        //Stream stream = assembly.GetManifestResourceStream("CityVisitorFinaly.Resources.Images.test3.svg");

        //using (SKSvg svg = new SKSvg())
        //{
        //    svg.Load(stream);
        //    float scaleX = imageInfo.Width / svg.Picture.CullRect.Width;
        //    float scaleY = imageInfo.Height / svg.Picture.CullRect.Height;
        //    SKMatrix matrix = SKMatrix.CreateScale(scaleX, scaleY);
        //    using (SKSurface surface = SKSurface.Create(imageInfo))
        //    {
        //        var canvas = e.Surface.Canvas;
        //        using (SKPaint paint = new SKPaint())
        //        {
        //            paint.Color = SKColors.Black;
        //            paint.IsAntialias = false;
        //            paint.StrokeWidth = Config.StrokeWidth;
        //            paint.Style = SKPaintStyle.Stroke;

        //            transformPath.Rewind();
        //            for (int cur = 0; cur < mPaths.Count; cur++)
        //            {
        //                transformPath.Rewind();
        //                transformPath.AddPath(mPaths[cur].SKPath);
        //                transformPath.Transform(matrix);

        //                if (cur < 10)
        //                {
        //                    paint.Style = SKPaintStyle.Fill;
        //                    paint.Color = Config.ColorFullVisit;
        //                    canvas.DrawPath(transformPath, paint);

        //                    paint.Style = SKPaintStyle.Stroke;
        //                    paint.Color = Config.OutlineColor;
        //                    canvas.DrawPath(transformPath, paint);
        //                }
        //                else
        //                {
        //                    paint.Color = Config.OutlineColor;
        //                    canvas.DrawPath(transformPath, paint);
        //                }
        //            }
        //        }
        //        // Отрисовка на основном canvas
        //       // canvas.Clear();
        //        //canvas.DrawPicture(svg.Picture, ref matrix);
        //    }
        //}
        //Graphics g = this.CreateGraphics();
        //img = pictureSVG.Image;

        //// Fit width
        //zoom = ((float)img.Width / (float)img.Width) *
        //        (img.HorizontalResolution / g.DpiX);

        //pictureSVG.Paint += new PaintEventHandler(pictureSVG_Paint);

    }
}