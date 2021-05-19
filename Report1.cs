using System;
using Microsoft.Reporting.WinForms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Railroad_Access_
{
    public partial class Report1 : Form
    {
        public Report1()
        {
            InitializeComponent();
        }

        private void Report1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "railroadDataSet.Query1". При необходимости она может быть перемещена или удалена.
            this.query1TableAdapter.Fill(this.railroadDataSet.Query1);
            MainForm mf = new MainForm();
            ReportDataSource repDS = new ReportDataSource();
            repDS.Name = "DataSet1";
            repDS.Value = mf.trainsBS;
            reportViewer1.LocalReport.DataSources.Add(repDS);
            this.reportViewer1.RefreshReport();
        }

        private void query1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
