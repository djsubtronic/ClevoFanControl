using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurveEditorControl
{
    public partial class PlotCanvasContainer: UserControl
    {
        public PlotCanvasContainer()
        {
            InitializeComponent();
        }

        public static int PlotHeight = 212;

        [Category("X Axis")]
        public string XAxisItem01 { get => lblXAxis1.Text; set => lblXAxis1.Text = value; }
        [Category("X Axis")]
        public string XAxisItem02 { get => lblXAxis2.Text; set => lblXAxis2.Text = value; }
        [Category("X Axis")]
        public string XAxisItem03 { get => lblXAxis3.Text; set => lblXAxis3.Text = value; }
        [Category("X Axis")]
        public string XAxisItem04 { get => lblXAxis4.Text; set => lblXAxis4.Text = value; }
        [Category("X Axis")]
        public string XAxisItem05 { get => lblXAxis5.Text; set => lblXAxis5.Text = value; }
        [Category("X Axis")]
        public string XAxisItem06 { get => lblXAxis6.Text; set => lblXAxis6.Text = value; }
        [Category("X Axis")]
        public string XAxisItem07 { get => lblXAxis7.Text; set => lblXAxis7.Text = value; }
        [Category("X Axis")]
        public string XAxisItem08 { get => lblXAxis8.Text; set => lblXAxis8.Text = value; }
        [Category("X Axis")]
        public string XAxisItem09 { get => lblXAxis9.Text; set => lblXAxis9.Text = value; }
        [Category("X Axis")]
        public string XAxisItem10 { get => lblXAxis10.Text; set => lblXAxis10.Text = value; }

        [Category("Values")]
        public int Value01 { get => currentPercentages[0]; set { currentPercentages[0] = value; } }
        [Category("Values")]
        public int Value02 { get => currentPercentages[1]; set { currentPercentages[1] = value; } }
        [Category("Values")]
        public int Value03 { get => currentPercentages[2]; set { currentPercentages[2] = value; } }
        [Category("Values")]
        public int Value04 { get => currentPercentages[3]; set { currentPercentages[3] = value; } }
        [Category("Values")]
        public int Value05 { get => currentPercentages[4]; set { currentPercentages[4] = value; } }
        [Category("Values")]
        public int Value06 { get => currentPercentages[5]; set { currentPercentages[5] = value; } }
        [Category("Values")]
        public int Value07 { get => currentPercentages[6]; set { currentPercentages[6] = value; } }
        [Category("Values")]
        public int Value08 { get => currentPercentages[7]; set { currentPercentages[7] = value; } }
        [Category("Values")]
        public int Value09 { get => currentPercentages[8]; set { currentPercentages[8] = value; } }
        [Category("Values")]
        public int Value10 { get => currentPercentages[9]; set { currentPercentages[9] = value; } }

        public int[] graphPoints = new int[10];

        public int[] currentPercentages = new int[10];

        
        public bool PlotMouseDown = false;
        Bitmap plotbg = new Bitmap(508, PlotHeight);

        public event Action<object, PlotChangedEventArgs> PlotChanged;
        
        private void PlotCanvasContainer_Load(object sender, EventArgs e) {
            var graphXPoints = new GraphXPoints();

            graphPoints[0] = graphXPoints.Point1;
            graphPoints[1] = graphXPoints.Point2;
            graphPoints[2] = graphXPoints.Point3;
            graphPoints[3] = graphXPoints.Point4;
            graphPoints[4] = graphXPoints.Point5;
            graphPoints[5] = graphXPoints.Point6;
            graphPoints[6] = graphXPoints.Point7;
            graphPoints[7] = graphXPoints.Point8;
            graphPoints[8] = graphXPoints.Point9;
            graphPoints[9] = graphXPoints.Point10;

            using (Graphics gfx = Graphics.FromImage(plotbg))
            using (SolidBrush brush = new SolidBrush(Color.Gainsboro)) {
                gfx.FillRectangle(brush, 0, 0, 508, PlotHeight);
            }
        }

        private void PlotCanvas_MouseDown(object sender, MouseEventArgs e) {
            PlotMouseDown = true;
        }

        private void PlotCanvas_MouseUp(object sender, MouseEventArgs e) {
            PlotMouseDown = false;
            var eArgs = new PlotChangedEventArgs();
            eArgs.PlotValues = currentPercentages;
            PlotChanged(sender, eArgs);
        }

        private void PlotCanvas_MouseMove(object sender, MouseEventArgs e) {
            if (PlotMouseDown) {
                var nearestX = GetNearestXPoint(e.X);
                var index = GetIndexFromXPoint(nearestX);
                var perc = GetPercentageFromYPoint(e.Y);

                if (perc < 0) {
                    perc = 0;
                } else if (perc > 100) {
                    perc = 100;
                }

                currentPercentages[index] = perc;
                UpdatePlot();
            }
        }

        private void PlotCanvas_Paint(object sender, PaintEventArgs e) {
            if (PlotMouseDown) {
                UpdatePlot();
            }
        }

        public void UpdatePlot() {            
            using (var e = PlotCanvas.CreateGraphics()) {
                e.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.DrawImage(plotbg, 0, 0);
                Pen p = new Pen(Color.LightGray, 1);
                e.DrawLine(p, new Point(graphPoints[0], 0), new Point(graphPoints[0], PlotHeight));
                e.DrawLine(p, new Point(graphPoints[1], 0), new Point(graphPoints[1], PlotHeight));
                e.DrawLine(p, new Point(graphPoints[2], 0), new Point(graphPoints[2], PlotHeight));
                e.DrawLine(p, new Point(graphPoints[3], 0), new Point(graphPoints[3], PlotHeight));
                e.DrawLine(p, new Point(graphPoints[4], 0), new Point(graphPoints[4], PlotHeight));
                e.DrawLine(p, new Point(graphPoints[5], 0), new Point(graphPoints[5], PlotHeight));
                e.DrawLine(p, new Point(graphPoints[6], 0), new Point(graphPoints[6], PlotHeight));
                e.DrawLine(p, new Point(graphPoints[7], 0), new Point(graphPoints[7], PlotHeight));
                e.DrawLine(p, new Point(graphPoints[8], 0), new Point(graphPoints[8], PlotHeight));
                e.DrawLine(p, new Point(graphPoints[9], 0), new Point(graphPoints[9], PlotHeight));
                Pen p2 = new Pen(Color.Gray, 2);
                for (int i = 1; i < 10; i++) {
                    e.DrawLine(p2, new Point(graphPoints[i], GetYPosFromPercentage(currentPercentages[i])), new Point(graphPoints[i - 1], GetYPosFromPercentage(currentPercentages[i - 1])));
                }

                for (int i = 0; i < 10; i++) {
                    e.FillEllipse(Brushes.Black, new Rectangle(graphPoints[i] - 4, GetYPosFromPercentage(currentPercentages[i]) - 4, 8, 8));
                }

                lblValue1.Text = currentPercentages[0] + "%";
                lblValue2.Text = currentPercentages[1] + "%";
                lblValue3.Text = currentPercentages[2] + "%";
                lblValue4.Text = currentPercentages[3] + "%";
                lblValue5.Text = currentPercentages[4] + "%";
                lblValue6.Text = currentPercentages[5] + "%";
                lblValue7.Text = currentPercentages[6] + "%";
                lblValue8.Text = currentPercentages[7] + "%";
                lblValue9.Text = currentPercentages[8] + "%";
                lblValue10.Text = currentPercentages[9] + "%";
            }
        }

            public int GetYPosFromPercentage(float Percent) {
            var ypos = (Percent / 100) * PlotHeight;
            return PlotHeight - (int)ypos;
        }

        public int GetPercentageFromYPoint(float Y) {
            var perc = (Y / PlotHeight) * 100;
            return 100 - (int)perc;
        }

        public int GetNearestXPoint(int X) {
            var nearest = graphPoints.OrderBy(x => Math.Abs((long)x - X)).First();
            return (int)nearest;
        }

        public int GetIndexFromXPoint(int X) {
            var nearest = Array.IndexOf(graphPoints, GetNearestXPoint(X));
            return nearest;
        }

        private void lblValue1_Click(object sender, EventArgs e) {
            UpdatePlot();
        }
    }

    public class GraphXPoints {
        public int Point1 = 23;
        public int Point2 = 23 + (int)(1 * 51.5);
        public int Point3 = 23 + (int)(2 * 51.5);
        public int Point4 = 23 + (int)(3 * 51.5);
        public int Point5 = 23 + (int)(4 * 51.5);
        public int Point6 = 23 + (int)(5 * 51.5);
        public int Point7 = 23 + (int)(6 * 51.5);
        public int Point8 = 23 + (int)(7 * 51.5);
        public int Point9 = 23 + (int)(8 * 51.5);
        public int Point10 = 23 + (int)(9 * 51.5);
    }

    public class PlotChangedEventArgs : EventArgs {
        public int[] PlotValues { get; set; }
    }
}
