using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feuerbach
{
    class CLine
    {
        private PointF punto1, punto2;
        private float slope;

        public CLine(PointF punto1, float slope)
        {
            this.Punto1 = punto1;
            this.Slope = slope;
        }

        public CLine(PointF punto1, PointF punto2)
        {
            this.Punto1 = punto1;
            this.Punto2 = punto2;
            setSlope();
        }

        public PointF Punto1 { get => punto1; set => punto1 = value; }
        public PointF Punto2 { get => punto2; set => punto2 = value; }
        public float Slope { get => slope; set => slope = value; }

        public void setSlope()
        {
            Slope = (Punto2.Y - Punto1.Y) / (Punto2.X - Punto1.X);
        }

        public PointF puntoEntreRectas(CLine recta2)
        {
            PointF corte = new PointF();
            corte.X = (slope * punto1.X - recta2.Slope * recta2.Punto1.X - punto1.Y + recta2.Punto1.Y) / (slope - recta2.Slope);
            corte.Y = recta2.Slope * (corte.X - recta2.Punto1.X) + recta2.Punto1.Y;
            return corte;
        }
    }
}
