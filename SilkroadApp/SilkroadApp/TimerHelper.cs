using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SilkroadApp
{
    public class TimerHelper
    {
        public void KeyDownByTimer(int keyDownValue, string cmbSunucular, string txtKarakterAdi, Timer timer1, Timer timer2)
        {
            var sroClient = DllHelper.FindWindow(null, $"[{cmbSunucular}] {txtKarakterAdi}");

            if (sroClient != (IntPtr)0x00000000)
            {
                var sroClientTarget = DllHelper.FindWindowEx(sroClient, null, null, null);
                if (sroClientTarget != null)
                {
                    DllHelper.PostMessage(sroClientTarget, DllHelper.WM_KEYDOWN, keyDownValue, 0);
                }

            }
            else
            {
                StopTimer(timer1);
                StopTimer(timer2);
                MessageBox.Show("Client Bulunamadı");
            }
        }

        public void StopTimer(Timer timer)
        {
            timer.Stop();
        }
    }
}
