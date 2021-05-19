namespace Railroad_Access_
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.поездаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.станцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчет1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поездаПоСтанцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.trainsDataGridView = new System.Windows.Forms.DataGridView();
            this.trainIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationStationIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.stationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.railroadDataSet = new Railroad_Access_.RailroadDataSet();
            this.arrivalTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vagonNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainsTableAdapter = new Railroad_Access_.RailroadDataSetTableAdapters.TrainsTableAdapter();
            this.tableAdapterManager = new Railroad_Access_.RailroadDataSetTableAdapters.TableAdapterManager();
            this.stationsTableAdapter = new Railroad_Access_.RailroadDataSetTableAdapters.StationsTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.railroadDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поездаToolStripMenuItem,
            this.станцииToolStripMenuItem,
            this.отчетыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(510, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поездаToolStripMenuItem
            // 
            this.поездаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.поездаToolStripMenuItem.Name = "поездаToolStripMenuItem";
            this.поездаToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.поездаToolStripMenuItem.Text = "Учёт";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // станцииToolStripMenuItem
            // 
            this.станцииToolStripMenuItem.Name = "станцииToolStripMenuItem";
            this.станцииToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.станцииToolStripMenuItem.Text = "Станции";
            this.станцииToolStripMenuItem.Click += new System.EventHandler(this.станцииToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчет1ToolStripMenuItem,
            this.поездаПоСтанцииToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // отчет1ToolStripMenuItem
            // 
            this.отчет1ToolStripMenuItem.Name = "отчет1ToolStripMenuItem";
            this.отчет1ToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.отчет1ToolStripMenuItem.Text = "Поезда за период";
            // 
            // поездаПоСтанцииToolStripMenuItem
            // 
            this.поездаПоСтанцииToolStripMenuItem.Name = "поездаПоСтанцииToolStripMenuItem";
            this.поездаПоСтанцииToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.поездаПоСтанцииToolStripMenuItem.Text = "Поезда по станции";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 29);
            this.panel1.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(195, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(122, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(382, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Сброс";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.Items.AddRange(new object[] {
            "Номер поезда",
            "Время прибытия",
            "Время отправления"});
            this.comboBox1.Location = new System.Drawing.Point(67, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(122, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск по";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.trainsDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(510, 250);
            this.panel2.TabIndex = 6;
            // 
            // trainsDataGridView
            // 
            this.trainsDataGridView.AllowUserToAddRows = false;
            this.trainsDataGridView.AllowUserToDeleteRows = false;
            this.trainsDataGridView.AllowUserToResizeRows = false;
            this.trainsDataGridView.AutoGenerateColumns = false;
            this.trainsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trainsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trainIDDataGridViewTextBoxColumn,
            this.trainNumDataGridViewTextBoxColumn,
            this.destinationStationIdDataGridViewTextBoxColumn,
            this.arrivalTimeDataGridViewTextBoxColumn,
            this.departureTimeDataGridViewTextBoxColumn,
            this.vagonNumDataGridViewTextBoxColumn});
            this.trainsDataGridView.DataSource = this.trainsBindingSource;
            this.trainsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trainsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.trainsDataGridView.Name = "trainsDataGridView";
            this.trainsDataGridView.ReadOnly = true;
            this.trainsDataGridView.RowHeadersVisible = false;
            this.trainsDataGridView.RowHeadersWidth = 30;
            this.trainsDataGridView.Size = new System.Drawing.Size(510, 250);
            this.trainsDataGridView.TabIndex = 5;
            // 
            // trainIDDataGridViewTextBoxColumn
            // 
            this.trainIDDataGridViewTextBoxColumn.DataPropertyName = "TrainID";
            this.trainIDDataGridViewTextBoxColumn.HeaderText = "TrainID";
            this.trainIDDataGridViewTextBoxColumn.Name = "trainIDDataGridViewTextBoxColumn";
            this.trainIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.trainIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // trainNumDataGridViewTextBoxColumn
            // 
            this.trainNumDataGridViewTextBoxColumn.DataPropertyName = "TrainNum";
            this.trainNumDataGridViewTextBoxColumn.HeaderText = "Номер поезда";
            this.trainNumDataGridViewTextBoxColumn.Name = "trainNumDataGridViewTextBoxColumn";
            this.trainNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.trainNumDataGridViewTextBoxColumn.Width = 80;
            // 
            // destinationStationIdDataGridViewTextBoxColumn
            // 
            this.destinationStationIdDataGridViewTextBoxColumn.DataPropertyName = "DestinationStationId";
            this.destinationStationIdDataGridViewTextBoxColumn.DataSource = this.stationsBindingSource;
            this.destinationStationIdDataGridViewTextBoxColumn.DisplayMember = "StationName";
            this.destinationStationIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.destinationStationIdDataGridViewTextBoxColumn.HeaderText = "Станция назначения";
            this.destinationStationIdDataGridViewTextBoxColumn.Name = "destinationStationIdDataGridViewTextBoxColumn";
            this.destinationStationIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.destinationStationIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.destinationStationIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.destinationStationIdDataGridViewTextBoxColumn.ValueMember = "StationId";
            this.destinationStationIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // stationsBindingSource
            // 
            this.stationsBindingSource.DataMember = "Stations";
            this.stationsBindingSource.DataSource = this.railroadDataSet;
            // 
            // railroadDataSet
            // 
            this.railroadDataSet.DataSetName = "RailroadDataSet";
            this.railroadDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // arrivalTimeDataGridViewTextBoxColumn
            // 
            this.arrivalTimeDataGridViewTextBoxColumn.DataPropertyName = "ArrivalTime";
            this.arrivalTimeDataGridViewTextBoxColumn.HeaderText = "Время прибытия";
            this.arrivalTimeDataGridViewTextBoxColumn.Name = "arrivalTimeDataGridViewTextBoxColumn";
            this.arrivalTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departureTimeDataGridViewTextBoxColumn
            // 
            this.departureTimeDataGridViewTextBoxColumn.DataPropertyName = "DepartureTime";
            this.departureTimeDataGridViewTextBoxColumn.HeaderText = "Время отправления";
            this.departureTimeDataGridViewTextBoxColumn.Name = "departureTimeDataGridViewTextBoxColumn";
            this.departureTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vagonNumDataGridViewTextBoxColumn
            // 
            this.vagonNumDataGridViewTextBoxColumn.DataPropertyName = "VagonNum";
            this.vagonNumDataGridViewTextBoxColumn.HeaderText = "Кол-во вагонов";
            this.vagonNumDataGridViewTextBoxColumn.Name = "vagonNumDataGridViewTextBoxColumn";
            this.vagonNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.vagonNumDataGridViewTextBoxColumn.Width = 60;
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
            this.tableAdapterManager.AuthTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StationsTableAdapter = null;
            this.tableAdapterManager.TrainsTableAdapter = this.trainsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Railroad_Access_.RailroadDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stationsTableAdapter
            // 
            this.stationsTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 303);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Железнодорожный вокзал";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trainsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.railroadDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RailroadDataSet railroadDataSet;
        private RailroadDataSetTableAdapters.TrainsTableAdapter trainsTableAdapter;
        private RailroadDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поездаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView trainsDataGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource trainsBindingSource;
        private System.Windows.Forms.BindingSource stationsBindingSource;
        private RailroadDataSetTableAdapters.StationsTableAdapter stationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn destinationStationIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vagonNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem станцииToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ToolStripMenuItem отчет1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поездаПоСтанцииToolStripMenuItem;
    }
}

