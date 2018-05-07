﻿using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO.Ports;

namespace Walker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        System.Timers.Timer timer = new System.Timers.Timer();
        System.Timers.Timer timerBack = new System.Timers.Timer();
        System.Timers.Timer timerScan = new System.Timers.Timer();
        private string dataFolder;

        private async void BtnFullScan_Click(object sender, EventArgs e)
        {
            //接受激光探头数据
            Init(Convert.ToDouble(textBoxDistance.Text), Convert.ToDouble(textBoxTime.Text));
            //拍照定时
            timer.Elapsed += Timer_Elapsed;
            timer.Interval = 5000;
            timer.AutoReset = false;
            timer.Start();
            //扫描定时
            timerScan.Elapsed += TimerScan_Elapsed;
            timerScan.Interval = 1000;
            timerScan.AutoReset = true;
            timerScan.Start();
            //返回原点定时
            timerBack.Elapsed += TimerBack_Elapsed;
            timerBack.Interval = Convert.ToDouble(textBoxTime.Text) * 1000;
            timerBack.AutoReset = false;

            await ModbusClassic.Program.SendStart(port, GetUShort(tbRegisterAddress.Text), Convert.ToInt32(tbPulseCount.Text));
            timerBack.Start();
        }

        private void TimerScan_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            //扫描仪数据采集
            LMS111Classic.Program.SendRequestAsync(dataFolder);
        }

        private async void TimerBack_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            timerBack.Stop();
            //发送行走返回指令
            await ModbusClassic.Program.SendBack(port, 2048);
        }

        public void Init(double distance, double totalSecond)
        {
            dataFolder = LMS111Classic.Program.Init(distance, totalSecond);
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            timer.Stop();
            //5个图像采集
            ModbusClassic.Program.Capture5PhotosAsync(dataFolder);
            //单独图像拍摄
            ModbusClassic.Program.CaptureSinglePhotoAsync(dataFolder);
            timer.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            //停止大循环定时器
            timer.Stop();
            //停止511写入文件数据循环
            LMS111Classic.Program.Stop();
            //停止5个图像采集
            //停止单独图像拍摄
        }

        public SerialPort port;

        private async void btnPLCSet_Click(object sender, EventArgs e)
        {
            try
            {
                //打开与PLC的串口通信
                if (port == null)
                {
                    port = new SerialPort("COM" + GetUShort(tbPortNum.Text));
                    port.BaudRate = 9600;
                    port.DataBits = 8;
                    port.Parity = Parity.Even;
                    port.StopBits = StopBits.One;
                    port.Open();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private ushort GetUShort(string text)
        {
            //if (Regex.IsMatch(text, @"/^\d+$/ "))
            //{
            //    return Convert.ToUInt16(text);
            //}
            //else if (Regex.IsMatch(text, @"^0x[a-f0-9]{1,2}$)|(^0X[A-F0-9]{1,2}$)|(^[A-F0-9]{1,2}$)|(^[a-f0-9]{1,2}$"))
            //{
            //    return Convert.ToUInt16(text, 16);
            //}
            //else
            //{
            //    throw new FormatException("输入数值不合法");
            //}
            return Convert.ToUInt16(text);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (port != null && port.IsOpen)
            {
                port.Close();
            }
        }
    }
}
