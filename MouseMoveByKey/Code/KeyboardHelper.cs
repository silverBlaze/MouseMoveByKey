using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MouseMoveByKey {
    public class KeyboardHelper {

        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x0101;

        public static bool LeftPressed { get; set; } = false;
        public static bool RightPressed { get; set; } = false;
        public static bool UpPressed { get; set; } = false;
        public static bool DownPressed { get; set; } = false;

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private static LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;

        public static void StartLowLevelHook() {
            _hookID = SetHook(_proc);
        }

        public static void StopLowLevelHook() {
            UnhookWindowsHookEx(_hookID);
        }

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam) {
            if(nCode >= 0) {
                int vkCode = Marshal.ReadInt32(lParam);
                if(wParam == (IntPtr)WM_KEYDOWN) {
                    LeftPressed = ((Keys)vkCode == Keys.Left);
                    RightPressed = ((Keys)vkCode == Keys.Right);
                    UpPressed = ((Keys)vkCode == Keys.PageUp);
                    DownPressed = ((Keys)vkCode == Keys.PageDown);
                } else if(wParam == (IntPtr)WM_KEYUP) {
                    if((Keys)vkCode == Keys.Left) {
                        LeftPressed = false;
                    } else if((Keys)vkCode == Keys.Right) {
                        RightPressed = false;
                    } else if((Keys)vkCode == Keys.PageUp) {
                        UpPressed = false;
                    } else if((Keys)vkCode == Keys.PageDown) {
                        DownPressed = false;
                    }
                }
            }

            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        private static IntPtr SetHook(LowLevelKeyboardProc proc) {
            using(Process curProcess = Process.GetCurrentProcess()) {
                using(ProcessModule curModule = curProcess.MainModule) {
                    return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
                }
            }
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

    }
}
