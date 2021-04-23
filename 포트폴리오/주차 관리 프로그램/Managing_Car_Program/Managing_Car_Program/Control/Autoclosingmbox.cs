using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managing_Car_Program.Control
{
    class Autoclosingmbox
    {
        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]

        static extern IntPtr FindWindow(string IpClassName, string IpWindowName);
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);

        System.Threading.Timer timeoutTimer; // 쓰레드 타이머
        string captions;

        const int WM_CLOSE = 0x0010; // close 명령

        Autoclosingmbox(string text, string caption, int timeout)
        {
            captions = caption;
            timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
                null, timeout, System.Threading.Timeout.Infinite);
            System.Windows.Forms.MessageBox.Show(text, caption);
        }

        // 생성자 함수
        public static void showmbox(string text, string caption, int timeout)
        {
            new Autoclosingmbox(text, caption, timeout);
        }

        // 타이머 발동시 close메세지 출력
        void OnTimerElapsed(object state)
        {
            IntPtr mb = FindWindow(null, captions);
            if (mb != IntPtr.Zero)
            {
                SendMessage(mb, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                timeoutTimer.Dispose();
            }

            // https://naakjii.tistory.com/14
            // https://dotnetdev07.tistory.com/3
        }
    }
}
