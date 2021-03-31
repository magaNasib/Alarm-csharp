using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace AlarmAdvanced
{
    public partial class Popup : Form
    {
        string txt_sent_hour = "";
        string txt_sent_min = "";
        public Popup(string txt_alarm_hour, string txt_alarm_min)
        {
            this.txt_sent_hour = txt_alarm_hour;
            this.txt_sent_min = txt_alarm_min;
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
            SoundPlayer player = new SoundPlayer(@"mixkit.wav");
            player.Stop();

        }

        private void Popup_Load(object sender, EventArgs e)
        {
            txtAlarm_Hour.Text = txt_sent_hour;
            txtAlarm_min.Text = txt_sent_min;
            SoundPlayer player = new SoundPlayer(@"mixkit.wav");
            player.Play();
        }
    }
}
