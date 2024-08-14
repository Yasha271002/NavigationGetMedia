using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using NavifationGetMedia.Utilities;

namespace NavifationGetMedia.Helpers
{
    public class BaseInactivityHelper
    {
        public BaseInactivityHelper(int waitTime)
        {
            _inactivityTime = waitTime;
            _timer.Tick += TimerOnTick;
            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Start();
        }

        private readonly int _inactivityTime;
        private readonly DispatcherTimer _timer = new();
        public event InactivityEvent? OnInactivity;
        public delegate void InactivityEvent(int inactivityTime);

        private void TimerOnTick(object sender, EventArgs e)
        {
            if (UserInactivity.GetSeconds() < _inactivityTime || UserInactivity.GetSeconds() > _inactivityTime) return;
            OnInactivity?.Invoke(UserInactivity.GetSeconds());
        }
    }
}
