using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmAdvanced
{
    public partial class Alarm : Form
    {
        public Alarm()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            txtHour.Text = DateTime.Now.Hour.ToString();
            txtMin.Text = DateTime.Now.Minute.ToString();
            txtSec.Text = DateTime.Now.Second.ToString();

            txtDate.Text = DateTime.Now.Date.ToString();
            txtWeek.Text = DateTime.Now.DayOfWeek.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Status.Visible = true;
            timer_alarm.Start();
        }


        private void txtAlarm_Hour_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAlarm_min_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void Alarm_Load(object sender, EventArgs e)
        {

            txtAlarm_Hour.Text = DateTime.Now.Hour.ToString();
            txtAlarm_min.Text = DateTime.Now.Minute.ToString();
        }

        private void timer_alarm_Tick(object sender, EventArgs e)
        {
            foreach (object item in chk_days.CheckedItems) {
                if (item.Equals(txtWeek.Text))
                {
                    if (txtAlarm_Hour.Text == txtHour.Text &&
                    txtAlarm_min.Text == txtMin.Text &&
                    txtAlarm_sec.Text == txtSec.Text
                    )
                    {
                        timer_alarm.Stop();
                        Popup popup = new Popup(txtAlarm_Hour.Text,txtAlarm_min.Text);
                        popup.Show();
                        Status.Visible = false;

                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer_alarm.Stop();
            Status.Visible = false;
        }
    }
}
