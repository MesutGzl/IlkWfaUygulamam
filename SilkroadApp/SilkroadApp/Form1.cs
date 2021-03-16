using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SilkroadApp
{
    public partial class Form1 : Form
    {
        public TimerHelper _timerHelper;
        public Form1()
        {
            InitializeComponent();
            _timerHelper = new TimerHelper();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _timerHelper.KeyDownByTimer(DllHelper.VK_1, cmbSunucular.Text, txtKarakterAdi.Text, timer1, timer2);
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            _timerHelper.KeyDownByTimer(DllHelper.VK_2, cmbSunucular.Text, txtKarakterAdi.Text, timer1, timer2);
        }
        private void btnDurdur_Click(object sender, EventArgs e)
        {
            _timerHelper.StopTimer(timer1);
            _timerHelper.StopTimer(timer2);
        }
    }
}
