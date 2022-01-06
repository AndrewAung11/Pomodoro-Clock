using System;
using System.IO;
using System.Timers;
using System.Windows.Forms;

namespace PomodoroClock
{
    public partial class PomodoClock : Form
    {
        public PomodoClock()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private System.Timers.Timer interval;
        private int[] lengths = {25, 5};
        System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer($@"{Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString())}\BeepSound.wav");

        // Session length
        // Increase button
        private void sessionInc_Click(object sender, EventArgs e)
        {
            if (timeLabel.Text != "Session" || interval == null || interval.Enabled == false)
            {
                if (lengths[0] < 60)
                {
                    lengths[0] = lengths[0] + 1;
                }

                if (lengths[0] < 10)
                {
                    sessionLength.Text = $"0{lengths[0]}";
                }
                else
                {
                    sessionLength.Text = lengths[0].ToString();
                }

                if (timeLabel.Text == "Session")
                {
                    if (lengths[0] < 10)
                    {
                        timer.Text = $"0{lengths[0]}:00";
                    }
                    else
                    {
                        timer.Text = $"{lengths[0]}:00";
                    }
                }
            }
        }

        // Decrease button
        private void sessionDec_Click(object sender, EventArgs e)
        {
            if (timeLabel.Text != "Session" || interval == null || interval.Enabled == false)
            {
                if (lengths[0] > 1)
                {
                    lengths[0] = lengths[0] - 1;
                }

                if (lengths[0] < 10)
                {
                    sessionLength.Text = $"0{lengths[0]}";
                }
                else
                {
                    sessionLength.Text = lengths[0].ToString();
                }

                if (timeLabel.Text == "Session")
                {
                    if (lengths[0] < 10)
                    {
                        timer.Text = $"0{lengths[0]}:00";
                    } else
                    {
                        timer.Text = $"{lengths[0]}:00";
                    }
                }
            }
        }

        // Break Length
        // Increase button
        private void breakInc_Click(object sender, EventArgs e)
        {
            if (timeLabel.Text != "Break" || interval == null || interval.Enabled == false)
            {
                if (lengths[1] < 60)
                {
                    lengths[1] = lengths[1] + 1;
                }

                if (lengths[1] < 10)
                {
                    breakLength.Text = $"0{lengths[1]}";
                }
                else
                {
                    breakLength.Text = lengths[1].ToString();
                }

                if (timeLabel.Text == "Break")
                {
                    if (lengths[1] < 10)
                    {
                        timer.Text = $"0{lengths[1]}:00";
                    }
                    else
                    {
                        timer.Text = $"{lengths[1]}:00";
                    }
                }
            }
        }

        // Decrease button
        private void breakDec_Click(object sender, EventArgs e)
        {
            if (timeLabel.Text != "Break" || interval == null || interval.Enabled == false)
            {
                if (lengths[1] > 1)
                {
                    lengths[1] = lengths[1] - 1;
                }

                if (lengths[1] < 10)
                {
                    breakLength.Text = $"0{lengths[1]}";
                }
                else
                {
                    breakLength.Text = lengths[1].ToString();
                }

                if (timeLabel.Text == "Break")
                {
                    if (lengths[1] < 10)
                    {
                        timer.Text = $"0{lengths[1]}:00";
                    } else
                    {
                        timer.Text = $"{lengths[1]}:00";
                    }
                }
            }
        }

        // Start/Pause button
        private void btn_sot_Click(object sender, EventArgs e)
        {
            if (interval == null)
            {
                interval = new System.Timers.Timer(1000);
                interval.Elapsed += OnTimeEvent;
                interval.AutoReset = true;
            }
            if (interval.Enabled == true)
            {
                interval.Enabled = false;
            } else
            {
                interval.Enabled = true;
            }
        }

        // Counting
        private int min = 0;
        private int sec = 0;
        private int fired = 0;

        // Reset button
        private void btn_reset_Click(object sender, EventArgs e)
        {
            interval.Enabled = false;
            lengths[0] = 25;
            lengths[1] = 5;
            sessionLength.Text = lengths[0].ToString();
            breakLength.Text = $"0{lengths[1]}";
            timeLabel.Text = "Session";
            timer.Text = $"{lengths[0]}:00";
            min = 0;
            sec = 0;
            fired = 0;
        }

        // Interval
        private void OnTimeEvent(Object source, ElapsedEventArgs e)
        {
            if (fired == 0 && (min == 0 && sec == 0))
            {
                if (timeLabel.Text == "Session")
                {
                    min = lengths[0];
                }
                if (timeLabel.Text == "Break")
                {
                    min = lengths[0];
                }
            }
            if (sec == 0 && min > 0)
            {
                min = min - 1;
                sec = sec + 60;
            }

            if (sec > 0)
            {
                sec--;
            }

            // Formatting
            if (min < 10 || sec < 10)
            {
                string minStr = min.ToString();
                string secStr = sec.ToString();
                if (min < 10)
                {
                    minStr = $"0{min}";
                }
                if (sec < 10)
                {
                    secStr = $"0{sec}";
                }
                Invoke(new Action(() => { timer.Text = $"{minStr}:{secStr}"; }));
            }

            // Time change
            fired++;
            if (timeLabel.Text == "Session" && fired == (lengths[0] * 60) && sec == 0)
            {
                fired = 0;
                Invoke(new Action(() => { timeLabel.Text = "Break"; timeLabel.SetBounds(189, 20, 124, 46); }));
                soundPlayer.Play();
            } else if (timeLabel.Text == "Break" && fired == (lengths[1] * 60) && sec == 0)
            {
                fired = 0;
                Invoke(new Action(() => { timeLabel.Text = "Session"; timeLabel.SetBounds(165, 20, 163, 46); }));
                soundPlayer.Play();
            }
        }
    }
}
