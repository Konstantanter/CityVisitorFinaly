
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
    public MapsPage()
    {
        InitializeComponent();
        Config config = new Config();
        XmlDocument doc = new XmlDocument();
        Assembly assembly = GetType().GetTypeInfo().Assembly;
        Stream stream = assembly.GetManifestResourceStream("CityVisitorFinaly.Resources.Images.test3.svg");
        doc.Load(stream);
        XmlNodeList elementsByTagName = doc.GetElementsByTagName("path");
        for (int i = 0; i < elementsByTagName.Count; i++)
        {
            SVGPath sVGPath = new SVGPath();
            XmlElement element = (XmlElement)elementsByTagName.Item(i);
            sVGPath.setId(element.GetAttribute("id"));
            sVGPath.setFillColor(48);
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


        DisplayAlert("!", "!", "!");
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
                double speedCoefficient = 2.0; // �������� ��� �������� �� ������ ����������
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
    List<ShimSkiaSharp.SKPath> list = new List<ShimSkiaSharp.SKPath>();
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
    //                //����
    //                paint.Color = SKColors.Black;
    //                //�����������
    //                paint.IsAntialias = false;
    //                //������ �������
    //                paint.StrokeWidth = Config.StrokeWidth;
    //                //�����: SKPaintStyle.Stroke - �����, 
    //                paint.Style = SkiaSharp.SKPaintStyle.Stroke;
    //                transformPath.Rewind();
    //                for (int cur = 0; cur < mPaths.Count; cur++)
    //                {
    //                    transformPath.Rewind();
    //                    transformPath.AddPath(mPaths[cur].SKPath);
    //                    transformPath.Transform(matrix);
    //                    // �������� �� ���������� �����
    //                    if (cur < 10)
    //                    {
    //                        // ��������� ������� ��� ������ 10 �����
    //                        paint.Style = SKPaintStyle.Fill; // ��� �������
    //                        paint.Color = Config.ColorFullVisit;
    //                        canvas.DrawPath(transformPath, paint);
    //                        // ������ ������ �������
    //                        paint.Style = SKPaintStyle.Stroke; // ������ �������
    //                        paint.Color = Config.OutlineColor; // ���� �������
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

    private void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs e)
    {
        //var canvas = e.Surface.Canvas;
        ////canvas.Clear();
        //// ������ ����� ������ �� SVG
        ////canvas.DrawPicture(canvasView.Picture);
        //// ��������� ����������� ������� ��� ������� �� �������
        //canvasView.Touch += (touchSender, touchEvent) =>
        //{
        //    // ����������, �� ����� ������ ����� ������������
        //    SKPoint touchPoint = touchEvent.Location;
        //    if (IsPointInRegion1(touchPoint))
        //    {
        //        // ������������ ����� �� ������ 1
        //    }
        //    // � ��� ����� ��� ��������� ��������
        //};
        //SKImageInfo info = e.Info;
        //SKCanvas canvas = e.Surface.Canvas;
        //Assembly assembly = GetType().GetTypeInfo().Assembly;
        //// Stream stream = assembly.GetManifestResourceStream("test4.Resources.Images.Test3.svg");
        //Stream stream = assembly.GetManifestResourceStream("CityVisitorFinaly.Resources.Images.test3.svg");

        //// ��������� SVG-����
        //using (SKSvg svg = new SKSvg())
        //{
        //    svg.Load(stream);
        //    // ������������� SVG � ������������ � ��������� ������
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
        //    // ���������� SVG �� ������
        //    canvas.Clear();
        //    canvas.DrawPicture(svg.Picture, ref matrix);
        //}
        //0DisplayAlert("fwe", $"{list.Count}", "hguifdsag");

        // ��������� ���������� �� �����������


        var canvas = e.Surface.Canvas;
        canvas.Clear(); // clears the canvas for every frame
        var _info = e.Info;
        Assembly assembly = GetType().GetTypeInfo().Assembly;
        Stream stream = assembly.GetManifestResourceStream("CityVisitorFinaly.Resources.Images.test3.svg");

        using (SKSvg svg = new SKSvg())
        {
            svg.Load(stream);
            float scaleX = _info.Width / svg.Picture.CullRect.Width;
            float scaleY = _info.Height / svg.Picture.CullRect.Height;
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
                if (i < 10)
                {
                    paint.Style = SKPaintStyle.Fill;
                    paint.Color = Config.ColorFullVisit;
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
        //        // ��������� �� �������� canvas
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