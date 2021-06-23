using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RectaDeEuler
{
    public partial class Euler : Form
    {
        CTriangle triangle;
        public Euler()
        {
            InitializeComponent();
            triangle = new CTriangle();
        }                

        private void chbHeigth_CheckedChanged(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Los lados no pueden estar vacios");
            }
            else
            {
                if (chbHeigth.Checked)
                {
                    if (triangle.isTriangle(txtSideA, txtSideB, txtSideC))
                    {
                        triangle.setData(txtSideA, txtSideB, txtSideC, picCanvas);
                        triangle.GraphHeigts(picCanvas);
                        chbHeigth.Checked = false;
                    }
                    else
                    {
                        MessageBox.Show("Los lados especificados no formar un triangulo");
                    }
                }
            }
        }

        private void chbMedians_CheckedChanged(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Los lados no pueden estar vacios");
            }
            else
            {
                if (triangle.isTriangle(txtSideA, txtSideB, txtSideC))
                {
                    if (chbMedians.Checked)
                    {
                        triangle.setData(txtSideA, txtSideB, txtSideC, picCanvas);
                        triangle.graphMedians(picCanvas);
                        chbMedians.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show("Los lados especificados no formar un triangulo");
                }
            }
        }

        private void chbMediatrix_CheckedChanged(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Los lados no pueden estar vacios");
            }
            else
            {
                if (triangle.isTriangle(txtSideA, txtSideB, txtSideC))
                {
                    if (chbMediatrix.Checked)
                    {
                        triangle.setData(txtSideA, txtSideB, txtSideC, picCanvas);
                        triangle.graphMediatrix(picCanvas);
                        chbMediatrix.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show("Los lados especificados no formar un triangulo");
                }
            }
}

        private void chbEuler_CheckedChanged(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Los lados no pueden estar vacios");
            }
            else
            {
                if (triangle.isTriangle(txtSideA, txtSideB, txtSideC))
                {
                    if (chbEuler.Checked)
                    {
                        triangle.setData(txtSideA, txtSideB, txtSideC, picCanvas);
                        triangle.GraphEuler(picCanvas, txtEquation);
                        chbEuler.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show("Los lados especificados no formar un triangulo");
                }
            }
        }

        private bool isEmpty()
        {
            if(txtSideA.Text == "" || txtSideB.Text == "" || txtSideC.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Euler_Load(object sender, EventArgs e)
        {

        }
    }
}
