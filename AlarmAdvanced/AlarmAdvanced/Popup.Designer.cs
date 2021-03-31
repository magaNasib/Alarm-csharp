
namespace AlarmAdvanced
{
    partial class Popup
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
            this.gb = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.periods = new System.Windows.Forms.Label();
            this.txtAlarm_min = new System.Windows.Forms.TextBox();
            this.txtAlarm_Hour = new System.Windows.Forms.TextBox();
            this.gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb
            // 
            this.gb.BackColor = System.Drawing.Color.Transparent;
            this.gb.Controls.Add(this.label1);
            this.gb.Controls.Add(this.btn_ok);
            this.gb.Controls.Add(this.periods);
            this.gb.Controls.Add(this.txtAlarm_min);
            this.gb.Controls.Add(this.txtAlarm_Hour);
            this.gb.Location = new System.Drawing.Point(1, -4);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(361, 224);
            this.gb.TabIndex = 18;
            this.gb.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(128, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Alarm!";
            // 
            // btn_ok
            // 
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ok.Location = new System.Drawing.Point(133, 162);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(84, 36);
            this.btn_ok.TabIndex = 21;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // periods
            // 
            this.periods.AutoSize = true;
            this.periods.BackColor = System.Drawing.Color.Black;
            this.periods.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.periods.Font = new System.Drawing.Font("Complex", 21.75F);
            this.periods.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.periods.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.periods.Location = new System.Drawing.Point(163, 85);
            this.periods.Name = "periods";
            this.periods.Size = new System.Drawing.Size(34, 42);
            this.periods.TabIndex = 20;
            this.periods.Text = ":";
            this.periods.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtAlarm_min
            // 
            this.txtAlarm_min.BackColor = System.Drawing.Color.Black;
            this.txtAlarm_min.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAlarm_min.Font = new System.Drawing.Font("AIGDT", 21.75F);
            this.txtAlarm_min.ForeColor = System.Drawing.Color.White;
            this.txtAlarm_min.Location = new System.Drawing.Point(203, 81);
            this.txtAlarm_min.Name = "txtAlarm_min";
            this.txtAlarm_min.ReadOnly = true;
            this.txtAlarm_min.Size = new System.Drawing.Size(53, 46);
            this.txtAlarm_min.TabIndex = 19;
            this.txtAlarm_min.Text = "00";
            this.txtAlarm_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAlarm_Hour
            // 
            this.txtAlarm_Hour.BackColor = System.Drawing.Color.Black;
            this.txtAlarm_Hour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAlarm_Hour.Font = new System.Drawing.Font("AIGDT", 21.75F);
            this.txtAlarm_Hour.ForeColor = System.Drawing.Color.White;
            this.txtAlarm_Hour.Location = new System.Drawing.Point(104, 81);
            this.txtAlarm_Hour.Name = "txtAlarm_Hour";
            this.txtAlarm_Hour.ReadOnly = true;
            this.txtAlarm_Hour.Size = new System.Drawing.Size(53, 46);
            this.txtAlarm_Hour.TabIndex = 18;
            this.txtAlarm_Hour.Text = "00";
            this.txtAlarm_Hour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(363, 221);
            this.Controls.Add(this.gb);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(363, 221);
            this.MinimumSize = new System.Drawing.Size(363, 221);
            this.Name = "Popup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popup";
            this.Load += new System.EventHandler(this.Popup_Load);
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label periods;
        private System.Windows.Forms.TextBox txtAlarm_min;
        private System.Windows.Forms.TextBox txtAlarm_Hour;
    }
}