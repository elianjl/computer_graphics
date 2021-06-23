using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RectaDeEuler
{
    class CTriangle
    {
        private PointF vertexA;
        private PointF vertexB;
        private PointF vertexC;
        private PointF vertexOA;
        private PointF vertexOB;
        private PointF vertexOC;
        private CLine sideA;
        private CLine sideB;
        private CLine sideC;
        private CLine heigthA;
        private CLine heigthB;
        private CLine heigthC;
        private CLine mediatrixA;
        private CLine mediatrixB;
        private CLine mediatrixC;
        private CLine medianA;
        private CLine medianB;
        private CLine medianC;
        private CLine euler;
        private PointF orthocenter;
        private PointF circumcenter;
        private PointF centroid;
        private CDraw cDraw;
        private float orticradius;
        private PointF orticCenter;

        public void setData(TextBox sideA, TextBox sideB, TextBox sideC,PictureBox picCanvas)
        {
            this.sideA = new CLine();
            this.sideB = new CLine();
            this.sideC = new CLine();
            this.sideA.Length = float.Parse(sideA.Text);
            this.sideB.Length = float.Parse(sideB.Text);
            this.sideC.Length = float.Parse(sideC.Text);
            setVertex();
            CalculateCentroid(picCanvas);
            CalculateCircumcenter(picCanvas);
            CalculateOrthocenter(picCanvas);
            cDraw = new CDraw(picCanvas);
            euler = new CLine(centroid, orthocenter);
        }

        private void setVertex()
        {
            vertexA = new PointF(0, 0);            
            vertexB = new PointF(sideC.Length, 0);            
            calculateVertexC();

            sideA.Point1 = vertexB;
            sideA.Point2 = vertexC;
            
            sideB.Point1 = vertexA;
            sideB.Point2 = vertexC;
            
            sideC.Point1 = vertexA;
            sideC.Point2 = vertexB;

            sideA.SetSlope();
            sideB.SetSlope();
            sideC.SetSlope();
        }

        private void calculateVertexC()
        {
            float angleA;
            angleA = (float)Math.Acos((Math.Pow(sideB.Length, 2) + Math.Pow(sideC.Length, 2) - Math.Pow(sideA.Length, 2)) /
                (2 * sideB.Length * sideC.Length));
            vertexC = new PointF((float)Math.Cos(angleA) * sideB.Length, (float)Math.Sin(angleA) * sideB.Length);
        }

        private void CalculateOrthocenter(PictureBox picCanvas)
        {
            vertexOC.X = vertexC.X;
            vertexOC.Y = 0;
            heigthC = new CLine(vertexC, vertexOC);

            heigthA = new CLine(vertexA, (-1) / sideA.Slope);
            vertexOA = heigthA.IntersectionPoint(sideA);
            heigthA.Point2 = vertexOA;

            heigthB = new CLine(vertexB, (-1) / sideB.Slope);
            vertexOB = heigthB.IntersectionPoint(sideB);
            heigthB.Point2 = vertexOB;

            orthocenter = heigthA.IntersectionPoint(heigthB);
        }

        private void CalculateCircumcenter(PictureBox picCanvas)
        {
            PointF temporal;

            temporal = new PointF((vertexB.X + vertexC.X) /2, (vertexB.Y + vertexC.Y) / 2);
            mediatrixA = new CLine(temporal, (-1) / sideA.Slope);
                        
            temporal = new PointF((vertexA.X + vertexC.X) /2, (vertexA.Y + vertexC.Y) / 2);
            mediatrixB = new CLine(temporal, (-1) / sideB.Slope);
            
            temporal = new PointF((vertexA.X + vertexB.X) /2, (vertexA.Y + vertexB.Y) / 2);
            mediatrixC = new CLine(temporal, (-1) / sideC.Slope);

            circumcenter = mediatrixA.IntersectionPoint(mediatrixB);

            mediatrixA.Point2 = circumcenter;
            mediatrixB.Point2 = circumcenter;
            mediatrixC.Point2 = circumcenter;
        }

        private void CalculateCentroid(PictureBox picCanvas)
        {
            medianA = new CLine(vertexA, new PointF((vertexB.X + vertexC.X) / 2, (vertexB.Y + vertexC.Y) / 2));
            medianB = new CLine(vertexB, new PointF((vertexA.X + vertexC.X) / 2, (vertexA.Y + vertexC.Y) / 2));
            medianC = new CLine(vertexC, new PointF((vertexB.X + vertexA.X) / 2, (vertexB.Y + vertexA.Y) / 2));
            centroid.X = (vertexA.X + vertexB.X + vertexC.X) / 3;
            centroid.Y = (vertexA.Y + vertexB.Y + vertexC.Y) / 3;
        }        

        public void GraphEuler(PictureBox picCanvas, TextBox equation)
        {
            picCanvas.Refresh();
            cDraw.graphAxis(picCanvas);
            cDraw.graphTriangle(vertexA,vertexB,vertexC);

            cDraw.graphSegment(medianA, Color.YellowGreen);
            cDraw.graphSegment(medianC, Color.YellowGreen);

            cDraw.graphSegment(heigthA, Color.BlueViolet);
            cDraw.graphSegment(heigthB, Color.BlueViolet);

            cDraw.graphSegment(mediatrixA, Color.Orange);
            cDraw.graphSegment(mediatrixB, Color.Orange);

            cDraw.graphEuler(picCanvas, centroid, circumcenter, orthocenter);
            
            cDraw.graphPoint(orthocenter, 8, Color.Blue);
            cDraw.graphPoint(centroid, 8, Color.Green);
            cDraw.graphPoint(circumcenter, 8, Color.Red);

            equation.Text = euler.toEquation();
        }

        public void GraphHeigts(PictureBox picCanvas)
        {
            picCanvas.Refresh();
            cDraw.graphAxis(picCanvas);
            cDraw.graphTriangle(vertexA, vertexB, vertexC);
            cDraw.graphSegment(heigthA, Color.BlueViolet);
            cDraw.graphSegment(heigthB, Color.BlueViolet);
            cDraw.graphSegment(heigthC, Color.BlueViolet);
            cDraw.graphPoint(orthocenter, 4, Color.Blue);
            cDraw.graphTriangle(vertexOA, vertexOB, vertexOC);
            calculateIncentro();
            calculateIncentroRadius();
            cDraw.graphCircle(orticCenter, orticradius, Color.Blue);
        }

        public void graphMedians(PictureBox picCanvas)
        {
            picCanvas.Refresh();
            cDraw.graphAxis(picCanvas);
            cDraw.graphTriangle(vertexA, vertexB, vertexC);
            cDraw.graphSegment(medianA, Color.GreenYellow);
            cDraw.graphSegment(medianB, Color.GreenYellow);
            cDraw.graphSegment(medianC, Color.GreenYellow);
            cDraw.graphPoint(centroid, 4, Color.Green);
        }

        public void graphMediatrix(PictureBox picCanvas)
        {
            float radius;
            picCanvas.Refresh();
            cDraw.graphAxis(picCanvas);
            cDraw.graphTriangle(vertexA, vertexB, vertexC);
            cDraw.graphSegment(mediatrixA, Color.Orange);
            cDraw.graphSegment(mediatrixB, Color.Orange);
            cDraw.graphSegment(mediatrixC, Color.Orange);
            cDraw.graphPoint(circumcenter, 4, Color.Red);
            radius = calculateLength(circumcenter, vertexA);
            cDraw.graphCircle(circumcenter, radius, Color.Orange);
        }

        public float calculateLength(PointF point1, PointF point2)
        {
            float length;
            length = (float)Math.Sqrt(Math.Pow(point1.X - point2.X, 2) + Math.Pow(point1.Y - point2.Y, 2));
            return length;
        }

        private void calculateIncentroRadius()
        {
            float semiperimeter;
            float area;
            float a, b, c;
            a = calculateLength(vertexOB, vertexOC);
            b = calculateLength(vertexOA, vertexOC);
            c = calculateLength(vertexOB, vertexOA);
            semiperimeter = (a + b + c) / 2;
            area = (float)Math.Sqrt(semiperimeter * (semiperimeter - a) * (semiperimeter - b) * (semiperimeter - c));
            orticradius = area / semiperimeter;
        }

        private void calculateIncentro()
        {
            float a,b,c;

            a = calculateLength(vertexOB, vertexOC);
            b = calculateLength(vertexOA, vertexOC);
            c = calculateLength(vertexOB, vertexOA);

            orticCenter.X = (a * vertexOA.X + b * vertexOB.X + c * vertexOC.X) / (a + b + c);

            orticCenter.Y = (a * vertexOA.Y + b * vertexOB.Y + c * vertexOC.Y) / (a + b + c);
        }

        public bool isTriangle(TextBox sideA, TextBox sideB, TextBox sideC)
        {
            float a, b, c;
            a = float.Parse(sideA.Text);
            b = float.Parse(sideB.Text);
            c = float.Parse(sideC.Text);

            if(a + b <= c || a + c <= b || b + c <= a)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
