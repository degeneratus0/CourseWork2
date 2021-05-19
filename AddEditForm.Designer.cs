namespace Railroad_Access_
{
    partial class AddEditForm
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
            System.Windows.Forms.Label trainNumLabel;
            System.Windows.Forms.Label destinationStationLabel;
            System.Windows.Forms.Label arrivalTimeLabel;
            System.Windows.Forms.Label departureTimeLabel;
            System.Windows.Forms.Label vagonNumLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditForm));
            this.railroadDataSet = new Railroad_Access_.RailroadDataSet();
            this.trainsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainsTableAdapter = new Railroad_Access_.RailroadDataSetTableAdapters.TrainsTableAdapter();
            this.tableAdapterManager = new Railroad_Access_.RailroadDataSetTableAdapters.TableAdapterManager();
            this.trainNumTextBox = new System.Windows.Forms.TextBox();
            this.arrivalTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.departureTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vagonNumTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.destinationStationComboBox = new System.Windows.Forms.ComboBox();
            this.stationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stationsTableAdapter = new Railroad_Access_.RailroadDataSetTableAdapters.StationsTableAdapter();
            trainNumLabel = new System.Windows.Forms.Label();
            destinationStationLabel = new System.Windows.Forms.Label();
            arrivalTimeLabel = new System.Windows.Forms.Label();
            departureTimeLabel = new System.Windows.Forms.Label();
            vagonNumLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.railroadDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // trainNumLabel
            // 
            trainNumLabel.AutoSize = true;
            trainNumLabel.Location = new System.Drawing.Point(12, 9);
            trainNumLabel.Name = "trainNumLabel";
            trainNumLabel.Size = new System.Drawing.Size(83, 13);
            trainNumLabel.TabIndex = 3;
            trainNumLabel.Text = "Номер поезда:";
            // 
            // destinationStationLabel
            // 
            destinationStationLabel.AutoSize = true;
            destinationStationLabel.Location = new System.Drawing.Point(12, 35);
            destinationStationLabel.Name = "destinationStationLabel";
            destinationStationLabel.Size = new System.Drawing.Size(114, 13);
            destinationStationLabel.TabIndex = 5;
            destinationStationLabel.Text = "Станция назначения:";
            // 
            // arrivalTimeLabel
            // 
            arrivalTimeLabel.AutoSize = true;
            arrivalTimeLabel.Location = new System.Drawing.Point(12, 62);
            arrivalTimeLabel.Name = "arrivalTimeLabel";
            arrivalTimeLabel.Size = new System.Drawing.Size(95, 13);
            arrivalTimeLabel.TabIndex = 7;
            arrivalTimeLabel.Text = "Время прибытия:";
            // 
            // departureTimeLabel
            // 
            departureTimeLabel.AutoSize = true;
            departureTimeLabel.Location = new System.Drawing.Point(12, 88);
            departureTimeLabel.Name = "departureTimeLabel";
            departureTimeLabel.Size = new System.Drawing.Size(111, 13);
            departureTimeLabel.TabIndex = 9;
            departureTimeLabel.Text = "Время отправления:";
            // 
            // vagonNumLabel
            // 
            vagonNumLabel.AutoSize = true;
            vagonNumLabel.Location = new System.Drawing.Point(12, 113);
            vagonNumLabel.Name = "vagonNumLabel";
            vagonNumLabel.Size = new System.Drawing.Size(113, 13);
            vagonNumLabel.TabIndex = 11;
            vagonNumLabel.Text = "Количество вагонов:";
            // 
            // railroadDataSet
            // 
            this.railroadDataSet.DataSetName = "RailroadDataSet";
            this.railroadDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trainsBindingSource
            // 
            this.trainsBindingSource.DataMember = "Trains";
            this.trainsBindingSource.DataSource = this.railroadDataSet;
            // 
            // trainsTableAdapter
            // 
            this.trainsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StationsTableAdapter = null;
            this.tableAdapterManager.TrainsTableAdapter = this.trainsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Railroad_Access_.RailroadDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // trainNumTextBox
            // 
            this.trainNumTextBox.Location = new System.Drawing.Point(126, 6);
            this.trainNumTextBox.Name = "trainNumTextBox";
            this.trainNumTextBox.Size = new System.Drawing.Size(200, 20);
            this.trainNumTextBox.TabIndex = 4;
            // 
            // arrivalTimeDateTimePicker
            // 
            this.arrivalTimeDateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm";
            this.arrivalTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.arrivalTimeDateTimePicker.Location = new System.Drawing.Point(126, 58);
            this.arrivalTimeDateTimePicker.Name = "arrivalTimeDateTimePicker";
            this.arrivalTimeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.arrivalTimeDateTimePicker.TabIndex = 8;
            this.arrivalTimeDateTimePicker.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // departureTimeDateTimePicker
            // 
            this.departureTimeDateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm";
            this.departureTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.departureTimeDateTimePicker.Location = new System.Drawing.Point(126, 84);
            this.departureTimeDateTimePicker.Name = "departureTimeDateTimePicker";
            this.departureTimeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.departureTimeDateTimePicker.TabIndex = 10;
            this.departureTimeDateTimePicker.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // vagonNumTextBox
            // 
            this.vagonNumTextBox.Location = new System.Drawing.Point(126, 110);
            this.vagonNumTextBox.Name = "vagonNumTextBox";
            this.vagonNumTextBox.Size = new System.Drawing.Size(200, 20);
            this.vagonNumTextBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(251, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Отменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // destinationStationComboBox
            // 
            this.destinationStationComboBox.DataSource = this.stationsBindingSource;
            this.destinationStationComboBox.DisplayMember = "StationName";
            this.destinationStationComboBox.FormattingEnabled = true;
            this.destinationStationComboBox.Location = new System.Drawing.Point(126, 31);
            this.destinationStationComboBox.Name = "destinationStationComboBox";
            this.destinationStationComboBox.Size = new System.Drawing.Size(200, 21);
            this.destinationStationComboBox.TabIndex = 14;
            this.destinationStationComboBox.ValueMember = "StationId";
            // 
            // stationsBindingSource
            // 
            this.stationsBindingSource.DataMember = "Stations";
            this.stationsBindingSource.DataSource = this.railroadDataSet;
            // 
            // stationsTableAdapter
            // 
            this.stationsTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 168);
            this.Controls.Add(this.destinationStationComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(trainNumLabel);
            this.Controls.Add(this.trainNumTextBox);
            this.Controls.Add(destinationStationLabel);
            this.Controls.Add(arrivalTimeLabel);
            this.Controls.Add(this.arrivalTimeDateTimePicker);
            this.Controls.Add(departureTimeLabel);
            this.Controls.Add(this.departureTimeDateTimePicker);
            this.Controls.Add(vagonNumLabel);
            this.Controls.Add(this.vagonNumTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Добавление";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.railroadDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RailroadDataSet railroadDataSet;
        private System.Windows.Forms.BindingSource trainsBindingSource;
        private RailroadDataSetTableAdapters.TrainsTableAdapter trainsTableAdapter;
        private RailroadDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox trainNumTextBox;
        private System.Windows.Forms.DateTimePicker arrivalTimeDateTimePicker;
        private System.Windows.Forms.DateTimePicker departureTimeDateTimePicker;
        private System.Windows.Forms.TextBox vagonNumTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox destinationStationComboBox;
        private System.Windows.Forms.BindingSource stationsBindingSource;
        private RailroadDataSetTableAdapters.StationsTableAdapter stationsTableAdapter;
    }
}