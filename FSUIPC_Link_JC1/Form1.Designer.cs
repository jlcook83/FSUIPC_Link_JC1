namespace FSUIPC_Link_JC1
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
            this.components = new System.ComponentModel.Container();
            this.btnConnect = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoHearbeat = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.vTrimIndicator = new System.Windows.Forms.VScrollBar();
            this.vTrimInput = new System.Windows.Forms.VScrollBar();
            this.btnTrimDown = new System.Windows.Forms.Button();
            this.btnTrimUp = new System.Windows.Forms.Button();
            this.trimRptTimerUp = new System.Windows.Forms.Timer(this.components);
            this.trimRptTimerDown = new System.Windows.Forms.Timer(this.components);
            this.listComPorts = new System.Windows.Forms.ListBox();
            this.btnSerialConnect = new System.Windows.Forms.Button();
            this.textBoxDataIn = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(167, 47);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Not connected";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "STATUS:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoHearbeat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(1, 415);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 37);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // rdoHearbeat
            // 
            this.rdoHearbeat.AutoSize = true;
            this.rdoHearbeat.Location = new System.Drawing.Point(173, 14);
            this.rdoHearbeat.Name = "rdoHearbeat";
            this.rdoHearbeat.Size = new System.Drawing.Size(14, 13);
            this.rdoHearbeat.TabIndex = 4;
            this.rdoHearbeat.TabStop = true;
            this.rdoHearbeat.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // vTrimIndicator
            // 
            this.vTrimIndicator.Location = new System.Drawing.Point(12, 85);
            this.vTrimIndicator.Maximum = 16384;
            this.vTrimIndicator.Minimum = -16384;
            this.vTrimIndicator.Name = "vTrimIndicator";
            this.vTrimIndicator.Size = new System.Drawing.Size(22, 192);
            this.vTrimIndicator.TabIndex = 4;
            // 
            // vTrimInput
            // 
            this.vTrimInput.Location = new System.Drawing.Point(65, 85);
            this.vTrimInput.Maximum = 16384;
            this.vTrimInput.Minimum = -16384;
            this.vTrimInput.Name = "vTrimInput";
            this.vTrimInput.Size = new System.Drawing.Size(22, 192);
            this.vTrimInput.TabIndex = 5;
            this.vTrimInput.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vTrimInput_Scroll);
            this.vTrimInput.MouseCaptureChanged += new System.EventHandler(this.vTrimInput_MouseCaptureChanged);
            // 
            // btnTrimDown
            // 
            this.btnTrimDown.Location = new System.Drawing.Point(12, 284);
            this.btnTrimDown.Name = "btnTrimDown";
            this.btnTrimDown.Size = new System.Drawing.Size(75, 23);
            this.btnTrimDown.TabIndex = 6;
            this.btnTrimDown.Text = "Nose Down";
            this.btnTrimDown.UseVisualStyleBackColor = true;
            this.btnTrimDown.Click += new System.EventHandler(this.btnTrimDown_Click);
            this.btnTrimDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTrimDown_MouseDown);
            this.btnTrimDown.MouseLeave += new System.EventHandler(this.btnTrimDown_MouseLeave);
            this.btnTrimDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnTrimDown_MouseUp);
            // 
            // btnTrimUp
            // 
            this.btnTrimUp.Location = new System.Drawing.Point(12, 310);
            this.btnTrimUp.Name = "btnTrimUp";
            this.btnTrimUp.Size = new System.Drawing.Size(75, 23);
            this.btnTrimUp.TabIndex = 7;
            this.btnTrimUp.Text = "Nose Up";
            this.btnTrimUp.UseVisualStyleBackColor = true;
            this.btnTrimUp.Click += new System.EventHandler(this.btnTrimUp_Click);
            this.btnTrimUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTrimUp_MouseDown);
            this.btnTrimUp.MouseLeave += new System.EventHandler(this.btnTrimUp_MouseLeave);
            this.btnTrimUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnTrimUp_MouseUp);
            // 
            // trimRptTimerUp
            // 
            this.trimRptTimerUp.Tick += new System.EventHandler(this.trimRptTimerUp_Tick);
            // 
            // trimRptTimerDown
            // 
            this.trimRptTimerDown.Tick += new System.EventHandler(this.trimRptTimerDown_Tick);
            // 
            // listComPorts
            // 
            this.listComPorts.FormattingEnabled = true;
            this.listComPorts.Location = new System.Drawing.Point(612, 12);
            this.listComPorts.Name = "listComPorts";
            this.listComPorts.Size = new System.Drawing.Size(176, 186);
            this.listComPorts.TabIndex = 8;
            // 
            // btnSerialConnect
            // 
            this.btnSerialConnect.Location = new System.Drawing.Point(612, 204);
            this.btnSerialConnect.Name = "btnSerialConnect";
            this.btnSerialConnect.Size = new System.Drawing.Size(176, 29);
            this.btnSerialConnect.TabIndex = 9;
            this.btnSerialConnect.Text = "Connect";
            this.btnSerialConnect.UseVisualStyleBackColor = true;
            this.btnSerialConnect.Click += new System.EventHandler(this.btnSerialConnect_Click);
            // 
            // textBoxDataIn
            // 
            this.textBoxDataIn.Location = new System.Drawing.Point(530, 239);
            this.textBoxDataIn.Name = "textBoxDataIn";
            this.textBoxDataIn.ReadOnly = true;
            this.textBoxDataIn.Size = new System.Drawing.Size(258, 20);
            this.textBoxDataIn.TabIndex = 5;
            this.textBoxDataIn.Text = "Not connected";
            this.textBoxDataIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxDataIn);
            this.Controls.Add(this.btnSerialConnect);
            this.Controls.Add(this.listComPorts);
            this.Controls.Add(this.btnTrimUp);
            this.Controls.Add(this.btnTrimDown);
            this.Controls.Add(this.vTrimInput);
            this.Controls.Add(this.vTrimIndicator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "FSUIPC Link";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton rdoHearbeat;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.VScrollBar vTrimIndicator;
        private System.Windows.Forms.VScrollBar vTrimInput;
        private System.Windows.Forms.Button btnTrimDown;
        private System.Windows.Forms.Button btnTrimUp;
        private System.Windows.Forms.Timer trimRptTimerUp;
        private System.Windows.Forms.Timer trimRptTimerDown;
        private System.Windows.Forms.ListBox listComPorts;
        private System.Windows.Forms.Button btnSerialConnect;
        private System.Windows.Forms.TextBox textBoxDataIn;
    }
}

