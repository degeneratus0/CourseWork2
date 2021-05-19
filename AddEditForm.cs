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
    public partial class AddEditForm : Form
    {
        bool onEdit;
        public AddEditForm(bool onEdit)
        {
            InitializeComponent();
            this.onEdit = onEdit;
            if (onEdit)
            {
                this.Text = "Изменение";
            }
            else
            {
                this.Text = "Добавление";
            }
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            this.stationsTableAdapter.Fill(this.railroadDataSet.Stations);
            this.trainsTableAdapter.Fill(this.railroadDataSet.Trains);
            MainForm.f1 = (MainForm)this.Owner;
            trainNumTextBox.DataBindings.Add(new Binding("Text", MainForm.f1.trainsBS, "TrainNum", false, DataSourceUpdateMode.Never));
            destinationStationComboBox.DataBindings.Add(new Binding("SelectedValue", MainForm.f1.trainsBS, "DestinationStationId", false, DataSourceUpdateMode.Never));
            arrivalTimeDateTimePicker.DataBindings.Add(new Binding("Text", MainForm.f1.trainsBS, "ArrivalTime", false, DataSourceUpdateMode.Never));
            departureTimeDateTimePicker.DataBindings.Add(new Binding("Text", MainForm.f1.trainsBS, "DepartureTime", false, DataSourceUpdateMode.Never));
            vagonNumTextBox.DataBindings.Add(new Binding("Text", MainForm.f1.trainsBS, "VagonNum", false, DataSourceUpdateMode.Never));
            if (!onEdit)
            {
                MainForm.f1.trainsBS.AddNew();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Binding c in trainNumTextBox.DataBindings)
            {
                c.WriteValue();
            }
            foreach (Binding c in destinationStationComboBox.DataBindings)
            {
                c.WriteValue();
            }
            foreach (Binding c in arrivalTimeDateTimePicker.DataBindings)
            {
                c.WriteValue();
            }
            foreach (Binding c in departureTimeDateTimePicker.DataBindings)
            {
                c.WriteValue();
            }
            foreach (Binding c in vagonNumTextBox.DataBindings)
            {
                c.WriteValue();
            }
            MainForm.f1.trainsBS.EndEdit();
            MainForm.f1.trainsTA.Update(MainForm.f1.railroadDS);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
