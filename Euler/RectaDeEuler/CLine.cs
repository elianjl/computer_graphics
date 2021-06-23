using System;
using System.Drawing;
using System.Windows.Forms;

namespace RectaDeEuler
{
    class CLine
    {
        private PointF point1, point2;
        private float slope;
        private float length;

        public CLine()
        {

        }

        public CLine(PointF punto1, float slope)
        {
            this.Point1 = punto1;
            this.Slope = slope;
        }

        public CLine(PointF punto1, PointF punto2)
        {
            this.Point1 = punto1;
            this.Point2 = punto2;
            SetSlope();
        }

        public CLine(PointF punto1, PointF punto2, float length)
        {
            this.point1 = punto1;
            this.point2 = punto2;
            this.length = length;
            SetSlope();
        }

        public PointF Point1 { get => point1; set => point1 = value; }
        public PointF Point2 { get => point2; set => point2 = value; }
        public float Slope { get => slope; set => slope = value; }
        public float Length { get => length; set => length = value; }

        public void SetSlope()
        {
            Slope = (Point2.Y - Point1.Y) / (Point2.X - Point1.X);
        }

        public PointF IntersectionPoint(CLine recta2)
        {
            PointF corte = new PointF();
            corte.X = (slope * point1.X - recta2.Slope * recta2.Point1.X - point1.Y + recta2.Point1.Y) / (slope - recta2.Slope);
            corte.Y = recta2.Slope * (corte.X - recta2.Point1.X) + recta2.Point1.Y;
            return corte;
        }

        public PointF[] Line(PictureBox picCanvas)
        {
            PointF[] line = new PointF[2];
            line[0] = Equation(0);
            line[1] = Equation(picCanvas.Width);
            return line;
        }

        public PointF Equation(float x)
        {
            float y;
            y = Slope * (x - point1.X) + point1.Y;
            return new PointF(x, y);
        }

        public string toEquation()
        {
            string equation = "";
            equation += "Y - " + (Math.Truncate(point1.Y * 100) / 100) + " = " + (Math.Truncate(slope * 100) / 100) + "(X - " + (Math.Truncate(point1.X * 100) / 100) + ")";
            return equation;
        }
    }
}
