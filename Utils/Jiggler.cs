
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace MouseJiggler2021.Utils
{
    public static class Jiggler
    {
        internal const int INPUT_MOUSE = 0;
        internal const int MOUSEEVENTF_MOVE = 0x0001;

        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint SendInput(uint nInputs, ref INPUT pInputs, int cbSize);

        public static void Jiggle(int dx, int dy)
        {
            var inp = new INPUT
            {
                TYPE = Jiggler.INPUT_MOUSE,
                dx = dx,
                dy = dy,
                mouseData = 0,
                dwFlags = Jiggler.MOUSEEVENTF_MOVE,
                time = 0,
                dwExtraInfo = (IntPtr)0
            };

            var retval = SendInput(1, ref inp, Marshal.SizeOf(inp));

            if (retval != 1)
            {
                var errcode = Marshal.GetLastWin32Error();
                Debugger.Log(1, "Jiggle", $"failed to insert event to input stream; retval={retval}, errcode={errcode:x}");
            }
        }
    }

    internal struct INPUT
    {
        public int TYPE;
        public int dx;
        public int dy;
        public int mouseData;
        public int dwFlags;
        public int time;
        public IntPtr dwExtraInfo;
    }
}
