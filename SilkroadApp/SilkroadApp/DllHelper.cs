using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SilkroadApp
{
    public static class DllHelper
    {
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        public static extern bool PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);
        public const Int32 WM_KEYDOWN = 0x0100;
        public const Int32 VK_1 = 0x31;
        public const Int32 VK_2 = 0x32;

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindowEx(IntPtr hWnd, string lpClassName, string lpWindowName, string lParam);

        //Deneme

    }
}
