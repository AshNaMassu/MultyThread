namespace MultyThread
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbT0 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbT0 = new System.Windows.Forms.TextBox();
            this.bT0Click = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbT1 = new System.Windows.Forms.TextBox();
            this.bT1Click = new System.Windows.Forms.Button();
            this.pbT1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbT2 = new System.Windows.Forms.TextBox();
            this.bT3Click = new System.Windows.Forms.Button();
            this.pbT2 = new System.Windows.Forms.PictureBox();
            this.bTAll = new System.Windows.Forms.Button();
            this.pbStatusT0 = new System.Windows.Forms.PictureBox();
            this.pbStatusT1 = new System.Windows.Forms.PictureBox();
            this.pbStatusT2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbT0)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbT1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbT2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusT0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusT1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusT2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbT0
            // 
            this.pbT0.BackColor = System.Drawing.Color.White;
            this.pbT0.Location = new System.Drawing.Point(4, 48);
            this.pbT0.Name = "pbT0";
            this.pbT0.Size = new System.Drawing.Size(256, 400);
            this.pbT0.TabIndex = 0;
            this.pbT0.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbStatusT0);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbT0);
            this.groupBox1.Controls.Add(this.bT0Click);
            this.groupBox1.Controls.Add(this.pbT0);
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 453);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thead 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Status: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Delay:";
            // 
            // tbT0
            // 
            this.tbT0.Location = new System.Drawing.Point(220, 19);
            this.tbT0.Name = "tbT0";
            this.tbT0.Size = new System.Drawing.Size(40, 23);
            this.tbT0.TabIndex = 2;
            this.tbT0.Text = "100";
            this.tbT0.TextChanged += new System.EventHandler(this.tbT0_TextChanged);
            // 
            // bT0Click
            // 
            this.bT0Click.Location = new System.Drawing.Point(4, 19);
            this.bT0Click.Name = "bT0Click";
            this.bT0Click.Size = new System.Drawing.Size(75, 23);
            this.bT0Click.TabIndex = 2;
            this.bT0Click.Text = "Start/Stop";
            this.bT0Click.UseVisualStyleBackColor = true;
            this.bT0Click.Click += new System.EventHandler(this.bT0Click_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rtbLog);
            this.groupBox4.Location = new System.Drawing.Point(12, 530);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(800, 175);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Log";
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(6, 22);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(788, 147);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pbStatusT1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbT1);
            this.groupBox2.Controls.Add(this.bT1Click);
            this.groupBox2.Controls.Add(this.pbT1);
            this.groupBox2.Location = new System.Drawing.Point(282, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 453);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thead 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Status: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Delay:";
            // 
            // tbT1
            // 
            this.tbT1.Location = new System.Drawing.Point(220, 19);
            this.tbT1.Name = "tbT1";
            this.tbT1.Size = new System.Drawing.Size(40, 23);
            this.tbT1.TabIndex = 2;
            this.tbT1.Text = "200";
            this.tbT1.TextChanged += new System.EventHandler(this.tbT1_TextChanged);
            // 
            // bT1Click
            // 
            this.bT1Click.Location = new System.Drawing.Point(4, 19);
            this.bT1Click.Name = "bT1Click";
            this.bT1Click.Size = new System.Drawing.Size(75, 23);
            this.bT1Click.TabIndex = 2;
            this.bT1Click.Text = "Start/Stop";
            this.bT1Click.UseVisualStyleBackColor = true;
            this.bT1Click.Click += new System.EventHandler(this.bT1Click_Click);
            // 
            // pbT1
            // 
            this.pbT1.BackColor = System.Drawing.Color.White;
            this.pbT1.Location = new System.Drawing.Point(4, 48);
            this.pbT1.Name = "pbT1";
            this.pbT1.Size = new System.Drawing.Size(256, 400);
            this.pbT1.TabIndex = 0;
            this.pbT1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pbStatusT2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbT2);
            this.groupBox3.Controls.Add(this.bT3Click);
            this.groupBox3.Controls.Add(this.pbT2);
            this.groupBox3.Location = new System.Drawing.Point(551, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 453);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thead 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Status: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Delay:";
            // 
            // tbT2
            // 
            this.tbT2.Location = new System.Drawing.Point(221, 19);
            this.tbT2.Name = "tbT2";
            this.tbT2.Size = new System.Drawing.Size(40, 23);
            this.tbT2.TabIndex = 2;
            this.tbT2.Text = "300";
            this.tbT2.TextChanged += new System.EventHandler(this.tbT2_TextChanged);
            // 
            // bT3Click
            // 
            this.bT3Click.Location = new System.Drawing.Point(4, 19);
            this.bT3Click.Name = "bT3Click";
            this.bT3Click.Size = new System.Drawing.Size(75, 23);
            this.bT3Click.TabIndex = 2;
            this.bT3Click.Text = "Start/Stop";
            this.bT3Click.UseVisualStyleBackColor = true;
            this.bT3Click.Click += new System.EventHandler(this.bT3Click_Click);
            // 
            // pbT2
            // 
            this.pbT2.BackColor = System.Drawing.Color.White;
            this.pbT2.Location = new System.Drawing.Point(4, 48);
            this.pbT2.Name = "pbT2";
            this.pbT2.Size = new System.Drawing.Size(256, 400);
            this.pbT2.TabIndex = 0;
            this.pbT2.TabStop = false;
            // 
            // bTAll
            // 
            this.bTAll.Location = new System.Drawing.Point(282, 12);
            this.bTAll.Name = "bTAll";
            this.bTAll.Size = new System.Drawing.Size(264, 31);
            this.bTAll.TabIndex = 5;
            this.bTAll.Text = "Start/Stop all";
            this.bTAll.UseVisualStyleBackColor = true;
            this.bTAll.Click += new System.EventHandler(this.bTAll_Click);
            // 
            // pbStatusT0
            // 
            this.pbStatusT0.BackColor = System.Drawing.Color.Red;
            this.pbStatusT0.Location = new System.Drawing.Point(126, 23);
            this.pbStatusT0.Name = "pbStatusT0";
            this.pbStatusT0.Size = new System.Drawing.Size(16, 16);
            this.pbStatusT0.TabIndex = 6;
            this.pbStatusT0.TabStop = false;
            // 
            // pbStatusT1
            // 
            this.pbStatusT1.BackColor = System.Drawing.Color.Red;
            this.pbStatusT1.Location = new System.Drawing.Point(126, 23);
            this.pbStatusT1.Name = "pbStatusT1";
            this.pbStatusT1.Size = new System.Drawing.Size(16, 16);
            this.pbStatusT1.TabIndex = 7;
            this.pbStatusT1.TabStop = false;
            // 
            // pbStatusT2
            // 
            this.pbStatusT2.BackColor = System.Drawing.Color.Red;
            this.pbStatusT2.Location = new System.Drawing.Point(126, 23);
            this.pbStatusT2.Name = "pbStatusT2";
            this.pbStatusT2.Size = new System.Drawing.Size(16, 16);
            this.pbStatusT2.TabIndex = 7;
            this.pbStatusT2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 717);
            this.Controls.Add(this.bTAll);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbT0)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbT1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbT2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusT0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusT1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusT2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pbT0;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox tbT0;
        private Button bT0Click;
        private GroupBox groupBox4;
        private RichTextBox rtbLog;
        private GroupBox groupBox2;
        private Label label2;
        private TextBox tbT1;
        private Button bT1Click;
        private PictureBox pbT1;
        private GroupBox groupBox3;
        private Label label3;
        private TextBox tbT2;
        private Button bT3Click;
        private PictureBox pbT2;
        private Button bTAll;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pbStatusT0;
        private PictureBox pbStatusT1;
        private PictureBox pbStatusT2;
    }
}