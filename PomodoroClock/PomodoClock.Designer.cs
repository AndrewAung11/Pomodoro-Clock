
namespace PomodoroClock
{
    partial class PomodoClock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PomodoClock));
            this.timeLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Label();
            this.sessionLabel = new System.Windows.Forms.Label();
            this.breakLabel = new System.Windows.Forms.Label();
            this.sessionLength = new System.Windows.Forms.Label();
            this.breakLength = new System.Windows.Forms.Label();
            this.sessionInc = new System.Windows.Forms.Button();
            this.breakInc = new System.Windows.Forms.Button();
            this.sessionDec = new System.Windows.Forms.Button();
            this.breakDec = new System.Windows.Forms.Button();
            this.btn_sot = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(220, 25);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(203, 58);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "Session";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Font = new System.Drawing.Font("MS Reference Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer.Location = new System.Drawing.Point(253, 81);
            this.timer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(149, 52);
            this.timer.TabIndex = 1;
            this.timer.Text = "25:00";
            this.timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sessionLabel
            // 
            this.sessionLabel.AutoSize = true;
            this.sessionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionLabel.Location = new System.Drawing.Point(16, 172);
            this.sessionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sessionLabel.Name = "sessionLabel";
            this.sessionLabel.Size = new System.Drawing.Size(222, 36);
            this.sessionLabel.TabIndex = 2;
            this.sessionLabel.Text = "Session Length";
            // 
            // breakLabel
            // 
            this.breakLabel.AutoSize = true;
            this.breakLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakLabel.Location = new System.Drawing.Point(423, 172);
            this.breakLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.breakLabel.Name = "breakLabel";
            this.breakLabel.Size = new System.Drawing.Size(192, 36);
            this.breakLabel.TabIndex = 3;
            this.breakLabel.Text = "Break Length";
            // 
            // sessionLength
            // 
            this.sessionLength.AutoSize = true;
            this.sessionLength.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionLength.Location = new System.Drawing.Point(100, 208);
            this.sessionLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sessionLength.Name = "sessionLength";
            this.sessionLength.Size = new System.Drawing.Size(59, 43);
            this.sessionLength.TabIndex = 4;
            this.sessionLength.Text = "25";
            // 
            // breakLength
            // 
            this.breakLength.AutoSize = true;
            this.breakLength.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakLength.Location = new System.Drawing.Point(496, 208);
            this.breakLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.breakLength.Name = "breakLength";
            this.breakLength.Size = new System.Drawing.Size(59, 43);
            this.breakLength.TabIndex = 5;
            this.breakLength.Text = "05";
            // 
            // sessionInc
            // 
            this.sessionInc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionInc.Location = new System.Drawing.Point(45, 212);
            this.sessionInc.Margin = new System.Windows.Forms.Padding(4);
            this.sessionInc.Name = "sessionInc";
            this.sessionInc.Size = new System.Drawing.Size(47, 38);
            this.sessionInc.TabIndex = 6;
            this.sessionInc.Text = "+";
            this.sessionInc.UseVisualStyleBackColor = true;
            this.sessionInc.Click += new System.EventHandler(this.sessionInc_Click);
            // 
            // breakInc
            // 
            this.breakInc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakInc.Location = new System.Drawing.Point(441, 212);
            this.breakInc.Margin = new System.Windows.Forms.Padding(4);
            this.breakInc.Name = "breakInc";
            this.breakInc.Size = new System.Drawing.Size(47, 38);
            this.breakInc.TabIndex = 7;
            this.breakInc.Text = "+";
            this.breakInc.UseVisualStyleBackColor = true;
            this.breakInc.Click += new System.EventHandler(this.breakInc_Click);
            // 
            // sessionDec
            // 
            this.sessionDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionDec.Location = new System.Drawing.Point(171, 212);
            this.sessionDec.Margin = new System.Windows.Forms.Padding(4);
            this.sessionDec.Name = "sessionDec";
            this.sessionDec.Size = new System.Drawing.Size(47, 38);
            this.sessionDec.TabIndex = 8;
            this.sessionDec.Text = "-";
            this.sessionDec.UseVisualStyleBackColor = true;
            this.sessionDec.Click += new System.EventHandler(this.sessionDec_Click);
            // 
            // breakDec
            // 
            this.breakDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakDec.Location = new System.Drawing.Point(567, 212);
            this.breakDec.Margin = new System.Windows.Forms.Padding(4);
            this.breakDec.Name = "breakDec";
            this.breakDec.Size = new System.Drawing.Size(47, 38);
            this.breakDec.TabIndex = 9;
            this.breakDec.Text = "-";
            this.breakDec.UseVisualStyleBackColor = true;
            this.breakDec.Click += new System.EventHandler(this.breakDec_Click);
            // 
            // btn_sot
            // 
            this.btn_sot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sot.Location = new System.Drawing.Point(73, 369);
            this.btn_sot.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sot.Name = "btn_sot";
            this.btn_sot.Size = new System.Drawing.Size(213, 55);
            this.btn_sot.TabIndex = 10;
            this.btn_sot.Text = "Start / Pause";
            this.btn_sot.UseVisualStyleBackColor = true;
            this.btn_sot.Click += new System.EventHandler(this.btn_sot_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(363, 369);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(213, 55);
            this.btn_reset.TabIndex = 11;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // PomodoClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 558);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_sot);
            this.Controls.Add(this.breakDec);
            this.Controls.Add(this.sessionDec);
            this.Controls.Add(this.breakInc);
            this.Controls.Add(this.sessionInc);
            this.Controls.Add(this.breakLength);
            this.Controls.Add(this.sessionLength);
            this.Controls.Add(this.breakLabel);
            this.Controls.Add(this.sessionLabel);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.timeLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(661, 605);
            this.MinimumSize = new System.Drawing.Size(527, 481);
            this.Name = "PomodoClock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pomodoro Clock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PomodoClock_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.Label sessionLabel;
        private System.Windows.Forms.Label breakLabel;
        private System.Windows.Forms.Label sessionLength;
        private System.Windows.Forms.Label breakLength;
        private System.Windows.Forms.Button sessionInc;
        private System.Windows.Forms.Button breakInc;
        private System.Windows.Forms.Button sessionDec;
        private System.Windows.Forms.Button breakDec;
        private System.Windows.Forms.Button btn_sot;
        private System.Windows.Forms.Button btn_reset;
    }
}

