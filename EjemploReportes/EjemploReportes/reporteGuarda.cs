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
    public partial class reporteGuarda : Form
    {
        public reporteGuarda()
        {
            InitializeComponent();
        }

        private void reporteGuarda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transitoDataSet.Guarda' table. You can move, or remove it, as needed.
            this.GuardaTableAdapter.Fill(this.transitoDataSet.Guarda);

            this.reportViewer1.RefreshReport();
        }

        private void reporteGuarda_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.seg_rg = 0;
        }
    }
}
