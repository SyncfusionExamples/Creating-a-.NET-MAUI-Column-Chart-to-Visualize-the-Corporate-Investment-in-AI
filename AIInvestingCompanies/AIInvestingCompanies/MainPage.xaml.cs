using Syncfusion.Maui.Charts;

namespace AIInvestingCompanies
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }

    public class CategoryAxisExt : CategoryAxis
    {
        protected override void DrawAxisLine(ICanvas canvas, float x1, float y1, float x2, float y2)
        {
            var path = new PathF();
            path.MoveTo(x1 + 20, y1);
            path.LineTo(x2, y2);

            // Calculate the direction vector of the line
            float dx = x2 - x1;
            float dy = y2 - y1;

            // Normalize the direction vector
            float length = (float)Math.Sqrt(dx * dx + dy * dy);
            float nx = dx / length;
            float ny = dy / length;

            // Length of the arrowhead
            float arrowLength = 15;

            // Calculate points for the arrowhead
            float arrowPoint1X = x1 + nx * arrowLength + ny * arrowLength / 2;
            float arrowPoint1Y = y1 + ny * arrowLength - nx * arrowLength / 2;
            float arrowPoint2X = x1 + nx * arrowLength - ny * arrowLength / 2;
            float arrowPoint2Y = y1 + ny * arrowLength + nx * arrowLength / 2;

            // Draw lines for the arrowhead
            path.MoveTo(x1 + 20, y1);
            path.LineTo(arrowPoint1X + 25, arrowPoint1Y - 5);
            path.MoveTo(x1 + 20, y1);
            path.LineTo(arrowPoint2X + 25, arrowPoint2Y + 5);

            canvas.StrokeColor = (new SolidColorBrush(Color.FromArgb("#1D5B6F"))).Color;

#if ANDROID || IOS
            canvas.StrokeSize = 1;

#elif MACCATALYST || WINDOWS
            canvas.StrokeSize = 3;

#endif
            canvas.DrawPath(path);
        }
    }
    public class NumericalAxisExt : NumericalAxis
    {
        protected override void DrawAxisLine(ICanvas canvas, float x1, float y1, float x2, float y2)
        {
            var path = new PathF();
            path.MoveTo(x1, y1 + 20);
            path.LineTo(x2, y2);

            // Calculate the direction vector of the line
            float dx = x2 - x1;
            float dy = y2 - y1;

            // Normalize the direction vector
            float length = (float)Math.Sqrt(dx * dx + dy * dy);
            float nx = dx / length;
            float ny = dy / length;

            // Length of the arrowhead
            float arrowLength = 12;

            // Calculate points for the arrowhead
            float arrowPoint1X = x1 + nx * arrowLength + ny * arrowLength / 2;
            float arrowPoint1Y = y1 + ny * arrowLength - nx * arrowLength / 2;
            float arrowPoint2X = x1 + nx * arrowLength - ny * arrowLength / 2;
            float arrowPoint2Y = y1 + ny * arrowLength + nx * arrowLength / 2;

            // Draw lines for the arrowhead
            path.MoveTo(x1, y1 + 20 );
            path.LineTo(arrowPoint1X + 5, arrowPoint1Y + 25);
            path.MoveTo(x1, y1 + 20 );
            path.LineTo(arrowPoint2X - 5, arrowPoint2Y + 25);

            canvas.StrokeColor = (new SolidColorBrush(Color.FromArgb("#1D5B6F"))).Color;

#if ANDROID || IOS
            canvas.StrokeSize = 1;

#elif MACCATALYST || WINDOWS
            canvas.StrokeSize = 3;

#endif
            canvas.DrawPath(path);
        }
    }
}