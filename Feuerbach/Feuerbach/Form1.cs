using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feuerbach
{
    public partial class Form1 : Form
    {
        CTriangle cTriangle = new CTriangle();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
            cTriangle.setData(txtSideA, txtSideB, txtSideC);
            cTriangle.graph(picCanvas);            
        }
    }
}
