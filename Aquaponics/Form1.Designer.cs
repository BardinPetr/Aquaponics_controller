namespace Aquaponics
{
    partial class Form1
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
            this.connect_btn = new System.Windows.Forms.Button();
            this.portBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusL = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RTD_L = new System.Windows.Forms.Label();
            this.OPR_L = new System.Windows.Forms.Label();
            this.CO_L = new System.Windows.Forms.Label();
            this.DO_L = new System.Windows.Forms.Label();
            this.PH_L = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.P_1 = new System.Windows.Forms.Label();
            this.P_2 = new System.Windows.Forms.Label();
            this.P_3 = new System.Windows.Forms.Label();
            this.P_4 = new System.Windows.Forms.Label();
            this.P10 = new System.Windows.Forms.Button();
            this.P00 = new System.Windows.Forms.Button();
            this.P01 = new System.Windows.Forms.Button();
            this.P11 = new System.Windows.Forms.Button();
            this.P03 = new System.Windows.Forms.Button();
            this.P13 = new System.Windows.Forms.Button();
            this.P02 = new System.Windows.Forms.Button();
            this.P12 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // connect_btn
            // 
            this.connect_btn.Image = global::Aquaponics.Properties.Resources.power_plug_off;
            this.connect_btn.Location = new System.Drawing.Point(138, 10);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(64, 64);
            this.connect_btn.TabIndex = 0;
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.connect_Click);
            // 
            // portBox
            // 
            this.portBox.FormattingEnabled = true;
            this.portBox.Location = new System.Drawing.Point(11, 44);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(121, 21);
            this.portBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "COM port";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.connect_btn);
            this.groupBox1.Controls.Add(this.portBox);
            this.groupBox1.Location = new System.Drawing.Point(889, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 81);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusL});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1109, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusL
            // 
            this.statusL.Name = "statusL";
            this.statusL.Size = new System.Drawing.Size(68, 17);
            this.statusL.Text = "Status: IDLE";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RTD_L);
            this.groupBox2.Controls.Add(this.OPR_L);
            this.groupBox2.Controls.Add(this.CO_L);
            this.groupBox2.Controls.Add(this.DO_L);
            this.groupBox2.Controls.Add(this.PH_L);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 198);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(6, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ph";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Disslowed Oxygen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.LawnGreen;
            this.label4.Location = new System.Drawing.Point(6, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "Conductivity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Turquoise;
            this.label5.Location = new System.Drawing.Point(6, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 36);
            this.label5.TabIndex = 6;
            this.label5.Text = "OPR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(6, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 36);
            this.label6.TabIndex = 6;
            this.label6.Text = "Temperature";
            // 
            // RTD_L
            // 
            this.RTD_L.AutoSize = true;
            this.RTD_L.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RTD_L.ForeColor = System.Drawing.Color.MidnightBlue;
            this.RTD_L.Location = new System.Drawing.Point(222, 88);
            this.RTD_L.Name = "RTD_L";
            this.RTD_L.Size = new System.Drawing.Size(65, 36);
            this.RTD_L.TabIndex = 10;
            this.RTD_L.Text = "N/R";
            // 
            // OPR_L
            // 
            this.OPR_L.AutoSize = true;
            this.OPR_L.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OPR_L.ForeColor = System.Drawing.Color.Turquoise;
            this.OPR_L.Location = new System.Drawing.Point(222, 119);
            this.OPR_L.Name = "OPR_L";
            this.OPR_L.Size = new System.Drawing.Size(65, 36);
            this.OPR_L.TabIndex = 11;
            this.OPR_L.Text = "N/R";
            // 
            // CO_L
            // 
            this.CO_L.AutoSize = true;
            this.CO_L.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CO_L.ForeColor = System.Drawing.Color.LawnGreen;
            this.CO_L.Location = new System.Drawing.Point(222, 57);
            this.CO_L.Name = "CO_L";
            this.CO_L.Size = new System.Drawing.Size(65, 36);
            this.CO_L.TabIndex = 9;
            this.CO_L.Text = "N/R";
            // 
            // DO_L
            // 
            this.DO_L.AutoSize = true;
            this.DO_L.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DO_L.ForeColor = System.Drawing.Color.Gold;
            this.DO_L.Location = new System.Drawing.Point(222, 26);
            this.DO_L.Name = "DO_L";
            this.DO_L.Size = new System.Drawing.Size(65, 36);
            this.DO_L.TabIndex = 8;
            this.DO_L.Text = "N/R";
            // 
            // PH_L
            // 
            this.PH_L.AutoSize = true;
            this.PH_L.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PH_L.ForeColor = System.Drawing.Color.Red;
            this.PH_L.Location = new System.Drawing.Point(222, 150);
            this.PH_L.Name = "PH_L";
            this.PH_L.Size = new System.Drawing.Size(65, 36);
            this.PH_L.TabIndex = 7;
            this.PH_L.Text = "N/R";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.P03);
            this.groupBox3.Controls.Add(this.P13);
            this.groupBox3.Controls.Add(this.P02);
            this.groupBox3.Controls.Add(this.P12);
            this.groupBox3.Controls.Add(this.P01);
            this.groupBox3.Controls.Add(this.P11);
            this.groupBox3.Controls.Add(this.P00);
            this.groupBox3.Controls.Add(this.P10);
            this.groupBox3.Controls.Add(this.P_4);
            this.groupBox3.Controls.Add(this.P_3);
            this.groupBox3.Controls.Add(this.P_2);
            this.groupBox3.Controls.Add(this.P_1);
            this.groupBox3.Location = new System.Drawing.Point(13, 217);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(374, 208);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Controll";
            // 
            // P_1
            // 
            this.P_1.AutoSize = true;
            this.P_1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.P_1.ForeColor = System.Drawing.Color.Red;
            this.P_1.Location = new System.Drawing.Point(35, 16);
            this.P_1.Name = "P_1";
            this.P_1.Size = new System.Drawing.Size(46, 36);
            this.P_1.TabIndex = 12;
            this.P_1.Text = "P1";
            // 
            // P_2
            // 
            this.P_2.AutoSize = true;
            this.P_2.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.P_2.ForeColor = System.Drawing.Color.Red;
            this.P_2.Location = new System.Drawing.Point(113, 16);
            this.P_2.Name = "P_2";
            this.P_2.Size = new System.Drawing.Size(46, 36);
            this.P_2.TabIndex = 13;
            this.P_2.Text = "P2";
            // 
            // P_3
            // 
            this.P_3.AutoSize = true;
            this.P_3.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.P_3.ForeColor = System.Drawing.Color.Red;
            this.P_3.Location = new System.Drawing.Point(200, 16);
            this.P_3.Name = "P_3";
            this.P_3.Size = new System.Drawing.Size(46, 36);
            this.P_3.TabIndex = 14;
            this.P_3.Text = "P3";
            // 
            // P_4
            // 
            this.P_4.AutoSize = true;
            this.P_4.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.P_4.ForeColor = System.Drawing.Color.Red;
            this.P_4.Location = new System.Drawing.Point(284, 15);
            this.P_4.Name = "P_4";
            this.P_4.Size = new System.Drawing.Size(46, 36);
            this.P_4.TabIndex = 15;
            this.P_4.Text = "P4";
            // 
            // P10
            // 
            this.P10.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.P10.ForeColor = System.Drawing.Color.Lime;
            this.P10.Location = new System.Drawing.Point(25, 55);
            this.P10.Name = "P10";
            this.P10.Size = new System.Drawing.Size(67, 61);
            this.P10.TabIndex = 16;
            this.P10.Text = "ON";
            this.P10.UseVisualStyleBackColor = true;
            this.P10.Click += new System.EventHandler(this.P10_Click);
            // 
            // P00
            // 
            this.P00.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.P00.ForeColor = System.Drawing.Color.Crimson;
            this.P00.Location = new System.Drawing.Point(25, 122);
            this.P00.Name = "P00";
            this.P00.Size = new System.Drawing.Size(67, 61);
            this.P00.TabIndex = 17;
            this.P00.Text = "OFF";
            this.P00.UseVisualStyleBackColor = true;
            this.P00.Click += new System.EventHandler(this.P00_Click);
            // 
            // P01
            // 
            this.P01.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.P01.ForeColor = System.Drawing.Color.Crimson;
            this.P01.Location = new System.Drawing.Point(109, 122);
            this.P01.Name = "P01";
            this.P01.Size = new System.Drawing.Size(66, 61);
            this.P01.TabIndex = 19;
            this.P01.Text = "OFF";
            this.P01.UseVisualStyleBackColor = true;
            this.P01.Click += new System.EventHandler(this.P01_Click);
            // 
            // P11
            // 
            this.P11.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.P11.ForeColor = System.Drawing.Color.Lime;
            this.P11.Location = new System.Drawing.Point(109, 55);
            this.P11.Name = "P11";
            this.P11.Size = new System.Drawing.Size(66, 61);
            this.P11.TabIndex = 18;
            this.P11.Text = "ON";
            this.P11.UseVisualStyleBackColor = true;
            this.P11.Click += new System.EventHandler(this.P11_Click);
            // 
            // P03
            // 
            this.P03.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.P03.ForeColor = System.Drawing.Color.Crimson;
            this.P03.Location = new System.Drawing.Point(275, 122);
            this.P03.Name = "P03";
            this.P03.Size = new System.Drawing.Size(66, 61);
            this.P03.TabIndex = 23;
            this.P03.Text = "OFF";
            this.P03.UseVisualStyleBackColor = true;
            this.P03.Click += new System.EventHandler(this.P03_Click);
            // 
            // P13
            // 
            this.P13.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.P13.ForeColor = System.Drawing.Color.Lime;
            this.P13.Location = new System.Drawing.Point(275, 55);
            this.P13.Name = "P13";
            this.P13.Size = new System.Drawing.Size(66, 61);
            this.P13.TabIndex = 22;
            this.P13.Text = "ON";
            this.P13.UseVisualStyleBackColor = true;
            this.P13.Click += new System.EventHandler(this.P13_Click);
            // 
            // P02
            // 
            this.P02.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.P02.ForeColor = System.Drawing.Color.Crimson;
            this.P02.Location = new System.Drawing.Point(191, 122);
            this.P02.Name = "P02";
            this.P02.Size = new System.Drawing.Size(66, 61);
            this.P02.TabIndex = 21;
            this.P02.Text = "OFF";
            this.P02.UseVisualStyleBackColor = true;
            this.P02.Click += new System.EventHandler(this.P02_Click);
            // 
            // P12
            // 
            this.P12.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.P12.ForeColor = System.Drawing.Color.Lime;
            this.P12.Location = new System.Drawing.Point(191, 55);
            this.P12.Name = "P12";
            this.P12.Size = new System.Drawing.Size(66, 61);
            this.P12.TabIndex = 20;
            this.P12.Text = "ON";
            this.P12.UseVisualStyleBackColor = true;
            this.P12.Click += new System.EventHandler(this.P12_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(406, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(464, 403);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(456, 377);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(889, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 110);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(889, 244);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(208, 110);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Aquaponics controller";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.ComboBox portBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label RTD_L;
        private System.Windows.Forms.Label OPR_L;
        private System.Windows.Forms.Label CO_L;
        private System.Windows.Forms.Label DO_L;
        private System.Windows.Forms.Label PH_L;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button P03;
        private System.Windows.Forms.Button P13;
        private System.Windows.Forms.Button P02;
        private System.Windows.Forms.Button P12;
        private System.Windows.Forms.Button P01;
        private System.Windows.Forms.Button P11;
        private System.Windows.Forms.Button P00;
        private System.Windows.Forms.Button P10;
        private System.Windows.Forms.Label P_4;
        private System.Windows.Forms.Label P_3;
        private System.Windows.Forms.Label P_2;
        private System.Windows.Forms.Label P_1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

