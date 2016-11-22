namespace StockLoader {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dow30ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nazdaq100ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelFolderPath = new System.Windows.Forms.Label();
            this.textSaveBox = new System.Windows.Forms.TextBox();
            this.buttonChooseSavePath = new System.Windows.Forms.Button();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.comboBoxFromMonth = new System.Windows.Forms.ComboBox();
            this.numericUpDownFromDay = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFromYear = new System.Windows.Forms.NumericUpDown();
            this.comboBoxToMonth = new System.Windows.Forms.ComboBox();
            this.numericUpDownToDay = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownToYear = new System.Windows.Forms.NumericUpDown();
            this.radioButtonDaily = new System.Windows.Forms.RadioButton();
            this.radioButtonWeekly = new System.Windows.Forms.RadioButton();
            this.radioButtonMonthly = new System.Windows.Forms.RadioButton();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.textTicker = new System.Windows.Forms.TextBox();
            this.labelTickers = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFromDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFromYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownToDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownToYear)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(519, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dlToolStripMenuItem
            // 
            this.dlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dow30ToolStripMenuItem,
            this.spToolStripMenuItem,
            this.nazdaq100ToolStripMenuItem});
            this.dlToolStripMenuItem.Name = "dlToolStripMenuItem";
            this.dlToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.dlToolStripMenuItem.Text = "Index Components";
            this.dlToolStripMenuItem.Click += new System.EventHandler(this.indexComponeToolStripMenuItem_Click);
            // 
            // dow30ToolStripMenuItem
            // 
            this.dow30ToolStripMenuItem.Name = "dow30ToolStripMenuItem";
            this.dow30ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.dow30ToolStripMenuItem.Text = "Dow 30";
            this.dow30ToolStripMenuItem.Click += new System.EventHandler(this.dow30ToolStripMenuItem_Click);
            // 
            // spToolStripMenuItem
            // 
            this.spToolStripMenuItem.Name = "spToolStripMenuItem";
            this.spToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.spToolStripMenuItem.Text = "S&&P 100";
            this.spToolStripMenuItem.Click += new System.EventHandler(this.spToolStripMenuItem_Click);
            // 
            // nazdaq100ToolStripMenuItem
            // 
            this.nazdaq100ToolStripMenuItem.Name = "nazdaq100ToolStripMenuItem";
            this.nazdaq100ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.nazdaq100ToolStripMenuItem.Text = "Nazdaq 100";
            this.nazdaq100ToolStripMenuItem.Click += new System.EventHandler(this.nazdaq100ToolStripMenuItem_Click);
            // 
            // labelFolderPath
            // 
            this.labelFolderPath.AutoSize = true;
            this.labelFolderPath.Location = new System.Drawing.Point(23, 35);
            this.labelFolderPath.Name = "labelFolderPath";
            this.labelFolderPath.Size = new System.Drawing.Size(66, 13);
            this.labelFolderPath.TabIndex = 1;
            this.labelFolderPath.Text = "Save File to:";
            this.labelFolderPath.Click += new System.EventHandler(this.labelFolderPath_Click);
            // 
            // textSaveBox
            // 
            this.textSaveBox.Location = new System.Drawing.Point(93, 31);
            this.textSaveBox.Name = "textSaveBox";
            this.textSaveBox.Size = new System.Drawing.Size(300, 20);
            this.textSaveBox.TabIndex = 2;
            // 
            // buttonChooseSavePath
            // 
            this.buttonChooseSavePath.Location = new System.Drawing.Point(415, 30);
            this.buttonChooseSavePath.Name = "buttonChooseSavePath";
            this.buttonChooseSavePath.Size = new System.Drawing.Size(75, 23);
            this.buttonChooseSavePath.TabIndex = 3;
            this.buttonChooseSavePath.Text = "Choose";
            this.buttonChooseSavePath.UseVisualStyleBackColor = true;
            this.buttonChooseSavePath.Click += new System.EventHandler(this.buttonChooseSavePath_Click);
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(31, 75);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(58, 13);
            this.labelStartDate.TabIndex = 4;
            this.labelStartDate.Text = "Start Date:";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(34, 118);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(55, 13);
            this.labelEndDate.TabIndex = 5;
            this.labelEndDate.Text = "End Date:";
            // 
            // comboBoxFromMonth
            // 
            this.comboBoxFromMonth.FormattingEnabled = true;
            this.comboBoxFromMonth.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.comboBoxFromMonth.Location = new System.Drawing.Point(93, 71);
            this.comboBoxFromMonth.Name = "comboBoxFromMonth";
            this.comboBoxFromMonth.Size = new System.Drawing.Size(50, 21);
            this.comboBoxFromMonth.TabIndex = 6;
            this.comboBoxFromMonth.Text = "Jan";
            this.comboBoxFromMonth.SelectedIndexChanged += new System.EventHandler(this.comboBoxFromMonth_SelectedIndexChanged);
            // 
            // numericUpDownFromDay
            // 
            this.numericUpDownFromDay.Location = new System.Drawing.Point(167, 71);
            this.numericUpDownFromDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDownFromDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFromDay.Name = "numericUpDownFromDay";
            this.numericUpDownFromDay.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownFromDay.TabIndex = 7;
            this.numericUpDownFromDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownFromYear
            // 
            this.numericUpDownFromYear.Location = new System.Drawing.Point(251, 71);
            this.numericUpDownFromYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numericUpDownFromYear.Minimum = new decimal(new int[] {
            1930,
            0,
            0,
            0});
            this.numericUpDownFromYear.Name = "numericUpDownFromYear";
            this.numericUpDownFromYear.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownFromYear.TabIndex = 8;
            this.numericUpDownFromYear.Value = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            this.numericUpDownFromYear.ValueChanged += new System.EventHandler(this.numericUpDownFromYear_ValueChanged);
            // 
            // comboBoxToMonth
            // 
            this.comboBoxToMonth.FormattingEnabled = true;
            this.comboBoxToMonth.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.comboBoxToMonth.Location = new System.Drawing.Point(93, 114);
            this.comboBoxToMonth.Name = "comboBoxToMonth";
            this.comboBoxToMonth.Size = new System.Drawing.Size(50, 21);
            this.comboBoxToMonth.TabIndex = 9;
            this.comboBoxToMonth.Text = "Jan";
            // 
            // numericUpDownToDay
            // 
            this.numericUpDownToDay.Location = new System.Drawing.Point(167, 114);
            this.numericUpDownToDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDownToDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownToDay.Name = "numericUpDownToDay";
            this.numericUpDownToDay.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownToDay.TabIndex = 10;
            this.numericUpDownToDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownToYear
            // 
            this.numericUpDownToYear.Location = new System.Drawing.Point(251, 114);
            this.numericUpDownToYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numericUpDownToYear.Minimum = new decimal(new int[] {
            1930,
            0,
            0,
            0});
            this.numericUpDownToYear.Name = "numericUpDownToYear";
            this.numericUpDownToYear.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownToYear.TabIndex = 11;
            this.numericUpDownToYear.Value = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            this.numericUpDownToYear.ValueChanged += new System.EventHandler(this.numericUpDownToYear_ValueChanged);
            // 
            // radioButtonDaily
            // 
            this.radioButtonDaily.AutoSize = true;
            this.radioButtonDaily.Checked = true;
            this.radioButtonDaily.Location = new System.Drawing.Point(332, 71);
            this.radioButtonDaily.Name = "radioButtonDaily";
            this.radioButtonDaily.Size = new System.Drawing.Size(48, 17);
            this.radioButtonDaily.TabIndex = 12;
            this.radioButtonDaily.TabStop = true;
            this.radioButtonDaily.Text = "Daily";
            this.radioButtonDaily.UseVisualStyleBackColor = true;
            this.radioButtonDaily.CheckedChanged += new System.EventHandler(this.radioButtonDaily_CheckedChanged);
            // 
            // radioButtonWeekly
            // 
            this.radioButtonWeekly.AutoSize = true;
            this.radioButtonWeekly.Location = new System.Drawing.Point(332, 94);
            this.radioButtonWeekly.Name = "radioButtonWeekly";
            this.radioButtonWeekly.Size = new System.Drawing.Size(61, 17);
            this.radioButtonWeekly.TabIndex = 13;
            this.radioButtonWeekly.TabStop = true;
            this.radioButtonWeekly.Text = "Weekly";
            this.radioButtonWeekly.UseVisualStyleBackColor = true;
            // 
            // radioButtonMonthly
            // 
            this.radioButtonMonthly.AutoSize = true;
            this.radioButtonMonthly.Location = new System.Drawing.Point(331, 117);
            this.radioButtonMonthly.Name = "radioButtonMonthly";
            this.radioButtonMonthly.Size = new System.Drawing.Size(62, 17);
            this.radioButtonMonthly.TabIndex = 14;
            this.radioButtonMonthly.TabStop = true;
            this.radioButtonMonthly.Text = "Monthly";
            this.radioButtonMonthly.UseVisualStyleBackColor = true;
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(415, 75);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(75, 23);
            this.buttonDownload.TabIndex = 15;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // textTicker
            // 
            this.textTicker.Location = new System.Drawing.Point(93, 163);
            this.textTicker.Multiline = true;
            this.textTicker.Name = "textTicker";
            this.textTicker.Size = new System.Drawing.Size(300, 86);
            this.textTicker.TabIndex = 16;
            this.textTicker.Text = "GOOG,AAPL,AMZN";
            // 
            // labelTickers
            // 
            this.labelTickers.AutoSize = true;
            this.labelTickers.Location = new System.Drawing.Point(5, 163);
            this.labelTickers.Name = "labelTickers";
            this.labelTickers.Size = new System.Drawing.Size(82, 13);
            this.labelTickers.TabIndex = 17;
            this.labelTickers.Text = "Ticker Symbols:";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 261);
            this.Controls.Add(this.labelTickers);
            this.Controls.Add(this.textTicker);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.radioButtonMonthly);
            this.Controls.Add(this.radioButtonWeekly);
            this.Controls.Add(this.radioButtonDaily);
            this.Controls.Add(this.numericUpDownToYear);
            this.Controls.Add(this.numericUpDownToDay);
            this.Controls.Add(this.comboBoxToMonth);
            this.Controls.Add(this.numericUpDownFromYear);
            this.Controls.Add(this.numericUpDownFromDay);
            this.Controls.Add(this.comboBoxFromMonth);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.buttonChooseSavePath);
            this.Controls.Add(this.textSaveBox);
            this.Controls.Add(this.labelFolderPath);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Stock Downloader";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFromDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFromYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownToDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownToYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dow30ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nazdaq100ToolStripMenuItem;
        private System.Windows.Forms.Label labelFolderPath;
        private System.Windows.Forms.TextBox textSaveBox;
        private System.Windows.Forms.Button buttonChooseSavePath;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.ComboBox comboBoxFromMonth;
        private System.Windows.Forms.NumericUpDown numericUpDownFromDay;
        private System.Windows.Forms.NumericUpDown numericUpDownFromYear;
        private System.Windows.Forms.ComboBox comboBoxToMonth;
        private System.Windows.Forms.NumericUpDown numericUpDownToDay;
        private System.Windows.Forms.NumericUpDown numericUpDownToYear;
        private System.Windows.Forms.RadioButton radioButtonDaily;
        private System.Windows.Forms.RadioButton radioButtonWeekly;
        private System.Windows.Forms.RadioButton radioButtonMonthly;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.TextBox textTicker;
        private System.Windows.Forms.Label labelTickers;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

