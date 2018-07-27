using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace FastToolsMonitor
{
    public partial class Form1 : Form
    {
        System.Timers.Timer timerCheckOPC = new System.Timers.Timer();
        private static int counterStarted;
           
        public Form1()
        {
            InitializeComponent();
            notifyIcon1.Icon = resources.iconSync;
            mTimer(timerCheckOPC);
            counterStarted = 0;
        }
        private void statePic_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - Width) + 20, (Screen.PrimaryScreen.WorkingArea.Height - Height));
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        public void startCheckOPC(Object source, System.Timers.ElapsedEventArgs e)
        {
            Thread checkOPC = new Thread(new ThreadStart(checkingOPC));
            checkOPC.Start();
        }

        #region utils
        void mTimer(System.Timers.Timer timer)
        {
            timer.Interval = 1000;
            timer.AutoReset = true;
            timer.Enabled = true;
            //Event elapsed timer
            timer.Elapsed += startCheckOPC;
        }

        public void checkingOPC()
        {
            //Сервер стал активным
            if (checkProc("opxdas12") && checkProc("alh") && checkProc("durm_udp") && !checkProc("OPC104")) 
            {
                statePic.Image = resources.notOk;
                notifyIcon1.Icon = resources.iconNotOk;
                //Запустить ОРС104
                if (counterStarted == Properties.Settings.Default.time)
                {
                    Process.Start(@"C:\Program files (x86)\ProsoftSystems\opc104\OPC104.exe");
                    counterStarted = 0;
                }else
                {
                    counterStarted++;
                }
            }
            //Сервер перешел в standby 
            if (!checkProc("opxdas12") && !checkProc("alh") && !checkProc("durm_udp") && checkProc("OPC104")) 
            {
                counterStarted = 0;
                statePic.Image = resources.Warn;
                notifyIcon1.Icon = resources.iconWarn;
                //Убить все процессы с именем ОРС104
                foreach (var opc104 in Process.GetProcessesByName("OPC104"))
                {
                    if (killClose.Checked) { opc104.CloseMainWindow(); }
                    else { opc104.Kill(); }                                   
                }
            }
            //Сервер в режиме ожидания, ОРС104 остановлен
            if (!checkProc("opxdas12") && !checkProc("OPC104")) 
            {
                counterStarted = 0;
                statePic.Image = resources.Sync;
                notifyIcon1.Icon = resources.iconSync;
            }
            //Сервер активен ОРС104 запущен
            if (checkProc("opxdas12") && checkProc("alh") && checkProc("durm_udp") && checkProc("OPC104")) 
            {
                counterStarted = 0;
                statePic.Image = resources.Ok;
                notifyIcon1.Icon = resources.iconOk;
            }
        }
        public bool checkProc(string name)
        {
            return Process.GetProcessesByName(name).Any();
        }
        #endregion utils

    }
}
