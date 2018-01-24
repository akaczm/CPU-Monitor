namespace CPU_Monitor
{
    partial class sensorList2
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sensorList2));
            this.portlabel = new System.Windows.Forms.Label();
            this.comPort = new System.Windows.Forms.ComboBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.intervalBox = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.setIntervalBtn = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.sensorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hardwareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.computerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hardwareList = new System.Windows.Forms.ListBox();
            this.hardwareBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hardwareBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sensorGridView = new System.Windows.Forms.DataGridView();
            this.indexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sensorTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setSensor1Btn = new System.Windows.Forms.Button();
            this.setSensor2Btn = new System.Windows.Forms.Button();
            this.selSensor1Label = new System.Windows.Forms.Label();
            this.selSensor2Label = new System.Windows.Forms.Label();
            this.auraValueM = new System.Windows.Forms.CheckBox();
            this.auraValueMLabel = new System.Windows.Forms.Label();
            this.openColorPicker = new System.Windows.Forms.Button();
            this.GPULedModeGroup = new System.Windows.Forms.GroupBox();
            this.GPULedModeTemp = new System.Windows.Forms.RadioButton();
            this.GPULedModeCycle = new System.Windows.Forms.RadioButton();
            this.GPULedModeStatic = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.sensorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwareBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwareBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorGridView)).BeginInit();
            this.GPULedModeGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // portlabel
            // 
            this.portlabel.AutoSize = true;
            this.portlabel.Location = new System.Drawing.Point(13, 13);
            this.portlabel.Name = "portlabel";
            this.portlabel.Size = new System.Drawing.Size(29, 13);
            this.portlabel.TabIndex = 0;
            this.portlabel.Text = "Port:";
            // 
            // comPort
            // 
            this.comPort.FormattingEnabled = true;
            this.comPort.Location = new System.Drawing.Point(16, 30);
            this.comPort.Name = "comPort";
            this.comPort.Size = new System.Drawing.Size(121, 21);
            this.comPort.TabIndex = 1;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(144, 30);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 20);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Location = new System.Drawing.Point(16, 70);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(67, 13);
            this.intervalLabel.TabIndex = 4;
            this.intervalLabel.Text = "Interval (ms):";
            // 
            // intervalBox
            // 
            this.intervalBox.FormattingEnabled = true;
            this.intervalBox.Location = new System.Drawing.Point(19, 87);
            this.intervalBox.Name = "intervalBox";
            this.intervalBox.Size = new System.Drawing.Size(118, 21);
            this.intervalBox.TabIndex = 5;
            this.intervalBox.Text = "2000";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // setIntervalBtn
            // 
            this.setIntervalBtn.Location = new System.Drawing.Point(144, 87);
            this.setIntervalBtn.Name = "setIntervalBtn";
            this.setIntervalBtn.Size = new System.Drawing.Size(75, 21);
            this.setIntervalBtn.TabIndex = 6;
            this.setIntervalBtn.Text = "Set";
            this.setIntervalBtn.UseVisualStyleBackColor = true;
            this.setIntervalBtn.Click += new System.EventHandler(this.setIntervalBtn_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Running in background";
            this.notifyIcon1.BalloonTipTitle = "Ardu-Temp";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // sensorsBindingSource
            // 
            this.sensorsBindingSource.DataMember = "Sensors";
            this.sensorsBindingSource.DataSource = this.hardwareBindingSource;
            // 
            // hardwareBindingSource
            // 
            this.hardwareBindingSource.DataMember = "Hardware";
            this.hardwareBindingSource.DataSource = this.computerBindingSource;
            // 
            // computerBindingSource
            // 
            this.computerBindingSource.DataSource = typeof(OpenHardwareMonitor.Hardware.Computer);
            // 
            // hardwareList
            // 
            this.hardwareList.FormattingEnabled = true;
            this.hardwareList.Location = new System.Drawing.Point(19, 160);
            this.hardwareList.Name = "hardwareList";
            this.hardwareList.Size = new System.Drawing.Size(200, 69);
            this.hardwareList.TabIndex = 7;
            this.hardwareList.SelectedIndexChanged += new System.EventHandler(this.hardwareList_SelectedIndexChanged);
            // 
            // hardwareBindingSource1
            // 
            this.hardwareBindingSource1.DataMember = "Hardware";
            this.hardwareBindingSource1.DataSource = this.computerBindingSource;
            // 
            // hardwareBindingSource2
            // 
            this.hardwareBindingSource2.DataMember = "Hardware";
            this.hardwareBindingSource2.DataSource = this.computerBindingSource;
            // 
            // sensorGridView
            // 
            this.sensorGridView.AllowUserToAddRows = false;
            this.sensorGridView.AllowUserToDeleteRows = false;
            this.sensorGridView.AllowUserToResizeColumns = false;
            this.sensorGridView.AllowUserToResizeRows = false;
            this.sensorGridView.AutoGenerateColumns = false;
            this.sensorGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.sensorGridView.BackgroundColor = System.Drawing.Color.White;
            this.sensorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sensorGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indexDataGridViewTextBoxColumn,
            this.sensorTypeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.sensorGridView.DataSource = this.sensorsBindingSource;
            this.sensorGridView.Location = new System.Drawing.Point(225, 160);
            this.sensorGridView.Name = "sensorGridView";
            this.sensorGridView.ReadOnly = true;
            this.sensorGridView.RowHeadersVisible = false;
            this.sensorGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sensorGridView.Size = new System.Drawing.Size(266, 143);
            this.sensorGridView.TabIndex = 9;
            // 
            // indexDataGridViewTextBoxColumn
            // 
            this.indexDataGridViewTextBoxColumn.DataPropertyName = "Index";
            this.indexDataGridViewTextBoxColumn.HeaderText = "Index";
            this.indexDataGridViewTextBoxColumn.Name = "indexDataGridViewTextBoxColumn";
            this.indexDataGridViewTextBoxColumn.ReadOnly = true;
            this.indexDataGridViewTextBoxColumn.Width = 5;
            // 
            // sensorTypeDataGridViewTextBoxColumn
            // 
            this.sensorTypeDataGridViewTextBoxColumn.DataPropertyName = "SensorType";
            this.sensorTypeDataGridViewTextBoxColumn.HeaderText = "SensorType";
            this.sensorTypeDataGridViewTextBoxColumn.Name = "sensorTypeDataGridViewTextBoxColumn";
            this.sensorTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.sensorTypeDataGridViewTextBoxColumn.Width = 5;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 5;
            // 
            // setSensor1Btn
            // 
            this.setSensor1Btn.Location = new System.Drawing.Point(225, 310);
            this.setSensor1Btn.Name = "setSensor1Btn";
            this.setSensor1Btn.Size = new System.Drawing.Size(100, 23);
            this.setSensor1Btn.TabIndex = 10;
            this.setSensor1Btn.Text = "Set value 1";
            this.setSensor1Btn.UseVisualStyleBackColor = true;
            this.setSensor1Btn.Click += new System.EventHandler(this.setSensor1Btn_Click);
            // 
            // setSensor2Btn
            // 
            this.setSensor2Btn.Location = new System.Drawing.Point(375, 310);
            this.setSensor2Btn.Name = "setSensor2Btn";
            this.setSensor2Btn.Size = new System.Drawing.Size(100, 23);
            this.setSensor2Btn.TabIndex = 11;
            this.setSensor2Btn.Text = "Set value 2";
            this.setSensor2Btn.UseVisualStyleBackColor = true;
            this.setSensor2Btn.Click += new System.EventHandler(this.setSensor2Btn_Click);
            // 
            // selSensor1Label
            // 
            this.selSensor1Label.AutoSize = true;
            this.selSensor1Label.Location = new System.Drawing.Point(19, 236);
            this.selSensor1Label.Name = "selSensor1Label";
            this.selSensor1Label.Size = new System.Drawing.Size(33, 13);
            this.selSensor1Label.TabIndex = 12;
            this.selSensor1Label.Text = "None";
            // 
            // selSensor2Label
            // 
            this.selSensor2Label.AutoSize = true;
            this.selSensor2Label.Location = new System.Drawing.Point(19, 253);
            this.selSensor2Label.Name = "selSensor2Label";
            this.selSensor2Label.Size = new System.Drawing.Size(33, 13);
            this.selSensor2Label.TabIndex = 13;
            this.selSensor2Label.Text = "None";
            // 
            // auraValueM
            // 
            this.auraValueM.AutoSize = true;
            this.auraValueM.Checked = true;
            this.auraValueM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.auraValueM.Location = new System.Drawing.Point(415, 34);
            this.auraValueM.Name = "auraValueM";
            this.auraValueM.Size = new System.Drawing.Size(15, 14);
            this.auraValueM.TabIndex = 24;
            this.auraValueM.UseVisualStyleBackColor = true;
            this.auraValueM.CheckedChanged += new System.EventHandler(this.auraValueM_CheckedChanged);
            // 
            // auraValueMLabel
            // 
            this.auraValueMLabel.AutoSize = true;
            this.auraValueMLabel.Location = new System.Drawing.Point(412, 14);
            this.auraValueMLabel.Name = "auraValueMLabel";
            this.auraValueMLabel.Size = new System.Drawing.Size(33, 13);
            this.auraValueMLabel.TabIndex = 25;
            this.auraValueMLabel.Text = "Pulse";
            // 
            // openColorPicker
            // 
            this.openColorPicker.Location = new System.Drawing.Point(267, 30);
            this.openColorPicker.Name = "openColorPicker";
            this.openColorPicker.Size = new System.Drawing.Size(111, 23);
            this.openColorPicker.TabIndex = 26;
            this.openColorPicker.Text = "GPU LED Color";
            this.openColorPicker.UseVisualStyleBackColor = true;
            this.openColorPicker.Click += new System.EventHandler(this.openColorPicker_Click);
            // 
            // GPULedModeGroup
            // 
            this.GPULedModeGroup.Controls.Add(this.GPULedModeTemp);
            this.GPULedModeGroup.Controls.Add(this.GPULedModeCycle);
            this.GPULedModeGroup.Controls.Add(this.GPULedModeStatic);
            this.GPULedModeGroup.Location = new System.Drawing.Point(267, 59);
            this.GPULedModeGroup.Name = "GPULedModeGroup";
            this.GPULedModeGroup.Size = new System.Drawing.Size(178, 82);
            this.GPULedModeGroup.TabIndex = 27;
            this.GPULedModeGroup.TabStop = false;
            // 
            // GPULedModeTemp
            // 
            this.GPULedModeTemp.AutoSize = true;
            this.GPULedModeTemp.Location = new System.Drawing.Point(6, 59);
            this.GPULedModeTemp.Name = "GPULedModeTemp";
            this.GPULedModeTemp.Size = new System.Drawing.Size(85, 17);
            this.GPULedModeTemp.TabIndex = 2;
            this.GPULedModeTemp.Text = "Temperature";
            this.GPULedModeTemp.UseVisualStyleBackColor = true;
            // 
            // GPULedModeCycle
            // 
            this.GPULedModeCycle.AutoSize = true;
            this.GPULedModeCycle.Location = new System.Drawing.Point(6, 35);
            this.GPULedModeCycle.Name = "GPULedModeCycle";
            this.GPULedModeCycle.Size = new System.Drawing.Size(51, 17);
            this.GPULedModeCycle.TabIndex = 1;
            this.GPULedModeCycle.Text = "Cycle";
            this.GPULedModeCycle.UseVisualStyleBackColor = true;
            this.GPULedModeCycle.CheckedChanged += new System.EventHandler(this.GPULedModeCycle_CheckedChanged);
            // 
            // GPULedModeStatic
            // 
            this.GPULedModeStatic.AutoSize = true;
            this.GPULedModeStatic.Checked = true;
            this.GPULedModeStatic.Location = new System.Drawing.Point(6, 12);
            this.GPULedModeStatic.Name = "GPULedModeStatic";
            this.GPULedModeStatic.Size = new System.Drawing.Size(52, 17);
            this.GPULedModeStatic.TabIndex = 0;
            this.GPULedModeStatic.TabStop = true;
            this.GPULedModeStatic.Text = "Static";
            this.GPULedModeStatic.UseVisualStyleBackColor = true;
            this.GPULedModeStatic.CheckedChanged += new System.EventHandler(this.GPULedModeStatic_CheckedChanged);
            // 
            // sensorList2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 425);
            this.Controls.Add(this.GPULedModeGroup);
            this.Controls.Add(this.openColorPicker);
            this.Controls.Add(this.auraValueMLabel);
            this.Controls.Add(this.auraValueM);
            this.Controls.Add(this.selSensor2Label);
            this.Controls.Add(this.selSensor1Label);
            this.Controls.Add(this.setSensor2Btn);
            this.Controls.Add(this.setSensor1Btn);
            this.Controls.Add(this.sensorGridView);
            this.Controls.Add(this.hardwareList);
            this.Controls.Add(this.setIntervalBtn);
            this.Controls.Add(this.intervalBox);
            this.Controls.Add(this.intervalLabel);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.comPort);
            this.Controls.Add(this.portlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "sensorList2";
            this.Text = "Ardu-Temp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sensorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwareBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwareBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorGridView)).EndInit();
            this.GPULedModeGroup.ResumeLayout(false);
            this.GPULedModeGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label portlabel;
        private System.Windows.Forms.ComboBox comPort;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.ComboBox intervalBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button setIntervalBtn;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.BindingSource hardwareBindingSource;
        private System.Windows.Forms.BindingSource computerBindingSource;
        private System.Windows.Forms.BindingSource sensorsBindingSource;
        private System.Windows.Forms.ListBox hardwareList;
        private System.Windows.Forms.BindingSource hardwareBindingSource2;
        private System.Windows.Forms.BindingSource hardwareBindingSource1;
        private System.Windows.Forms.DataGridView sensorGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sensorTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button setSensor1Btn;
        private System.Windows.Forms.Button setSensor2Btn;
        private System.Windows.Forms.Label selSensor1Label;
        private System.Windows.Forms.Label selSensor2Label;
        private System.Windows.Forms.CheckBox auraValueM;
        private System.Windows.Forms.Label auraValueMLabel;
        private System.Windows.Forms.Button openColorPicker;
        private System.Windows.Forms.GroupBox GPULedModeGroup;
        private System.Windows.Forms.RadioButton GPULedModeTemp;
        private System.Windows.Forms.RadioButton GPULedModeCycle;
        private System.Windows.Forms.RadioButton GPULedModeStatic;
    }
}

