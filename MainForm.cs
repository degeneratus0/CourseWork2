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
    public partial class MainForm : Form
    {
        public static MainForm f1;
        public BindingSource trainsBS
        {
            get
            {
                return this.trainsBindingSource;
            }
            set
            {
                this.trainsBindingSource = value;
            }
        }
        public RailroadDataSetTableAdapters.TrainsTableAdapter trainsTA
        {
            get
            {
                return this.trainsTableAdapter;
            }
            set
            {
                this.trainsTableAdapter = value;
            }
        }
        public RailroadDataSet railroadDS
        {
            get
            {
                return this.railroadDataSet;
            }
            set
            {
                this.railroadDataSet = value;
            }
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            this.stationsTableAdapter.Fill(this.railroadDataSet.Stations);
            this.trainsTableAdapter.Fill(this.railroadDataSet.Trains);

        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditForm f2 = new AddEditForm(true);
            f2.Owner = this;
            f2.Show();
        }
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditForm f2 = new AddEditForm(false);
            f2.Owner = this;
            f2.Show();
        }
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteForm df = new DeleteForm();
            if (df.ShowDialog() == DialogResult.Yes)
            {
                df.Close();
                trainsBindingSource.RemoveCurrent();
                trainsTableAdapter.Update(railroadDataSet);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string i = comboBox1.Text;
                switch (i)
                {
                    case "Номер поезда":
                        trainsBindingSource.Filter = "TrainNum = " + textBox1.Text.Trim();
                        break;
                    case "Время прибытия":
                        trainsBindingSource.Filter = "ArrivalTime >= '" + dateTimePicker1.Value.AddDays(-1) + "' and ArrivalTime < '" + dateTimePicker1.Value + "'";
                        break;
                    case "Время отправления":
                        trainsBindingSource.Filter = "DepartureTime >= '" + dateTimePicker1.Value.AddDays(-1) + "' and DepartureTime < '" + dateTimePicker1.Value + "'";
                        break;
                }
            }
            catch (Exception ex)
            {
                 MessageBox.Show("Некорректное значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            trainsBindingSource.Filter = "";
            textBox1.Text = "";
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var i = comboBox1.SelectedIndex;
            switch (i)
            {
                case 0:
                    textBox1.Visible = true;
                    dateTimePicker1.Visible = false;
                    break;
                case 1:
                    goto case 2;
                case 2:
                    textBox1.Visible = false;
                    textBox1.Text = "";
                    dateTimePicker1.Visible = true;
                    break;
            }
        }

        private void станцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StationsForm sf = new StationsForm();
            sf.Show();
        }
    }
}
