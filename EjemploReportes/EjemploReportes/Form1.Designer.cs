﻿namespace EjemploReportes
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteGuardasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteVehiculoMasComparendoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(583, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteGuardasToolStripMenuItem,
            this.reporteVehiculosToolStripMenuItem,
            this.reporteVehiculoMasComparendoToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteGuardasToolStripMenuItem
            // 
            this.reporteGuardasToolStripMenuItem.Name = "reporteGuardasToolStripMenuItem";
            this.reporteGuardasToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.reporteGuardasToolStripMenuItem.Text = "Reporte Guardas";
            this.reporteGuardasToolStripMenuItem.Click += new System.EventHandler(this.reporteGuardasToolStripMenuItem_Click);
            // 
            // reporteVehiculosToolStripMenuItem
            // 
            this.reporteVehiculosToolStripMenuItem.Name = "reporteVehiculosToolStripMenuItem";
            this.reporteVehiculosToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.reporteVehiculosToolStripMenuItem.Text = "Reporte Vehiculos";
            this.reporteVehiculosToolStripMenuItem.Click += new System.EventHandler(this.reporteVehiculosToolStripMenuItem_Click);
            // 
            // reporteVehiculoMasComparendoToolStripMenuItem
            // 
            this.reporteVehiculoMasComparendoToolStripMenuItem.Name = "reporteVehiculoMasComparendoToolStripMenuItem";
            this.reporteVehiculoMasComparendoToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.reporteVehiculoMasComparendoToolStripMenuItem.Text = "Reporte Vehiculo mas comparendo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 285);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "::. TRANSITO";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteGuardasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteVehiculoMasComparendoToolStripMenuItem;
    }
}

