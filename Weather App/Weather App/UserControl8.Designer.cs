namespace Weather_App
{
    partial class UserControl8
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.citynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatureCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatureFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.humidityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pressureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.windspeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyweathertableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.weather_testDataSet = new Weather_App.weather_testDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.dailyweather_tableTableAdapter = new Weather_App.weather_testDataSetTableAdapters.dailyweather_tableTableAdapter();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyweathertableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weather_testDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.BackColor = System.Drawing.Color.Transparent;
            this.panelContainer.Controls.Add(this.dataGridView1);
            this.panelContainer.Controls.Add(this.label1);
            this.panelContainer.Controls.Add(this.iconButton2);
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(709, 389);
            this.panelContainer.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.citynameDataGridViewTextBoxColumn,
            this.temperatureCDataGridViewTextBoxColumn,
            this.temperatureFDataGridViewTextBoxColumn,
            this.humidityDataGridViewTextBoxColumn,
            this.pressureDataGridViewTextBoxColumn,
            this.windspeedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dailyweathertableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(33, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 288);
            this.dataGridView1.TabIndex = 9;
            // 
            // citynameDataGridViewTextBoxColumn
            // 
            this.citynameDataGridViewTextBoxColumn.DataPropertyName = "City_name";
            this.citynameDataGridViewTextBoxColumn.HeaderText = "City_name";
            this.citynameDataGridViewTextBoxColumn.Name = "citynameDataGridViewTextBoxColumn";
            // 
            // temperatureCDataGridViewTextBoxColumn
            // 
            this.temperatureCDataGridViewTextBoxColumn.DataPropertyName = "Temperature_C";
            this.temperatureCDataGridViewTextBoxColumn.HeaderText = "Temperature_C";
            this.temperatureCDataGridViewTextBoxColumn.Name = "temperatureCDataGridViewTextBoxColumn";
            // 
            // temperatureFDataGridViewTextBoxColumn
            // 
            this.temperatureFDataGridViewTextBoxColumn.DataPropertyName = "Temperature_F";
            this.temperatureFDataGridViewTextBoxColumn.HeaderText = "Temperature_F";
            this.temperatureFDataGridViewTextBoxColumn.Name = "temperatureFDataGridViewTextBoxColumn";
            // 
            // humidityDataGridViewTextBoxColumn
            // 
            this.humidityDataGridViewTextBoxColumn.DataPropertyName = "Humidity";
            this.humidityDataGridViewTextBoxColumn.HeaderText = "Humidity";
            this.humidityDataGridViewTextBoxColumn.Name = "humidityDataGridViewTextBoxColumn";
            // 
            // pressureDataGridViewTextBoxColumn
            // 
            this.pressureDataGridViewTextBoxColumn.DataPropertyName = "Pressure";
            this.pressureDataGridViewTextBoxColumn.HeaderText = "Pressure";
            this.pressureDataGridViewTextBoxColumn.Name = "pressureDataGridViewTextBoxColumn";
            // 
            // windspeedDataGridViewTextBoxColumn
            // 
            this.windspeedDataGridViewTextBoxColumn.DataPropertyName = "Wind_speed";
            this.windspeedDataGridViewTextBoxColumn.HeaderText = "Wind_speed";
            this.windspeedDataGridViewTextBoxColumn.Name = "windspeedDataGridViewTextBoxColumn";
            // 
            // dailyweathertableBindingSource
            // 
            this.dailyweathertableBindingSource.DataMember = "dailyweather_table";
            this.dailyweathertableBindingSource.DataSource = this.weather_testDataSet;
            // 
            // weather_testDataSet
            // 
            this.weather_testDataSet.DataSetName = "weather_testDataSet";
            this.weather_testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(257, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Record";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.AutoSize = true;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 36;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 0);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(42, 42);
            this.iconButton2.TabIndex = 7;
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // dailyweather_tableTableAdapter
            // 
            this.dailyweather_tableTableAdapter.ClearBeforeFill = true;
            // 
            // UserControl8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Weather_App.Properties.Resources.Weather_FC_B;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panelContainer);
            this.Name = "UserControl8";
            this.Size = new System.Drawing.Size(709, 389);
            this.Load += new System.EventHandler(this.UserControl8_Load);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyweathertableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weather_testDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn citynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperatureCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperatureFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn humidityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pressureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn windspeedDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dailyweathertableBindingSource;
        private weather_testDataSet weather_testDataSet;
        private System.Windows.Forms.Label label1;
        private weather_testDataSetTableAdapters.dailyweather_tableTableAdapter dailyweather_tableTableAdapter;
    }
}
