using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploReportes
{
    public partial class Form1 : Form
    {
        reporteGuarda rg;
        reporteVehiculo rv;

        static public int seg_rg=0;
        static public int seg_rv = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void reporteGuardasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seg_rg == 0)
            {
                rg = new reporteGuarda();
                rg.MdiParent = this;
                rg.Show();
                seg_rg = 1;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void reporteVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seg_rv == 0)
            {
                rv = new reporteVehiculo();
                rv.MdiParent = this;
                rv.Show();
                seg_rv = 1;
            }
        }
    }
}
