﻿namespace FSUIPC_Link_JC1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textDiag = new System.Windows.Forms.TextBox();
            this.rdoHearbeat = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.trimRptTimerUp = new System.Windows.Forms.Timer(this.components);
            this.trimRptTimerDown = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdoWheelRight = new System.Windows.Forms.RadioButton();
            this.rdoWheelLeft = new System.Windows.Forms.RadioButton();
            this.btnSerialDisconnect = new System.Windows.Forms.Button();
            this.bManMoveMin = new System.Windows.Forms.Button();
            this.bManMoveMax = new System.Windows.Forms.Button();
            this.vManualApMove = new System.Windows.Forms.VScrollBar();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxDataIn = new System.Windows.Forms.TextBox();
            this.btnSerialConnect = new System.Windows.Forms.Button();
            this.listComPorts = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.hPollRate = new System.Windows.Forms.HScrollBar();
            this.btnTrimUp = new System.Windows.Forms.Button();
            this.btnTrimDown = new System.Windows.Forms.Button();
            this.vTrimInput = new System.Windows.Forms.VScrollBar();
            this.vTrimIndicator = new System.Windows.Forms.VScrollBar();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdoWheelSlow = new System.Windows.Forms.RadioButton();
            this.rdoWheelFast = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.numWheelRange = new System.Windows.Forms.NumericUpDown();
            this.btnPreset1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWheelRange)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.textDiag);
            this.groupBox1.Controls.Add(this.rdoHearbeat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(1, 415);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 37);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // textDiag
            // 
            this.textDiag.Location = new System.Drawing.Point(410, 11);
            this.textDiag.Name = "textDiag";
            this.textDiag.ReadOnly = true;
            this.textDiag.Size = new System.Drawing.Size(176, 20);
            this.textDiag.TabIndex = 11;
            this.textDiag.Text = "Diag";
            this.textDiag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // trimRptTimerUp
            // 
            this.trimRptTimerUp.Tick += new System.EventHandler(this.trimRptTimerUp_Tick);
            // 
            // trimRptTimerDown
            // 
            this.trimRptTimerDown.Tick += new System.EventHandler(this.trimRptTimerDown_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnPreset1);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.btnSerialDisconnect);
            this.groupBox2.Controls.Add(this.bManMoveMin);
            this.groupBox2.Controls.Add(this.bManMoveMax);
            this.groupBox2.Controls.Add(this.vManualApMove);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBoxDataIn);
            this.groupBox2.Controls.Add(this.btnSerialConnect);
            this.groupBox2.Controls.Add(this.listComPorts);
            this.groupBox2.Location = new System.Drawing.Point(274, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 397);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trim Wheel";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdoWheelRight);
            this.groupBox4.Controls.Add(this.rdoWheelLeft);
            this.groupBox4.Location = new System.Drawing.Point(7, 326);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(109, 65);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Wheel Orientation";
            // 
            // rdoWheelRight
            // 
            this.rdoWheelRight.AutoSize = true;
            this.rdoWheelRight.Checked = true;
            this.rdoWheelRight.Location = new System.Drawing.Point(20, 42);
            this.rdoWheelRight.Name = "rdoWheelRight";
            this.rdoWheelRight.Size = new System.Drawing.Size(50, 17);
            this.rdoWheelRight.TabIndex = 1;
            this.rdoWheelRight.TabStop = true;
            this.rdoWheelRight.Text = "Right";
            this.rdoWheelRight.UseVisualStyleBackColor = true;
            this.rdoWheelRight.CheckedChanged += new System.EventHandler(this.rdoWheelRight_CheckedChanged);
            // 
            // rdoWheelLeft
            // 
            this.rdoWheelLeft.AutoSize = true;
            this.rdoWheelLeft.Location = new System.Drawing.Point(20, 18);
            this.rdoWheelLeft.Name = "rdoWheelLeft";
            this.rdoWheelLeft.Size = new System.Drawing.Size(43, 17);
            this.rdoWheelLeft.TabIndex = 0;
            this.rdoWheelLeft.Text = "Left";
            this.rdoWheelLeft.UseVisualStyleBackColor = true;
            this.rdoWheelLeft.CheckedChanged += new System.EventHandler(this.rdoWheelLeft_CheckedChanged);
            // 
            // btnSerialDisconnect
            // 
            this.btnSerialDisconnect.Location = new System.Drawing.Point(108, 260);
            this.btnSerialDisconnect.Name = "btnSerialDisconnect";
            this.btnSerialDisconnect.Size = new System.Drawing.Size(176, 29);
            this.btnSerialDisconnect.TabIndex = 22;
            this.btnSerialDisconnect.Text = "Disconnect";
            this.btnSerialDisconnect.UseVisualStyleBackColor = true;
            this.btnSerialDisconnect.Click += new System.EventHandler(this.btnSerialDisconnect_Click);
            // 
            // bManMoveMin
            // 
            this.bManMoveMin.Location = new System.Drawing.Point(27, 104);
            this.bManMoveMin.Name = "bManMoveMin";
            this.bManMoveMin.Size = new System.Drawing.Size(75, 21);
            this.bManMoveMin.TabIndex = 21;
            this.bManMoveMin.Text = "max";
            this.bManMoveMin.UseVisualStyleBackColor = true;
            this.bManMoveMin.Click += new System.EventHandler(this.bManMoveMin_Click);
            // 
            // bManMoveMax
            // 
            this.bManMoveMax.Location = new System.Drawing.Point(27, 264);
            this.bManMoveMax.Name = "bManMoveMax";
            this.bManMoveMax.Size = new System.Drawing.Size(75, 21);
            this.bManMoveMax.TabIndex = 20;
            this.bManMoveMax.Text = "min";
            this.bManMoveMax.UseVisualStyleBackColor = true;
            this.bManMoveMax.Click += new System.EventHandler(this.bManMoveMax_Click);
            // 
            // vManualApMove
            // 
            this.vManualApMove.LargeChange = 1;
            this.vManualApMove.Location = new System.Drawing.Point(27, 128);
            this.vManualApMove.Maximum = 16384;
            this.vManualApMove.Minimum = -16383;
            this.vManualApMove.Name = "vManualApMove";
            this.vManualApMove.Size = new System.Drawing.Size(75, 130);
            this.vManualApMove.TabIndex = 19;
            this.vManualApMove.Value = -16383;
            this.vManualApMove.ValueChanged += new System.EventHandler(this.vManualApMove_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 18;
            this.button1.Text = "Override";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxDataIn
            // 
            this.textBoxDataIn.Location = new System.Drawing.Point(108, 290);
            this.textBoxDataIn.Name = "textBoxDataIn";
            this.textBoxDataIn.ReadOnly = true;
            this.textBoxDataIn.Size = new System.Drawing.Size(176, 20);
            this.textBoxDataIn.TabIndex = 15;
            this.textBoxDataIn.Text = "Not connected";
            this.textBoxDataIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSerialConnect
            // 
            this.btnSerialConnect.Location = new System.Drawing.Point(108, 229);
            this.btnSerialConnect.Name = "btnSerialConnect";
            this.btnSerialConnect.Size = new System.Drawing.Size(176, 29);
            this.btnSerialConnect.TabIndex = 17;
            this.btnSerialConnect.Text = "Connect";
            this.btnSerialConnect.UseVisualStyleBackColor = true;
            this.btnSerialConnect.Click += new System.EventHandler(this.btnSerialConnect_Click);
            // 
            // listComPorts
            // 
            this.listComPorts.FormattingEnabled = true;
            this.listComPorts.Location = new System.Drawing.Point(108, 37);
            this.listComPorts.Name = "listComPorts";
            this.listComPorts.Size = new System.Drawing.Size(176, 186);
            this.listComPorts.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.hPollRate);
            this.groupBox3.Controls.Add(this.btnTrimUp);
            this.groupBox3.Controls.Add(this.btnTrimDown);
            this.groupBox3.Controls.Add(this.vTrimInput);
            this.groupBox3.Controls.Add(this.vTrimIndicator);
            this.groupBox3.Controls.Add(this.btnConnect);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 397);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "FSUIPC";
            // 
            // hPollRate
            // 
            this.hPollRate.Location = new System.Drawing.Point(16, 69);
            this.hPollRate.Maximum = 500;
            this.hPollRate.Minimum = 1;
            this.hPollRate.Name = "hPollRate";
            this.hPollRate.Size = new System.Drawing.Size(218, 23);
            this.hPollRate.TabIndex = 17;
            this.hPollRate.Value = 5;
            this.hPollRate.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hPollRate_Scroll);
            this.hPollRate.ValueChanged += new System.EventHandler(this.hPollRate_ValueChanged);
            // 
            // btnTrimUp
            // 
            this.btnTrimUp.Location = new System.Drawing.Point(7, 355);
            this.btnTrimUp.Name = "btnTrimUp";
            this.btnTrimUp.Size = new System.Drawing.Size(75, 23);
            this.btnTrimUp.TabIndex = 16;
            this.btnTrimUp.Text = "Nose Up";
            this.btnTrimUp.UseVisualStyleBackColor = true;
            this.btnTrimUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTrimUp_MouseDown);
            this.btnTrimUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnTrimUp_MouseUp);
            // 
            // btnTrimDown
            // 
            this.btnTrimDown.Location = new System.Drawing.Point(7, 326);
            this.btnTrimDown.Name = "btnTrimDown";
            this.btnTrimDown.Size = new System.Drawing.Size(75, 23);
            this.btnTrimDown.TabIndex = 15;
            this.btnTrimDown.Text = "Nose Down";
            this.btnTrimDown.UseVisualStyleBackColor = true;
            this.btnTrimDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTrimDown_MouseDown);
            this.btnTrimDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnTrimDown_MouseUp);
            // 
            // vTrimInput
            // 
            this.vTrimInput.Location = new System.Drawing.Point(56, 189);
            this.vTrimInput.Maximum = 16384;
            this.vTrimInput.Minimum = -16384;
            this.vTrimInput.Name = "vTrimInput";
            this.vTrimInput.Size = new System.Drawing.Size(22, 134);
            this.vTrimInput.TabIndex = 14;
            // 
            // vTrimIndicator
            // 
            this.vTrimIndicator.Location = new System.Drawing.Point(7, 189);
            this.vTrimIndicator.Maximum = 16384;
            this.vTrimIndicator.Minimum = -16384;
            this.vTrimIndicator.Name = "vTrimIndicator";
            this.vTrimIndicator.Size = new System.Drawing.Size(22, 134);
            this.vTrimIndicator.TabIndex = 13;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(16, 19);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(218, 47);
            this.btnConnect.TabIndex = 12;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdoWheelSlow);
            this.groupBox5.Controls.Add(this.rdoWheelFast);
            this.groupBox5.Location = new System.Drawing.Point(122, 326);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(89, 65);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Wheel Speed";
            // 
            // rdoWheelSlow
            // 
            this.rdoWheelSlow.AutoSize = true;
            this.rdoWheelSlow.Checked = true;
            this.rdoWheelSlow.Location = new System.Drawing.Point(20, 42);
            this.rdoWheelSlow.Name = "rdoWheelSlow";
            this.rdoWheelSlow.Size = new System.Drawing.Size(48, 17);
            this.rdoWheelSlow.TabIndex = 1;
            this.rdoWheelSlow.TabStop = true;
            this.rdoWheelSlow.Text = "Slow";
            this.rdoWheelSlow.UseVisualStyleBackColor = true;
            this.rdoWheelSlow.CheckedChanged += new System.EventHandler(this.rdoWheelSlow_CheckedChanged);
            // 
            // rdoWheelFast
            // 
            this.rdoWheelFast.AutoSize = true;
            this.rdoWheelFast.Location = new System.Drawing.Point(20, 18);
            this.rdoWheelFast.Name = "rdoWheelFast";
            this.rdoWheelFast.Size = new System.Drawing.Size(45, 17);
            this.rdoWheelFast.TabIndex = 0;
            this.rdoWheelFast.Text = "Fast";
            this.rdoWheelFast.UseVisualStyleBackColor = true;
            this.rdoWheelFast.CheckedChanged += new System.EventHandler(this.rdoWheelFast_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.numWheelRange);
            this.groupBox6.Location = new System.Drawing.Point(217, 326);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(87, 65);
            this.groupBox6.TabIndex = 25;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Wheel Range";
            // 
            // numWheelRange
            // 
            this.numWheelRange.Location = new System.Drawing.Point(7, 29);
            this.numWheelRange.Name = "numWheelRange";
            this.numWheelRange.Size = new System.Drawing.Size(74, 20);
            this.numWheelRange.TabIndex = 0;
            this.numWheelRange.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numWheelRange.ValueChanged += new System.EventHandler(this.numWheelRange_ValueChanged);
            // 
            // btnPreset1
            // 
            this.btnPreset1.Location = new System.Drawing.Point(27, 45);
            this.btnPreset1.Name = "btnPreset1";
            this.btnPreset1.Size = new System.Drawing.Size(75, 21);
            this.btnPreset1.TabIndex = 26;
            this.btnPreset1.Text = "C-172";
            this.btnPreset1.UseVisualStyleBackColor = true;
            this.btnPreset1.Click += new System.EventHandler(this.btnPreset1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Presets";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "FSUIPC Link";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numWheelRange)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton rdoHearbeat;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer trimRptTimerUp;
        private System.Windows.Forms.Timer trimRptTimerDown;
        private System.Windows.Forms.TextBox textDiag;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bManMoveMin;
        private System.Windows.Forms.Button bManMoveMax;
        private System.Windows.Forms.VScrollBar vManualApMove;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxDataIn;
        private System.Windows.Forms.Button btnSerialConnect;
        private System.Windows.Forms.ListBox listComPorts;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.HScrollBar hPollRate;
        private System.Windows.Forms.Button btnTrimUp;
        private System.Windows.Forms.Button btnTrimDown;
        private System.Windows.Forms.VScrollBar vTrimInput;
        private System.Windows.Forms.VScrollBar vTrimIndicator;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSerialDisconnect;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdoWheelRight;
        private System.Windows.Forms.RadioButton rdoWheelLeft;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown numWheelRange;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rdoWheelSlow;
        private System.Windows.Forms.RadioButton rdoWheelFast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPreset1;
    }
}

