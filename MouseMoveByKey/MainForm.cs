using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace MouseMoveByKey {
    public partial class MainForm : Form {

        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x0101;
        private const uint MOUSEEVENTF_MOVE = 0x0001;

        private static LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;
        private Timer checkKeyDown = null;
        
        public MainForm() {
            InitializeComponent();
        }

        private static bool _leftPressed = false;
        private static bool _rightPressed = false;
        private static bool _upPressed = false;
        private static bool _downPressed = false;
        private int _moveFactor = 2;
        
        private void MainForm_Load(object sender, EventArgs e) {
            //setup low level keyboard hook to detect keypresses
            _hookID = SetHook(_proc);

            //start thread to check key-down flags
            checkKeyDown = new Timer();
            checkKeyDown.Interval = 5; //millisecond resolution for checking keydown state
            checkKeyDown.Tick += CheckKeyDown_Tick;
            checkKeyDown.Start();
        }

        private void CheckKeyDown_Tick(object sender, EventArgs e) {
            if(chkActivateLeftRight.Checked) {
                if(_leftPressed) {
                    mouse_event(MOUSEEVENTF_MOVE, -1 * _moveFactor * sliderSensitivity.Value, 0, 0, (UIntPtr)0);
                } else if(_rightPressed) {
                    mouse_event(MOUSEEVENTF_MOVE, 1 * _moveFactor * sliderSensitivity.Value, 0, 0, (UIntPtr)0);
                } else if(_upPressed) {
                    mouse_event(MOUSEEVENTF_MOVE, 0, -1 * _moveFactor * sliderSensitivity.Value, 0, (UIntPtr)0);
                } else if(_downPressed) {
                    mouse_event(MOUSEEVENTF_MOVE, 0, 1 * _moveFactor * sliderSensitivity.Value, 0, (UIntPtr)0);
                }
            }
        }
        
        private void chkActivateLeftRight_CheckedChanged(object sender, EventArgs e) {
            sliderSensitivity.Enabled = (!chkActivateLeftRight.Checked);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {
            if(checkKeyDown != null)
                checkKeyDown.Dispose();
            UnhookWindowsHookEx(_hookID);
        }

        private static IntPtr SetHook(LowLevelKeyboardProc proc) {
            using(Process curProcess = Process.GetCurrentProcess()) {
                using(ProcessModule curModule = curProcess.MainModule) {
                    return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
                }
            }
        }

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam) {
            if(nCode >= 0) {
                int vkCode = Marshal.ReadInt32(lParam);
                if(wParam == (IntPtr)WM_KEYDOWN) {
                    _leftPressed = ((Keys)vkCode == Keys.Left);
                    _rightPressed = ((Keys)vkCode == Keys.Right);
                    _upPressed = ((Keys)vkCode == Keys.PageUp);
                    _downPressed = ((Keys)vkCode == Keys.PageDown);
                } else if(wParam == (IntPtr)WM_KEYUP) {
                    if((Keys)vkCode == Keys.Left) {
                        _leftPressed = false;
                    } else if((Keys)vkCode == Keys.Right) {
                        _rightPressed = false;
                    } else if((Keys)vkCode == Keys.PageUp) {
                        _upPressed = false;
                    } else if((Keys)vkCode == Keys.PageDown) {
                        _downPressed = false;
                    }
                }
            }

            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }
        
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, UIntPtr dwExtraInfo);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        private void sliderSensitivity_Scroll(object sender, EventArgs e) {

        }
    }
}
