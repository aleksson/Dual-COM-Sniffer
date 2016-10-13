namespace uartSniffer
{
    partial class Form1
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
            System.Windows.Forms.Label baudRateLabel;
            System.Windows.Forms.Label dataBitsLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1_BaudRate1 = new System.Windows.Forms.ComboBox();
            this.comboBox1_DataBits1 = new System.Windows.Forms.ComboBox();
            this.comboBox1_port1 = new System.Windows.Forms.ComboBox();
            this.comboBox2_BaudRate2 = new System.Windows.Forms.ComboBox();
            this.comboBox2_DataBits2 = new System.Windows.Forms.ComboBox();
            this.comboBox2_port2 = new System.Windows.Forms.ComboBox();
            this.knapp_hamtaPortar = new System.Windows.Forms.Button();
            this.knapp_portLyssnare = new System.Windows.Forms.Button();
            this.textbox_output = new System.Windows.Forms.RichTextBox();
            this.knapp_rensaBox1 = new System.Windows.Forms.Button();
            this.textbox2_output2 = new System.Windows.Forms.RichTextBox();
            this.progressBar_2 = new System.Windows.Forms.ProgressBar();
            this.knapp_reset = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.omToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inEvolutionToQ2DSolution2016ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.knapp_rensaBox2 = new System.Windows.Forms.Button();
            this.progressBar_1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox_pause2 = new System.Windows.Forms.CheckBox();
            this.checkBox_pause1 = new System.Windows.Forms.CheckBox();
            baudRateLabel = new System.Windows.Forms.Label();
            dataBitsLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // baudRateLabel
            // 
            baudRateLabel.AutoSize = true;
            baudRateLabel.Location = new System.Drawing.Point(16, 65);
            baudRateLabel.Name = "baudRateLabel";
            baudRateLabel.Size = new System.Drawing.Size(61, 13);
            baudRateLabel.TabIndex = 17;
            baudRateLabel.Text = "Baud Rate:";
            // 
            // dataBitsLabel
            // 
            dataBitsLabel.AutoSize = true;
            dataBitsLabel.Location = new System.Drawing.Point(24, 96);
            dataBitsLabel.Name = "dataBitsLabel";
            dataBitsLabel.Size = new System.Drawing.Size(53, 13);
            dataBitsLabel.TabIndex = 20;
            dataBitsLabel.Text = "Data Bits:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(181, 65);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(61, 13);
            label1.TabIndex = 23;
            label1.Text = "Baud Rate:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(181, 96);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(53, 13);
            label2.TabIndex = 26;
            label2.Text = "Data Bits:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(181, 34);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(60, 13);
            label3.TabIndex = 28;
            label3.Text = "Serial COM";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(17, 34);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(60, 13);
            label4.TabIndex = 29;
            label4.Text = "Serial COM";
            // 
            // comboBox1_BaudRate1
            // 
            this.comboBox1_BaudRate1.FormattingEnabled = true;
            this.comboBox1_BaudRate1.Location = new System.Drawing.Point(89, 62);
            this.comboBox1_BaudRate1.Name = "comboBox1_BaudRate1";
            this.comboBox1_BaudRate1.Size = new System.Drawing.Size(108, 21);
            this.comboBox1_BaudRate1.TabIndex = 18;
            // 
            // comboBox1_DataBits1
            // 
            this.comboBox1_DataBits1.FormattingEnabled = true;
            this.comboBox1_DataBits1.Location = new System.Drawing.Point(89, 93);
            this.comboBox1_DataBits1.Name = "comboBox1_DataBits1";
            this.comboBox1_DataBits1.Size = new System.Drawing.Size(108, 21);
            this.comboBox1_DataBits1.TabIndex = 21;
            // 
            // comboBox1_port1
            // 
            this.comboBox1_port1.FormattingEnabled = true;
            this.comboBox1_port1.Location = new System.Drawing.Point(89, 28);
            this.comboBox1_port1.Name = "comboBox1_port1";
            this.comboBox1_port1.Size = new System.Drawing.Size(108, 21);
            this.comboBox1_port1.TabIndex = 19;
            // 
            // comboBox2_BaudRate2
            // 
            this.comboBox2_BaudRate2.FormattingEnabled = true;
            this.comboBox2_BaudRate2.Location = new System.Drawing.Point(64, 65);
            this.comboBox2_BaudRate2.Name = "comboBox2_BaudRate2";
            this.comboBox2_BaudRate2.Size = new System.Drawing.Size(108, 21);
            this.comboBox2_BaudRate2.TabIndex = 24;
            // 
            // comboBox2_DataBits2
            // 
            this.comboBox2_DataBits2.FormattingEnabled = true;
            this.comboBox2_DataBits2.Location = new System.Drawing.Point(64, 96);
            this.comboBox2_DataBits2.Name = "comboBox2_DataBits2";
            this.comboBox2_DataBits2.Size = new System.Drawing.Size(108, 21);
            this.comboBox2_DataBits2.TabIndex = 27;
            // 
            // comboBox2_port2
            // 
            this.comboBox2_port2.FormattingEnabled = true;
            this.comboBox2_port2.Location = new System.Drawing.Point(64, 31);
            this.comboBox2_port2.Name = "comboBox2_port2";
            this.comboBox2_port2.Size = new System.Drawing.Size(108, 21);
            this.comboBox2_port2.TabIndex = 25;
            // 
            // knapp_hamtaPortar
            // 
            this.knapp_hamtaPortar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.knapp_hamtaPortar.Location = new System.Drawing.Point(332, 12);
            this.knapp_hamtaPortar.Name = "knapp_hamtaPortar";
            this.knapp_hamtaPortar.Size = new System.Drawing.Size(129, 23);
            this.knapp_hamtaPortar.TabIndex = 30;
            this.knapp_hamtaPortar.Text = "Hämta Port Settings";
            this.knapp_hamtaPortar.UseVisualStyleBackColor = true;
            this.knapp_hamtaPortar.Click += new System.EventHandler(this.knapp_hamtaPortar_Click);
            // 
            // knapp_portLyssnare
            // 
            this.knapp_portLyssnare.ForeColor = System.Drawing.Color.Red;
            this.knapp_portLyssnare.Location = new System.Drawing.Point(345, 47);
            this.knapp_portLyssnare.Name = "knapp_portLyssnare";
            this.knapp_portLyssnare.Size = new System.Drawing.Size(103, 50);
            this.knapp_portLyssnare.TabIndex = 31;
            this.knapp_portLyssnare.Text = "Feed Stängd";
            this.knapp_portLyssnare.UseVisualStyleBackColor = true;
            this.knapp_portLyssnare.Click += new System.EventHandler(this.knapp_portLyssnare_Click);
            // 
            // textbox_output
            // 
            this.textbox_output.BackColor = System.Drawing.SystemColors.InfoText;
            this.textbox_output.ForeColor = System.Drawing.SystemColors.Menu;
            this.textbox_output.Location = new System.Drawing.Point(12, 194);
            this.textbox_output.Name = "textbox_output";
            this.textbox_output.ReadOnly = true;
            this.textbox_output.Size = new System.Drawing.Size(308, 430);
            this.textbox_output.TabIndex = 32;
            this.textbox_output.Text = "";
            this.textbox_output.TextChanged += new System.EventHandler(this.textbox_output_TextChanged);
            // 
            // knapp_rensaBox1
            // 
            this.knapp_rensaBox1.Location = new System.Drawing.Point(326, 196);
            this.knapp_rensaBox1.Name = "knapp_rensaBox1";
            this.knapp_rensaBox1.Size = new System.Drawing.Size(29, 23);
            this.knapp_rensaBox1.TabIndex = 33;
            this.knapp_rensaBox1.Text = "C";
            this.knapp_rensaBox1.UseVisualStyleBackColor = true;
            this.knapp_rensaBox1.Click += new System.EventHandler(this.knapp_rensaBox1_Click);
            // 
            // textbox2_output2
            // 
            this.textbox2_output2.BackColor = System.Drawing.SystemColors.InfoText;
            this.textbox2_output2.ForeColor = System.Drawing.SystemColors.Menu;
            this.textbox2_output2.Location = new System.Drawing.Point(452, 196);
            this.textbox2_output2.Name = "textbox2_output2";
            this.textbox2_output2.ReadOnly = true;
            this.textbox2_output2.Size = new System.Drawing.Size(308, 430);
            this.textbox2_output2.TabIndex = 34;
            this.textbox2_output2.Text = "";
            this.textbox2_output2.TextChanged += new System.EventHandler(this.textbox2_output2_TextChanged);
            // 
            // progressBar_2
            // 
            this.progressBar_2.Location = new System.Drawing.Point(16, 28);
            this.progressBar_2.Name = "progressBar_2";
            this.progressBar_2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressBar_2.RightToLeftLayout = true;
            this.progressBar_2.Size = new System.Drawing.Size(23, 88);
            this.progressBar_2.TabIndex = 36;
            // 
            // knapp_reset
            // 
            this.knapp_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.knapp_reset.ForeColor = System.Drawing.Color.Red;
            this.knapp_reset.Location = new System.Drawing.Point(332, 586);
            this.knapp_reset.Name = "knapp_reset";
            this.knapp_reset.Size = new System.Drawing.Size(104, 38);
            this.knapp_reset.TabIndex = 37;
            this.knapp_reset.Text = "ÅTERSTÄLL";
            this.knapp_reset.UseVisualStyleBackColor = true;
            this.knapp_reset.Click += new System.EventHandler(this.knapp_reset_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.omToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(772, 24);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // omToolStripMenuItem
            // 
            this.omToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inEvolutionToQ2DSolution2016ToolStripMenuItem});
            this.omToolStripMenuItem.Name = "omToolStripMenuItem";
            this.omToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.omToolStripMenuItem.Text = "Om";
            // 
            // inEvolutionToQ2DSolution2016ToolStripMenuItem
            // 
            this.inEvolutionToQ2DSolution2016ToolStripMenuItem.Name = "inEvolutionToQ2DSolution2016ToolStripMenuItem";
            this.inEvolutionToQ2DSolution2016ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.inEvolutionToQ2DSolution2016ToolStripMenuItem.Text = "av a.Cincarevic";
            // 
            // knapp_rensaBox2
            // 
            this.knapp_rensaBox2.Location = new System.Drawing.Point(417, 196);
            this.knapp_rensaBox2.Name = "knapp_rensaBox2";
            this.knapp_rensaBox2.Size = new System.Drawing.Size(29, 23);
            this.knapp_rensaBox2.TabIndex = 39;
            this.knapp_rensaBox2.Text = "C";
            this.knapp_rensaBox2.UseVisualStyleBackColor = true;
            this.knapp_rensaBox2.Click += new System.EventHandler(this.knapp_rensaBox2_Click);
            // 
            // progressBar_1
            // 
            this.progressBar_1.Location = new System.Drawing.Point(213, 28);
            this.progressBar_1.Name = "progressBar_1";
            this.progressBar_1.Size = new System.Drawing.Size(23, 88);
            this.progressBar_1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar_1.TabIndex = 40;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar_1);
            this.groupBox1.Controls.Add(this.comboBox1_DataBits1);
            this.groupBox1.Controls.Add(this.comboBox1_port1);
            this.groupBox1.Controls.Add(dataBitsLabel);
            this.groupBox1.Controls.Add(baudRateLabel);
            this.groupBox1.Controls.Add(this.comboBox1_BaudRate1);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Location = new System.Drawing.Point(45, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 137);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enhet #1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(label2);
            this.groupBox2.Controls.Add(this.comboBox2_port2);
            this.groupBox2.Controls.Add(this.progressBar_2);
            this.groupBox2.Controls.Add(this.comboBox2_DataBits2);
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Controls.Add(this.comboBox2_BaudRate2);
            this.groupBox2.Controls.Add(label3);
            this.groupBox2.Location = new System.Drawing.Point(480, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 137);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enhet #2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::uartSniffer.Properties.Resources.netIcon;
            this.pictureBox1.Location = new System.Drawing.Point(354, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox_pause2
            // 
            this.checkBox_pause2.AutoSize = true;
            this.checkBox_pause2.Location = new System.Drawing.Point(452, 173);
            this.checkBox_pause2.Name = "checkBox_pause2";
            this.checkBox_pause2.Size = new System.Drawing.Size(56, 17);
            this.checkBox_pause2.TabIndex = 43;
            this.checkBox_pause2.Text = "Pause";
            this.checkBox_pause2.UseVisualStyleBackColor = true;
            this.checkBox_pause2.CheckedChanged += new System.EventHandler(this.checkBox_pause2_CheckedChanged);
            // 
            // checkBox_pause1
            // 
            this.checkBox_pause1.AutoSize = true;
            this.checkBox_pause1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_pause1.Location = new System.Drawing.Point(264, 173);
            this.checkBox_pause1.Name = "checkBox_pause1";
            this.checkBox_pause1.Size = new System.Drawing.Size(56, 17);
            this.checkBox_pause1.TabIndex = 44;
            this.checkBox_pause1.Text = "Pause";
            this.checkBox_pause1.UseVisualStyleBackColor = true;
            this.checkBox_pause1.CheckedChanged += new System.EventHandler(this.checkBox_pause1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 636);
            this.Controls.Add(this.checkBox_pause1);
            this.Controls.Add(this.checkBox_pause2);
            this.Controls.Add(this.knapp_rensaBox2);
            this.Controls.Add(this.knapp_reset);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textbox2_output2);
            this.Controls.Add(this.knapp_rensaBox1);
            this.Controls.Add(this.textbox_output);
            this.Controls.Add(this.knapp_portLyssnare);
            this.Controls.Add(this.knapp_hamtaPortar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "UART Sniffer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1_BaudRate1;
        private System.Windows.Forms.ComboBox comboBox1_DataBits1;
        private System.Windows.Forms.ComboBox comboBox1_port1;
        private System.Windows.Forms.ComboBox comboBox2_BaudRate2;
        private System.Windows.Forms.ComboBox comboBox2_DataBits2;
        private System.Windows.Forms.ComboBox comboBox2_port2;
        private System.Windows.Forms.Button knapp_hamtaPortar;
        private System.Windows.Forms.Button knapp_portLyssnare;
        private System.Windows.Forms.RichTextBox textbox_output;
        private System.Windows.Forms.Button knapp_rensaBox1;
        private System.Windows.Forms.RichTextBox textbox2_output2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar_2;
        private System.Windows.Forms.Button knapp_reset;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem omToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inEvolutionToQ2DSolution2016ToolStripMenuItem;
        private System.Windows.Forms.Button knapp_rensaBox2;
        private System.Windows.Forms.ProgressBar progressBar_1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox_pause2;
        private System.Windows.Forms.CheckBox checkBox_pause1;
    }
}

