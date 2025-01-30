namespace CryptoCoinic.View.WindowsForms
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.highLabel = new System.Windows.Forms.Label();
            this.lowLabel = new System.Windows.Forms.Label();
            this.volLabel = new System.Windows.Forms.Label();
            this.lastLabel = new System.Windows.Forms.Label();
            this.buyLabel = new System.Windows.Forms.Label();
            this.sellLabel = new System.Windows.Forms.Label();
            this.dataBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.dataProgressBar = new System.Windows.Forms.ProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.majorAlertLabel = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.minorAlertLabel = new System.Windows.Forms.Label();
            this.tickerGroupBox = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startScanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alertsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setMinorAlertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerStatusSquare = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.brokerComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.currencyComboBox = new System.Windows.Forms.ComboBox();
            this.setMajorAlertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tickerGroupBox.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // highLabel
            // 
            this.highLabel.AutoSize = true;
            this.highLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.highLabel.Location = new System.Drawing.Point(165, 9);
            this.highLabel.Name = "highLabel";
            this.highLabel.Size = new System.Drawing.Size(32, 20);
            this.highLabel.TabIndex = 0;
            this.highLabel.Text = "R$";
            // 
            // lowLabel
            // 
            this.lowLabel.AutoSize = true;
            this.lowLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lowLabel.Location = new System.Drawing.Point(165, 10);
            this.lowLabel.Name = "lowLabel";
            this.lowLabel.Size = new System.Drawing.Size(32, 20);
            this.lowLabel.TabIndex = 1;
            this.lowLabel.Text = "R$";
            // 
            // volLabel
            // 
            this.volLabel.AutoSize = true;
            this.volLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.volLabel.Location = new System.Drawing.Point(165, 9);
            this.volLabel.Name = "volLabel";
            this.volLabel.Size = new System.Drawing.Size(32, 20);
            this.volLabel.TabIndex = 2;
            this.volLabel.Text = "R$";
            // 
            // lastLabel
            // 
            this.lastLabel.AutoSize = true;
            this.lastLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lastLabel.Location = new System.Drawing.Point(165, 9);
            this.lastLabel.Name = "lastLabel";
            this.lastLabel.Size = new System.Drawing.Size(32, 20);
            this.lastLabel.TabIndex = 3;
            this.lastLabel.Text = "R$";
            // 
            // buyLabel
            // 
            this.buyLabel.AutoSize = true;
            this.buyLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buyLabel.Location = new System.Drawing.Point(165, 11);
            this.buyLabel.Name = "buyLabel";
            this.buyLabel.Size = new System.Drawing.Size(32, 20);
            this.buyLabel.TabIndex = 4;
            this.buyLabel.Text = "R$";
            // 
            // sellLabel
            // 
            this.sellLabel.AutoSize = true;
            this.sellLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.sellLabel.Location = new System.Drawing.Point(165, 9);
            this.sellLabel.Name = "sellLabel";
            this.sellLabel.Size = new System.Drawing.Size(32, 20);
            this.sellLabel.TabIndex = 5;
            this.sellLabel.Text = "R$";
            // 
            // dataBackgroundWorker
            // 
            this.dataBackgroundWorker.WorkerSupportsCancellation = true;
            this.dataBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DataBackgroundWorker_DoWork);
            // 
            // dataProgressBar
            // 
            this.dataProgressBar.Location = new System.Drawing.Point(0, 99);
            this.dataProgressBar.Maximum = 20;
            this.dataProgressBar.Name = "dataProgressBar";
            this.dataProgressBar.Size = new System.Drawing.Size(307, 34);
            this.dataProgressBar.TabIndex = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 139);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(352, 510);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.tickerGroupBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(344, 477);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Data";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel8);
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(4, 354);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 121);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alerts";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LightBlue;
            this.panel8.Controls.Add(this.label10);
            this.panel8.Controls.Add(this.majorAlertLabel);
            this.panel8.Location = new System.Drawing.Point(6, 75);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(325, 37);
            this.panel8.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(3, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Major Alert: ";
            // 
            // majorAlertLabel
            // 
            this.majorAlertLabel.AutoSize = true;
            this.majorAlertLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.majorAlertLabel.Location = new System.Drawing.Point(165, 9);
            this.majorAlertLabel.Name = "majorAlertLabel";
            this.majorAlertLabel.Size = new System.Drawing.Size(16, 20);
            this.majorAlertLabel.TabIndex = 5;
            this.majorAlertLabel.Text = "-";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LightBlue;
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.minorAlertLabel);
            this.panel7.Location = new System.Drawing.Point(6, 32);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(325, 37);
            this.panel7.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(3, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Minor Alert: ";
            // 
            // minorAlertLabel
            // 
            this.minorAlertLabel.AutoSize = true;
            this.minorAlertLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.minorAlertLabel.Location = new System.Drawing.Point(165, 9);
            this.minorAlertLabel.Name = "minorAlertLabel";
            this.minorAlertLabel.Size = new System.Drawing.Size(16, 20);
            this.minorAlertLabel.TabIndex = 5;
            this.minorAlertLabel.Text = "-";
            // 
            // tickerGroupBox
            // 
            this.tickerGroupBox.Controls.Add(this.panel6);
            this.tickerGroupBox.Controls.Add(this.panel5);
            this.tickerGroupBox.Controls.Add(this.panel4);
            this.tickerGroupBox.Controls.Add(this.panel3);
            this.tickerGroupBox.Controls.Add(this.panel2);
            this.tickerGroupBox.Controls.Add(this.panel1);
            this.tickerGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tickerGroupBox.ForeColor = System.Drawing.SystemColors.Window;
            this.tickerGroupBox.Location = new System.Drawing.Point(3, 3);
            this.tickerGroupBox.Name = "tickerGroupBox";
            this.tickerGroupBox.Size = new System.Drawing.Size(338, 344);
            this.tickerGroupBox.TabIndex = 0;
            this.tickerGroupBox.TabStop = false;
            this.tickerGroupBox.Text = "Ticker";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightBlue;
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.sellLabel);
            this.panel6.Location = new System.Drawing.Point(7, 293);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(325, 37);
            this.panel6.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sell: ";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightBlue;
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.buyLabel);
            this.panel5.Location = new System.Drawing.Point(7, 239);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(325, 37);
            this.panel5.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(5, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Buy: ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightBlue;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.volLabel);
            this.panel4.Location = new System.Drawing.Point(7, 185);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(325, 37);
            this.panel4.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(7, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Volume: ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightBlue;
            this.panel3.Controls.Add(this.lowLabel);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(7, 133);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 37);
            this.panel3.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(6, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Lowest: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.highLabel);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(7, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 37);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(5, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Highest: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lastLabel);
            this.panel1.Location = new System.Drawing.Point(7, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 37);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(4, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Last Price: ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 653);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(352, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.alertsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(352, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startScanToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // startScanToolStripMenuItem
            // 
            this.startScanToolStripMenuItem.Name = "startScanToolStripMenuItem";
            this.startScanToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.startScanToolStripMenuItem.Text = "Start Scan";
            this.startScanToolStripMenuItem.Click += new System.EventHandler(this.startScanToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // alertsToolStripMenuItem
            // 
            this.alertsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setMinorAlertToolStripMenuItem,
            this.setMajorAlertToolStripMenuItem});
            this.alertsToolStripMenuItem.Name = "alertsToolStripMenuItem";
            this.alertsToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.alertsToolStripMenuItem.Text = "Alerts";
            // 
            // setMinorAlertToolStripMenuItem
            // 
            this.setMinorAlertToolStripMenuItem.Name = "setMinorAlertToolStripMenuItem";
            this.setMinorAlertToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.setMinorAlertToolStripMenuItem.Text = "Set Minor Alert";
            this.setMinorAlertToolStripMenuItem.Click += new System.EventHandler(this.setMinorAlertToolStripMenuItem_Click);
            // 
            // timerStatusSquare
            // 
            this.timerStatusSquare.BackColor = System.Drawing.Color.Red;
            this.timerStatusSquare.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.timerStatusSquare.Location = new System.Drawing.Point(313, 99);
            this.timerStatusSquare.Name = "timerStatusSquare";
            this.timerStatusSquare.Size = new System.Drawing.Size(35, 34);
            this.timerStatusSquare.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.brokerComboBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(4, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 61);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Broker";
            // 
            // brokerComboBox
            // 
            this.brokerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brokerComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brokerComboBox.FormattingEnabled = true;
            this.brokerComboBox.Items.AddRange(new object[] {
            "MercadoBitcoin"});
            this.brokerComboBox.Location = new System.Drawing.Point(6, 25);
            this.brokerComboBox.Name = "brokerComboBox";
            this.brokerComboBox.Size = new System.Drawing.Size(201, 28);
            this.brokerComboBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.currencyComboBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(223, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(125, 61);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Currency";
            // 
            // currencyComboBox
            // 
            this.currencyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currencyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyComboBox.FormattingEnabled = true;
            this.currencyComboBox.Items.AddRange(new object[] {
            "BTC",
            "LTC",
            "BCH"});
            this.currencyComboBox.Location = new System.Drawing.Point(6, 26);
            this.currencyComboBox.Name = "currencyComboBox";
            this.currencyComboBox.Size = new System.Drawing.Size(113, 28);
            this.currencyComboBox.TabIndex = 1;
            // 
            // setMajorAlertToolStripMenuItem
            // 
            this.setMajorAlertToolStripMenuItem.Name = "setMajorAlertToolStripMenuItem";
            this.setMajorAlertToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.setMajorAlertToolStripMenuItem.Text = "Set Major Alert";
            this.setMajorAlertToolStripMenuItem.Click += new System.EventHandler(this.setMajorAlertToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(352, 675);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.timerStatusSquare);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CryptoCoinic 1.0";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.tickerGroupBox.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label highLabel;
        private System.Windows.Forms.Label lowLabel;
        private System.Windows.Forms.Label volLabel;
        private System.Windows.Forms.Label lastLabel;
        private System.Windows.Forms.Label buyLabel;
        private System.Windows.Forms.Label sellLabel;
        private System.ComponentModel.BackgroundWorker dataBackgroundWorker;
        private System.Windows.Forms.ProgressBar dataProgressBar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox tickerGroupBox;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label majorAlertLabel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label minorAlertLabel;
        private System.Windows.Forms.ToolStripMenuItem alertsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setMinorAlertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startScanToolStripMenuItem;
        private System.Windows.Forms.Panel timerStatusSquare;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox brokerComboBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox currencyComboBox;
        private System.Windows.Forms.ToolStripMenuItem setMajorAlertToolStripMenuItem;
    }
}

