using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseJiggler2021
{
    public enum JigStatus
    {
        idle,
        active,
        error
    }
    public partial class MainWindow : Form
    {
        Point LastMousePosition { get; set; }
        double IntervalDouble => Convert.ToDouble(IntervalNumUpDwn.Value) / Convert.ToDouble(JiggleTimer.Interval);
        bool JiggleToggle { get; set; }
        double DefaultCounter;
        double Counter;
        string idleString => "Idle";
        string activeString => "Doing a little jig!";

        public MainWindow()
        {
            this.Icon = Properties.Resources.mouse_idle;
            InitializeComponent();
            StartupApp();
        }

        void SetStatus(JigStatus status)
        {
            notifyIcon1.Icon = status switch
            {
                JigStatus.active => Properties.Resources.mouse_active,
                JigStatus.error => Properties.Resources.mouse_error,
                _ => Properties.Resources.mouse_idle
            };

            notifyIcon1.Text = status switch
            {
                JigStatus.active => activeString,
                JigStatus.error => "",
                _ => idleString
            };
        }
    

        private void StartupApp()
        {
            SetStatus(JigStatus.idle);
            LastMousePosition = MousePosition;
            JiggleTimer.Enabled = true;
            JiggleTimer.Start();
        }

        private void exNumUpDwn1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
        }

        private void JiggleTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (Counter == IntervalDouble)
                {
                    if (MousePosition == LastMousePosition)
                    {
                        if (WaiterCB.Checked)
                            Thread.Sleep(IntervalNumUpDwn.ValueInt * 1000);

                        Counter = DefaultCounter;
                        SetStatus(JigStatus.active);
                        if (JiggleToggle)
                            Utils.Jiggler.Jiggle(MoveUpDwn.ValueInt, MoveUpDwn.ValueInt);
                        else
                            Utils.Jiggler.Jiggle(MoveUpDwn.ValueInt * -1, MoveUpDwn.ValueInt * -1);
                        JiggleToggle = !JiggleToggle;
                    }
                }
                else
                {
                    if (MousePosition != LastMousePosition)
                    {
                        SetStatus(JigStatus.idle);
                    }
                }
            }
            catch (Exception)
            {
                SetStatus(JigStatus.error);
            }
            finally
            {
                LastMousePosition = MousePosition;
            }

            Counter = Counter < IntervalDouble ? Math.Round(Counter + 0.001, 3) : Math.Round(DefaultCounter, 3);            
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }
}
}
