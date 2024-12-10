using System;
using System.Windows.Forms;

namespace NaufysWardrobeWinForms.Models
{
    public class GameTimer
    {
        private Timer timer;
        public int TimeLimit { get; set; }
        public int RemainingTime { get; set; }

        public event Action TimesUp;
        public event Action<int> Tick;

        public GameTimer(int timeLimit)
        {
            TimeLimit = timeLimit;
            RemainingTime = timeLimit;
            timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += OnTick;
        }

        private void OnTick(object sender, EventArgs e)
        {
            RemainingTime--;
            Tick?.Invoke(RemainingTime);
            if (RemainingTime <= 0)
            {
                StopTimer();
                TimesUp?.Invoke();
            }
        }

        public void StartTimer()
        {
            RemainingTime = TimeLimit;
            timer.Start();
        }

        public void StopTimer()
        {
            timer.Stop();
        }
    }
}
