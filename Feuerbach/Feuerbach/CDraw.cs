using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feuerbach
{
    class CDraw
    {

        private Pen pen;
        private Graphics graphics;
        private PointF center;
        private const float SF = 20;

        public void setCenter(PictureBox picCanvas)
        {
            center.X = picCanvas.Width / 2;
            center.Y = picCanvas.Height / 2;
        }

        public void graphTriangle(PointF vertexA, PointF vertexB, PointF vertexC, PictureBox picCanvas)
        {
            graphics = picCanvas.CreateGraphics();
            pen = new Pen(Color.Black, 2);

            graphics.DrawLine(pen, vertexA.X * SF + center.X, center.Y - vertexA.Y * SF,
                vertexB.X * SF + center.X, center.Y - vertexB.Y * SF);

            graphics.DrawLine(pen, vertexA.X * SF + center.X, center.Y - vertexA.Y * SF,
                vertexC.X * SF + center.X, center.Y - vertexC.Y * SF);

            graphics.DrawLine(pen, vertexC.X * SF + center.X, center.Y - vertexC.Y * SF,
                vertexB.X * SF + center.X, center.Y - vertexB.Y * SF);
        }   

        public void graphHeigth(PointF vertex, PointF heigth, PictureBox picCanvas)
        {
            graphics = picCanvas.CreateGraphics();
            pen = new Pen(Color.Red, 1);

            graphics.DrawLine(pen, vertex.X * SF + center.X, center.Y - vertex.Y * SF,
                heigth.X * SF + center.X, center.Y - heigth.Y * SF);            
        }

        public void graphPoint(PointF point, Color c, PictureBox picCanvas)
        {
            graphics = picCanvas.CreateGraphics();
            SolidBrush brush = new SolidBrush(c);

            graphics.FillEllipse(brush, point.X * SF - 3 + center.X, center.Y - point.Y * SF - 3, 6, 6);
        }

        public void graphCircle(PointF centerF, float radius, PictureBox picCanvas)
        {
            graphics = picCanvas.CreateGraphics();
            pen = new Pen(Color.HotPink, 1);
            graphics.DrawEllipse(pen, centerF.X * SF + center.X - radius * SF, center.Y - centerF.Y * SF - radius * SF,
                radius * 2 * SF, radius * 2 * SF);
        }

    }
}
