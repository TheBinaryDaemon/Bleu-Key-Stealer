using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BKS_GUI
{
    class Drag
    {
        //Drag Class By BinaryDaemon

        //Dll imports
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public void MoveForm(IntPtr HND)
        {
            ReleaseCapture();
            SendMessage(HND, 0xA1, 0x2, 0);
        }
    }
}
