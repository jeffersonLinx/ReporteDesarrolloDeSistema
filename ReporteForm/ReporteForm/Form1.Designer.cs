namespace ReporteForm
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.view_ProyectoCategoriaTableAdapter1 = new ReporteForm.GaleriaFotografica2DataSetTableAdapters.View_ProyectoCategoriaTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.galeriaFotografica2DataSet = new ReporteForm.GaleriaFotografica2DataSet();
            this.viewProyectoCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.View_ProyectoCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.galeriaFotografica2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewProyectoCategoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_ProyectoCategoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // view_ProyectoCategoriaTableAdapter1
            // 
            this.view_ProyectoCategoriaTableAdapter1.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.View_ProyectoCategoriaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReporteForm.ReportreView.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // galeriaFotografica2DataSet
            // 
            this.galeriaFotografica2DataSet.DataSetName = "GaleriaFotografica2DataSet";
            this.galeriaFotografica2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewProyectoCategoriaBindingSource
            // 
            this.viewProyectoCategoriaBindingSource.DataMember = "View_ProyectoCategoria";
            this.viewProyectoCategoriaBindingSource.DataSource = this.galeriaFotografica2DataSet;
            // 
            // View_ProyectoCategoriaBindingSource
            // 
            this.View_ProyectoCategoriaBindingSource.DataMember = "View_ProyectoCategoria";
            this.View_ProyectoCategoriaBindingSource.DataSource = this.galeriaFotografica2DataSet;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.galeriaFotografica2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewProyectoCategoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_ProyectoCategoriaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GaleriaFotografica2DataSetTableAdapters.View_ProyectoCategoriaTableAdapter view_ProyectoCategoriaTableAdapter1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource viewProyectoCategoriaBindingSource;
        private GaleriaFotografica2DataSet galeriaFotografica2DataSet;
        private System.Windows.Forms.BindingSource View_ProyectoCategoriaBindingSource;
    }
}

