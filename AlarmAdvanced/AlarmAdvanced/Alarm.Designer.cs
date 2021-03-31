
namespace AlarmAdvanced
{
    partial class Alarm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alarm));
            this.Date__time = new System.Windows.Forms.GroupBox();
            this.txtWeek = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblper = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.txtSec = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Status = new System.Windows.Forms.Label();
            this.txtAlarm_Hour = new System.Windows.Forms.TextBox();
            this.btn_set = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.chk_days = new System.Windows.Forms.CheckedListBox();
            this.txtAlarm_min = new System.Windows.Forms.TextBox();
            this.periods = new System.Windows.Forms.Label();
            this.timer_alarm = new System.Windows.Forms.Timer(this.components);
            this.txtAlarm_sec = new System.Windows.Forms.TextBox();
            this.points = new System.Windows.Forms.Label();
            this.Date__time.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Date__time
            // 
            this.Date__time.BackColor = System.Drawing.Color.Transparent;
            this.Date__time.Controls.Add(this.txtWeek);
            this.Date__time.Controls.Add(this.txtDate);
            this.Date__time.Controls.Add(this.lblper);
            this.Date__time.Controls.Add(this.lbl);
            this.Date__time.Controls.Add(this.txtSec);
            this.Date__time.Controls.Add(this.txtMin);
            this.Date__time.Controls.Add(this.txtHour);
            resources.ApplyResources(this.Date__time, "Date__time");
            this.Date__time.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Date__time.Name = "Date__time";
            this.Date__time.TabStop = false;
            // 
            // txtWeek
            // 
            this.txtWeek.BackColor = System.Drawing.Color.Black;
            this.txtWeek.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtWeek, "txtWeek");
            this.txtWeek.ForeColor = System.Drawing.Color.White;
            this.txtWeek.Name = "txtWeek";
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.Black;
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtDate, "txtDate");
            this.txtDate.ForeColor = System.Drawing.Color.White;
            this.txtDate.Name = "txtDate";
            // 
            // lblper
            // 
            resources.ApplyResources(this.lblper, "lblper");
            this.lblper.BackColor = System.Drawing.Color.Black;
            this.lblper.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblper.Name = "lblper";
            // 
            // lbl
            // 
            resources.ApplyResources(this.lbl, "lbl");
            this.lbl.BackColor = System.Drawing.Color.Black;
            this.lbl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl.Name = "lbl";
            // 
            // txtSec
            // 
            this.txtSec.BackColor = System.Drawing.Color.Black;
            this.txtSec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtSec, "txtSec");
            this.txtSec.ForeColor = System.Drawing.Color.White;
            this.txtSec.Name = "txtSec";
            this.txtSec.ReadOnly = true;
            // 
            // txtMin
            // 
            this.txtMin.BackColor = System.Drawing.Color.Black;
            this.txtMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtMin, "txtMin");
            this.txtMin.ForeColor = System.Drawing.Color.White;
            this.txtMin.Name = "txtMin";
            this.txtMin.ReadOnly = true;
            // 
            // txtHour
            // 
            this.txtHour.BackColor = System.Drawing.Color.Black;
            this.txtHour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtHour, "txtHour");
            this.txtHour.ForeColor = System.Drawing.Color.White;
            this.txtHour.Name = "txtHour";
            this.txtHour.ReadOnly = true;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAlarm_sec);
            this.groupBox1.Controls.Add(this.points);
            this.groupBox1.Controls.Add(this.Status);
            this.groupBox1.Controls.Add(this.txtAlarm_Hour);
            this.groupBox1.Controls.Add(this.btn_set);
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.chk_days);
            this.groupBox1.Controls.Add(this.txtAlarm_min);
            this.groupBox1.Controls.Add(this.periods);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // Status
            // 
            resources.ApplyResources(this.Status, "Status");
            this.Status.ForeColor = System.Drawing.Color.Lime;
            this.Status.Name = "Status";
            // 
            // txtAlarm_Hour
            // 
            this.txtAlarm_Hour.BackColor = System.Drawing.Color.Black;
            this.txtAlarm_Hour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtAlarm_Hour, "txtAlarm_Hour");
            this.txtAlarm_Hour.ForeColor = System.Drawing.Color.White;
            this.txtAlarm_Hour.Name = "txtAlarm_Hour";
            this.txtAlarm_Hour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlarm_Hour_KeyPress);
            // 
            // btn_set
            // 
            this.btn_set.BackColor = System.Drawing.Color.Green;
            resources.ApplyResources(this.btn_set, "btn_set");
            this.btn_set.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_set.Name = "btn_set";
            this.btn_set.UseVisualStyleBackColor = false;
            this.btn_set.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.btn_cancel, "btn_cancel");
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // chk_days
            // 
            this.chk_days.BackColor = System.Drawing.SystemColors.WindowText;
            this.chk_days.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chk_days.ForeColor = System.Drawing.Color.White;
            this.chk_days.FormattingEnabled = true;
            this.chk_days.Items.AddRange(new object[] {
            resources.GetString("chk_days.Items"),
            resources.GetString("chk_days.Items1"),
            resources.GetString("chk_days.Items2"),
            resources.GetString("chk_days.Items3"),
            resources.GetString("chk_days.Items4"),
            resources.GetString("chk_days.Items5"),
            resources.GetString("chk_days.Items6")});
            resources.ApplyResources(this.chk_days, "chk_days");
            this.chk_days.Name = "chk_days";
            // 
            // txtAlarm_min
            // 
            this.txtAlarm_min.BackColor = System.Drawing.Color.Black;
            this.txtAlarm_min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtAlarm_min, "txtAlarm_min");
            this.txtAlarm_min.ForeColor = System.Drawing.Color.White;
            this.txtAlarm_min.Name = "txtAlarm_min";
            this.txtAlarm_min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlarm_min_KeyPress);
            // 
            // periods
            // 
            resources.ApplyResources(this.periods, "periods");
            this.periods.BackColor = System.Drawing.Color.Black;
            this.periods.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.periods.Name = "periods";
            // 
            // timer_alarm
            // 
            this.timer_alarm.Interval = 1000;
            this.timer_alarm.Tick += new System.EventHandler(this.timer_alarm_Tick);
            // 
            // txtAlarm_sec
            // 
            this.txtAlarm_sec.BackColor = System.Drawing.Color.Black;
            this.txtAlarm_sec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtAlarm_sec, "txtAlarm_sec");
            this.txtAlarm_sec.ForeColor = System.Drawing.Color.White;
            this.txtAlarm_sec.Name = "txtAlarm_sec";
            this.txtAlarm_sec.Tag = "00";
            // 
            // points
            // 
            resources.ApplyResources(this.points, "points");
            this.points.BackColor = System.Drawing.Color.Black;
            this.points.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.points.Name = "points";
            // 
            // Alarm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Date__time);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Alarm";
            this.Load += new System.EventHandler(this.Alarm_Load);
            this.Date__time.ResumeLayout(false);
            this.Date__time.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Date__time;
        private System.Windows.Forms.TextBox txtSec;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.Label lblper;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtWeek;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox chk_days;
        private System.Windows.Forms.TextBox txtAlarm_min;
        private System.Windows.Forms.Label periods;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txtAlarm_Hour;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Timer timer_alarm;
        private System.Windows.Forms.TextBox txtAlarm_sec;
        private System.Windows.Forms.Label points;
    }
}

