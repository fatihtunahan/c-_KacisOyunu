using System;
using System.Windows.Forms;

namespace NDP_Proje_Kacis_Oyunu
{
    public class SaniyeSayaci
    {
        private int saniye;
        private Timer timer;

        public event EventHandler SaniyeDegisti;

        public SaniyeSayaci()
        {
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            saniye++;
            OnSaniyeDegisti();
        }

        protected virtual void OnSaniyeDegisti()
        {
            SaniyeDegisti?.Invoke(this, EventArgs.Empty);
        }

        public void StopTimer()
        {
            timer.Stop();
        }

        public int GetSaniye()
        {
            return saniye;
        }
    }

}
