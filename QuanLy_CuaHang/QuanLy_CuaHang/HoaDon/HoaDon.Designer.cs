
namespace QuanLy_CuaHang.HoaDon
{
    partial class HoaDon
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
            this.DataSetHD = new QuanLy_CuaHang.HoaDon.DataSetHD();
            this.InhdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InhdTableAdapter = new QuanLy_CuaHang.HoaDon.DataSetHDTableAdapters.InhdTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InhdBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.InhdBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLy_CuaHang.HoaDon.ReportHD.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 465);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetHD
            // 
            this.DataSetHD.DataSetName = "DataSetHD";
            this.DataSetHD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // InhdBindingSource
            // 
            this.InhdBindingSource.DataMember = "Inhd";
            this.InhdBindingSource.DataSource = this.DataSetHD;
            // 
            // InhdTableAdapter
            // 
            this.InhdTableAdapter.ClearBeforeFill = true;
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.reportViewer1);
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InhdBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource InhdBindingSource;
        private DataSetHD DataSetHD;
        private DataSetHDTableAdapters.InhdTableAdapter InhdTableAdapter;
    }
}