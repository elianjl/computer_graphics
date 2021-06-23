using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feuerbach
{
    class CTriangle
    {
        private float sideA, sideB, sideC;
        private PointF middleA, middleB, middleC;
        private PointF vertexA, vertexB, vertexC;
        private PointF orthocenter;
        private PointF heigthA, heigthB, heigthC;
        private PointF middleHeigthA, middleHeigthB, middleHeigthC;
        private PointF center;
        private float radius;


        public void setData(TextBox sideA, TextBox sideB, TextBox sideC)
        {
            this.sideA = float.Parse(sideA.Text);
            this.sideB = float.Parse(sideB.Text);
            this.sideC = float.Parse(sideC.Text);
            setVertex();
            calculateMidelPoints();
            calculateHeigth();
            middleHeigths();
            calculateCenterFeurbach();
            calculateRadius();
        }

        private void setVertex()
        {
            vertexA = new PointF(0, 0);
            vertexB = new PointF(sideC, 0);
            calculateVertexC();
        }
            
        private void calculateVertexC()
        {
            float angleA;
            angleA = (float)Math.Acos((Math.Pow(sideB, 2) + Math.Pow(sideC, 2) - Math.Pow(sideA, 2)) / (2 * sideB * sideC));
            vertexC = new PointF((float)Math.Cos(angleA) * sideB, (float)Math.Sin(angleA) * sideB);
        }

        private void calculateMidelPoints()
        {
            middleA.X = (vertexB.X + vertexC.X) / 2;
            middleA.Y = (vertexB.Y + vertexC.Y) / 2;

            middleB.X = (vertexA.X + vertexC.X) / 2;
            middleB.Y = (vertexA.Y + vertexC.Y) / 2;

            middleC.X = (vertexB.X + vertexA.X) / 2;
            middleC.Y = (vertexB.Y + vertexA.Y) / 2;
        }

        private void calculateHeigth()
        {
            CLine auxiliarSide = new CLine(vertexB,vertexC);
            CLine auxiliarHeigth = new CLine(vertexA, (-1) / auxiliarSide.Slope);
            heigthA = auxiliarSide.puntoEntreRectas(auxiliarHeigth);
            CLine aux = auxiliarHeigth;

            auxiliarSide = new CLine(vertexA, vertexC);
            auxiliarHeigth = new CLine(vertexB, (-1) / auxiliarSide.Slope);
            heigthB = auxiliarSide.puntoEntreRectas(auxiliarHeigth);
            

            heigthC = new PointF(vertexC.X, 0);

            orthocenter = aux.puntoEntreRectas(auxiliarHeigth);
        }

        private void middleHeigths()
        {
            middleHeigthA.X = (orthocenter.X + vertexA.X) / 2;
            middleHeigthA.Y = (orthocenter.Y + vertexA.Y) / 2;

            middleHeigthB.X = (orthocenter.X + vertexB.X) / 2;
            middleHeigthB.Y = (orthocenter.Y    + vertexB.Y) / 2;

            middleHeigthC.X = (orthocenter.X + vertexC.X) / 2;
            middleHeigthC.Y = (orthocenter.Y + vertexC.Y) / 2;
        }

        private void calculateCenterFeurbach()
        {            
            if(sideA == sideB && sideB == sideC)
            {
                center = orthocenter;
            }
            else {
                PointF auxPoint1 = new PointF();
                PointF auxPoint2 = new PointF();

                auxPoint1.X = (middleB.X + heigthB.X) / 2;
                auxPoint1.Y = (middleB.Y + heigthB.Y) / 2;

                auxPoint2.X = (heigthB.X + middleHeigthA.X) / 2;
                auxPoint2.Y = (heigthB.Y + middleHeigthA.Y) / 2;

                CLine aux1 = new CLine(middleB, heigthB);
                aux1 = new CLine(auxPoint1, (-1) / aux1.Slope);

                CLine aux2 = new CLine(heigthB, middleHeigthA);
                aux2 = new CLine(auxPoint2, (-1) / aux2.Slope);
                center = aux1.puntoEntreRectas(aux2);
            }
        }

        private void calculateRadius()
        {
            radius = (float)Math.Sqrt(Math.Pow(center.X - middleA.X, 2) + Math.Pow(center.Y - middleA.Y, 2));
        }
        
        public void graph(PictureBox picCanvas)
        {
            CDraw cDraw = new CDraw();
            cDraw.setCenter(picCanvas);
            cDraw.graphTriangle(vertexA, vertexB, vertexC,picCanvas);
            cDraw.graphHeigth(vertexA, heigthA, picCanvas);
            cDraw.graphHeigth(vertexB, heigthB, picCanvas);
            cDraw.graphHeigth(vertexC, heigthC, picCanvas);

            cDraw.graphPoint(vertexA, Color.Black, picCanvas);
            cDraw.graphPoint(vertexB, Color.Black, picCanvas);
            cDraw.graphPoint(vertexC, Color.Black, picCanvas);

            cDraw.graphPoint(orthocenter, Color.Red, picCanvas);

            cDraw.graphPoint(heigthA, Color.Green, picCanvas);
            cDraw.graphPoint(heigthB, Color.Green, picCanvas);
            cDraw.graphPoint(heigthC, Color.Green, picCanvas);

            cDraw.graphPoint(middleA, Color.Violet, picCanvas);
            cDraw.graphPoint(middleB, Color.Violet, picCanvas);
            cDraw.graphPoint(middleC, Color.Violet, picCanvas);

            cDraw.graphPoint(middleHeigthA, Color.Yellow, picCanvas);
            cDraw.graphPoint(middleHeigthB, Color.Yellow, picCanvas);
            cDraw.graphPoint(middleHeigthC, Color.Yellow, picCanvas);

            cDraw.graphPoint(center, Color.Blue, picCanvas);

            cDraw.graphCircle(center, radius, picCanvas);
            
        }
    }
}
