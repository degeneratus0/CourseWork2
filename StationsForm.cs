using System;
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
    public partial class StationsForm : Form
    {
        public StationsForm()
        {
            InitializeComponent();
        }

        private void StationsForm_Load(object sender, EventArgs e)
        {
            this.stationsTableAdapter.Fill(this.railroadDataSet.Stations);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            railroadDataSet.Stations.AddStationsRow(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Validate();
            stationsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.railroadDataSet);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stationsBindingSource.RemoveCurrent();
            stationsTableAdapter.Update(railroadDataSet);
        }
    }
}
