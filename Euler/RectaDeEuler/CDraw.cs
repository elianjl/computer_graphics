using System;
using System.Drawing;
using System.Windows.Forms;

namespace RectaDeEuler
{
    class CDraw
    {
        PointF center;
        Pen pen;
        Graphics graphics;
        float SF = 30;

        public CDraw(PictureBox picCanvas)
        {
            calculateCenter(picCanvas);
            graphics = picCanvas.CreateGraphics();
        }

        private void calculateCenter(PictureBox picCanvas)
        {
            center.X = picCanvas.Width / 2 - picCanvas.Width /4;
            center.Y = picCanvas.Height / 2 + picCanvas.Height/4;
        }

        public void graphTriangle(PointF vertexA, PointF vertexB, PointF vertexC)
        {
            graphSegment(vertexA, vertexB,Color.Black);
            graphSegment(vertexA, vertexC,Color.Black);
            graphSegment(vertexC, vertexB,Color.Black);
        }
        
        private void graphSegment(PointF inicialPoint, PointF finalPoint, Color c)
        {
            pen = new Pen(c, 1);
            graphics.DrawLine(pen, inicialPoint.X * SF + center.X, center.Y - inicialPoint.Y * SF,
                finalPoint.X * SF + center.X, center.Y - finalPoint.Y * SF);
        }

        public void graphSegment(CLine segment, Color c)
        {
            pen = new Pen(c, 1);
            graphics.DrawLine(pen, segment.Point1.X * SF + center.X, center.Y - segment.Point1.Y * SF,
                segment.Point2.X * SF + center.X, center.Y - segment.Point2.Y * SF);
        }

        public void graphLine(PictureBox picCanvas, CLine line, Color c)
        {
            pen = new Pen(c, 1);
            PointF[] auxPoints = new PointF[2];
            auxPoints = line.Line(picCanvas);
            pen = new Pen(c, 1);
            graphics.DrawLine(pen, auxPoints[0].X * SF + center.X, center.Y - auxPoints[0].Y * SF,
                auxPoints[1].X * SF + center.X, center.Y - auxPoints[1].Y * SF);
        }

        public void graphEuler(PictureBox picCanvas, PointF centroid, PointF circumcenter, PointF orthocenter)
        {
            graphics = picCanvas.CreateGraphics();
            pen = new Pen(Color.Red,3);

            graphics.DrawLine(pen, centroid.X * SF + center.X, center.Y - centroid.Y * SF,
                circumcenter.X * SF + center.X, center.Y - circumcenter.Y * SF);

            graphics.DrawLine(pen, centroid.X * SF + center.X, center.Y - centroid.Y * SF,
                orthocenter.X * SF + center.X, center.Y - orthocenter.Y * SF);
        }

        public void graphAxis(PictureBox picCanvas)
        {
            pen = new Pen(Color.Black);

            graphics.DrawLine(pen, center.X - picCanvas.Width / 2, center.Y, 
                center.X + picCanvas.Width / 2, center.Y);
            
            graphics.DrawLine(pen, center.X, center.Y + picCanvas.Height / 2, 
                center.X, center.Y - picCanvas.Height / 2);
        }

        public void graphPoint(PointF center, float radius, Color c)
        {
            SolidBrush brush = new SolidBrush(c);
            graphics.FillEllipse(brush, center.X * SF + this.center.X - radius / 2,
                this.center.Y - center.Y * SF - radius / 2, radius, radius);
        }

        public void graphCircle(PointF center, float radius, Color c)
        {
            pen = new Pen(c, 1);
            graphics.DrawEllipse(pen, center.X * SF + this.center.X - radius * SF,
                this.center.Y - center.Y * SF - radius * SF, radius * SF * 2, radius * SF * 2);
        }
    }
}
