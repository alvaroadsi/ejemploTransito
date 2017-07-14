namespace EjemploReportes
{
    partial class reporteVehiculo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.transitoDataSet2 = new EjemploReportes.transitoDataSet2();
            this.VehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VehiculoTableAdapter = new EjemploReportes.transitoDataSet2TableAdapters.VehiculoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.transitoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehiculoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.VehiculoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EjemploReportes.ReporteVehiculos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(25, 53);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(682, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // transitoDataSet2
            // 
            this.transitoDataSet2.DataSetName = "transitoDataSet2";
            this.transitoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VehiculoBindingSource
            // 
            this.VehiculoBindingSource.DataMember = "Vehiculo";
            this.VehiculoBindingSource.DataSource = this.transitoDataSet2;
            // 
            // VehiculoTableAdapter
            // 
            this.VehiculoTableAdapter.ClearBeforeFill = true;
            // 
            // reporteVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 314);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reporteVehiculo";
            this.Text = "reporteVehiculo";
            this.Load += new System.EventHandler(this.reporteVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transitoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehiculoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VehiculoBindingSource;
        private transitoDataSet2 transitoDataSet2;
        private transitoDataSet2TableAdapters.VehiculoTableAdapter VehiculoTableAdapter;
    }
}