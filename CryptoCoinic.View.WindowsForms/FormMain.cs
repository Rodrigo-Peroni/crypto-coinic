using CryptoCoinic.Api.Data.Controllers;
using CryptoCoinic.Api.Data.Models;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Timers;
using Microsoft.VisualBasic;
using System.Configuration;

namespace CryptoCoinic.View.WindowsForms
{
    public partial class FormMain : Form
    {
        private System.Timers.Timer timerData;
        TickerController tickerController;
        bool running = false;

        float minorAlertValue = float.MinValue;
        float majorAlertValue = float.MaxValue;

        public FormMain()
        {
            InitializeComponent();
        }

        #region Timers & Workers

        public void StartTimer()
        {
            tickerController = new TickerController(brokerComboBox.Text);

            timerData = new System.Timers.Timer(1000);
            timerData.Elapsed += TimerData_Tick;
            timerData.Start();

            UpdateApplicationState("StartTimer");
        }

        public void StopTimer()
        {
            timerData.Stop();
            UpdateApplicationState("StopTimer");
            timerData.Dispose();            
        }

        private void TimerData_Tick(object sender, ElapsedEventArgs e)
        {
            if (!dataBackgroundWorker.IsBusy)
            {
                dataBackgroundWorker.RunWorkerAsync();
            }
        }

        private void DataBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            UpdateData();
            if (dataProgressBar.Value == dataProgressBar.Maximum)
                dataProgressBar.Invoke((MethodInvoker)delegate { dataProgressBar.Value = 0; });
            else
                dataProgressBar.Invoke((MethodInvoker)delegate { dataProgressBar.Value += 1; });
        }

        #endregion

        #region Click & Other Events

        private void GetTickerButton_Click(object sender, EventArgs e)
        {            

        }

        private void UpdateApplicationState(string instruction)
        {
            switch (instruction)
            {
                case "StopTimer":
                    running = false;
                    tickerController.Dispose();
                    timerStatusSquare.Invoke((MethodInvoker)delegate { timerStatusSquare.BackColor = Color.Red; });
                    dataProgressBar.Invoke((MethodInvoker)delegate { dataProgressBar.Value = 0; });
                    startScanToolStripMenuItem.Text = "Start Scan";
                    break;
                case "StartTimer":
                    running = true;
                    timerStatusSquare.Invoke((MethodInvoker)delegate { timerStatusSquare.BackColor = Color.Green; });
                    startScanToolStripMenuItem.Text = "Stop Scan";
                    break;
            }
        }

        #endregion

        #region Alerts

        private void setMinorAlertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string alertValue = Interaction.InputBox("Set the Minor Alert value to be used. " +
                "Values below the one set are going to raise an alert. Enter \"-\" to Cancel the alerts.",
                "Set Minor Alert", "0");
            try
            {
                if (!alertValue.Equals("-"))
                {
                    minorAlertValue = float.Parse(alertValue);
                    minorAlertLabel.Text = "R$ " + minorAlertValue.ToString("0.00");
                }
                else
                {
                    minorAlertValue = float.MinValue;
                    minorAlertLabel.Text = "-";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not set alert value. Error: " + ex.Message, "Error");
            }
        }

        private void setMajorAlertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string alertValue = Interaction.InputBox("Set the Major Alert value to be used. " +
                "Values higher the one set are going to raise an alert. Enter \"-\" to Cancel the alerts.",
                "Set Major Alert", "0");
            try
            {
                if (!alertValue.Equals("-"))
                {
                    majorAlertValue = float.Parse(alertValue);
                    majorAlertLabel.Text = "R$ " + majorAlertValue.ToString("0.00");
                }
                else
                {
                    majorAlertValue = float.MaxValue;
                    majorAlertLabel.Text = "-";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not set alert value. Error: " + ex.Message, "Error");
            }
        }

        private void VerifyAlert(DataContent dataContent)
        {
            if ((float)dataContent.Ticker.Last <= minorAlertValue ||
                (float)dataContent.Ticker.Last >= majorAlertValue)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\temp\BOMB_SIREN.wav");
                player.Play();

                Thread.Sleep(10000);

                player.Stop();

                StopTimer();
            }
        }

        #endregion

        #region Screen Treatment        

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startScanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (running)
            {
                StopTimer();
            }
            else
            {
                StartTimer();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            brokerComboBox.Text = "MercadoBitcoin";
            currencyComboBox.Text = "BTC";

            if (ConfigurationManager.AppSettings["AutoStart"].Equals("true"))
                StartTimer();
        }

        #endregion

        private void UpdateData()
        {
            string currency = null;
            currencyComboBox.Invoke((MethodInvoker)delegate { currency = currencyComboBox.Text; });

            DataContent dataContent = tickerController.GetCurrentTicker(currency);

            VerifyAlert(dataContent);

            highLabel.Invoke((MethodInvoker)delegate { highLabel.Text = "R$ " + dataContent.Ticker.high.ToString("0.00"); });
            lowLabel.Invoke((MethodInvoker)delegate { lowLabel.Text = "R$ " + dataContent.Ticker.Low.ToString("0.00"); });
            volLabel.Invoke((MethodInvoker)delegate { volLabel.Text = "R$ " + dataContent.Ticker.Vol.ToString("0.00"); });
            lastLabel.Invoke((MethodInvoker)delegate { lastLabel.Text = "R$ " + dataContent.Ticker.Last.ToString("0.00"); });
            buyLabel.Invoke((MethodInvoker)delegate { buyLabel.Text = "R$ " + dataContent.Ticker.Buy.ToString("0.00"); });
            sellLabel.Invoke((MethodInvoker)delegate { sellLabel.Text = "R$ " + dataContent.Ticker.Sell.ToString("0.00"); });            
        }

    }
}
