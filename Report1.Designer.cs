namespace Railroad_Access_
{
    partial class Report1
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
            this.query1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.railroadDataSet = new Railroad_Access_.RailroadDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.query1TableAdapter = new Railroad_Access_.RailroadDataSetTableAdapters.Query1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.query1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.railroadDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // query1BindingSource
            // 
            this.query1BindingSource.DataMember = "Query1";
            this.query1BindingSource.DataSource = this.railroadDataSet;
            this.query1BindingSource.CurrentChanged += new System.EventHandler(this.query1BindingSource_CurrentChanged);
            // 
            // railroadDataSet
            // 
            this.railroadDataSet.DataSetName = "RailroadDataSet";
            this.railroadDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Railroad_Access_.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ServerReport.ReportServerUrl = new System.Uri("", System.UriKind.Relative);
            this.reportViewer1.Size = new System.Drawing.Size(940, 497);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // query1TableAdapter
            // 
            this.query1TableAdapter.ClearBeforeFill = true;
            // 
            // Report1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 497);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report1";
            this.Text = "Report1";
            this.Load += new System.EventHandler(this.Report1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.query1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.railroadDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private RailroadDataSet railroadDataSet;
        private System.Windows.Forms.BindingSource query1BindingSource;
        private RailroadDataSetTableAdapters.Query1TableAdapter query1TableAdapter;
    }
}