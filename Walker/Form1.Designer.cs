﻿namespace Walker
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbModbusID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRegisterAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPortNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPulseCount = new System.Windows.Forms.TextBox();
            this.btnPLCSet = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnFullScan = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDistance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbModbusID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbRegisterAddress);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbPortNum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbPulseCount);
            this.groupBox1.Controls.Add(this.btnPLCSet);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PLC连接";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "ModbusRTU ID";
            // 
            // tbModbusID
            // 
            this.tbModbusID.Location = new System.Drawing.Point(158, 119);
            this.tbModbusID.Name = "tbModbusID";
            this.tbModbusID.Size = new System.Drawing.Size(100, 21);
            this.tbModbusID.TabIndex = 7;
            this.tbModbusID.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "寄存器短地址(PLC地址-1)";
            // 
            // tbRegisterAddress
            // 
            this.tbRegisterAddress.Location = new System.Drawing.Point(158, 86);
            this.tbRegisterAddress.Name = "tbRegisterAddress";
            this.tbRegisterAddress.Size = new System.Drawing.Size(100, 21);
            this.tbRegisterAddress.TabIndex = 5;
            this.tbRegisterAddress.Text = "4108";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "PLC通讯端口序号（COM）";
            // 
            // tbPortNum
            // 
            this.tbPortNum.Location = new System.Drawing.Point(158, 53);
            this.tbPortNum.Name = "tbPortNum";
            this.tbPortNum.Size = new System.Drawing.Size(100, 21);
            this.tbPortNum.TabIndex = 3;
            this.tbPortNum.Text = "6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "写入脉冲数";
            // 
            // tbPulseCount
            // 
            this.tbPulseCount.Location = new System.Drawing.Point(158, 20);
            this.tbPulseCount.Name = "tbPulseCount";
            this.tbPulseCount.Size = new System.Drawing.Size(100, 21);
            this.tbPulseCount.TabIndex = 1;
            this.tbPulseCount.Text = "420000";
            // 
            // btnPLCSet
            // 
            this.btnPLCSet.Location = new System.Drawing.Point(188, 153);
            this.btnPLCSet.Name = "btnPLCSet";
            this.btnPLCSet.Size = new System.Drawing.Size(70, 22);
            this.btnPLCSet.TabIndex = 0;
            this.btnPLCSet.Text = "打开串口";
            this.btnPLCSet.UseVisualStyleBackColor = true;
            this.btnPLCSet.Click += new System.EventHandler(this.btnPLCSet_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStop);
            this.groupBox2.Controls.Add(this.btnFullScan);
            this.groupBox2.Location = new System.Drawing.Point(305, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 81);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "扫描控制";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(124, 33);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(70, 22);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "中止扫描";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnFullScan
            // 
            this.btnFullScan.Location = new System.Drawing.Point(22, 33);
            this.btnFullScan.Name = "btnFullScan";
            this.btnFullScan.Size = new System.Drawing.Size(70, 22);
            this.btnFullScan.TabIndex = 1;
            this.btnFullScan.Text = "完整扫描";
            this.btnFullScan.UseVisualStyleBackColor = true;
            this.btnFullScan.Click += new System.EventHandler(this.BtnFullScan_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBoxDistance);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBoxTime);
            this.groupBox3.Location = new System.Drawing.Point(305, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(277, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "行走";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "单程行走距离（m）";
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.Location = new System.Drawing.Point(149, 52);
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.Size = new System.Drawing.Size(100, 21);
            this.textBoxDistance.TabIndex = 11;
            this.textBoxDistance.Text = "16.3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "单趟时间（s）";
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(149, 19);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(100, 21);
            this.textBoxTime.TabIndex = 9;
            this.textBoxTime.Text = "143";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 205);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(590, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 227);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPortNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPulseCount;
        private System.Windows.Forms.Button btnPLCSet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFullScan;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbModbusID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRegisterAddress;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDistance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

