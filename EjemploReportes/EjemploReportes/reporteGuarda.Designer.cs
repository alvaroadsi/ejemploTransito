namespace EjemploReportes
{
    partial class reporteGuarda
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
            this.transitoDataSet = new EjemploReportes.transitoDataSet();
            this.GuardaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GuardaTableAdapter = new EjemploReportes.transitoDataSetTableAdapters.GuardaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.transitoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuardaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1Guardas";
            reportDataSource1.Value = this.GuardaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EjemploReportes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 44);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(689, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // transitoDataSet
            // 
            this.transitoDataSet.DataSetName = "transitoDataSet";
            this.transitoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GuardaBindingSource
            // 
            this.GuardaBindingSource.DataMember = "Guarda";
            this.GuardaBindingSource.DataSource = this.transitoDataSet;
            // 
            // GuardaTableAdapter
            // 
            this.GuardaTableAdapter.ClearBeforeFill = true;
            // 
            // reporteGuarda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 363);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reporteGuarda";
            this.Text = "reporteGuarda";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.reporteGuarda_FormClosed);
            this.Load += new System.EventHandler(this.reporteGuarda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transitoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuardaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GuardaBindingSource;
        private transitoDataSet transitoDataSet;
        private transitoDataSetTableAdapters.GuardaTableAdapter GuardaTableAdapter;
    }
}