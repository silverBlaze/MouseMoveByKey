using System;
using System.Windows.Forms;

namespace MouseMoveByKey {
    public partial class MainForm : Form {

        private Timer checkKeyDown = null;
        
        public MainForm() {
            InitializeComponent();
        }
        
        private void MainForm_Load(object sender, EventArgs e) {
            //setup low level keyboard hook to detect keypresses
            KeyboardHelper.StartLowLevelHook();

            //start thread to check key-down flags
            checkKeyDown = new Timer();
            checkKeyDown.Interval = 5; //millisecond resolution for checking keydown state
            checkKeyDown.Tick += CheckKeyDown_Tick;
            checkKeyDown.Start();
        }

        private void CheckKeyDown_Tick(object sender, EventArgs e) {
            if(chkActivateLeftRight.Checked) {
                if(KeyboardHelper.LeftPressed) {
                    MouseHelper.MoveMouse(MoveDirection.Left, sliderSensitivity.Value);
                } else if(KeyboardHelper.RightPressed) {
                    MouseHelper.MoveMouse(MoveDirection.Right, sliderSensitivity.Value);
                } else if(KeyboardHelper.UpPressed) {
                    MouseHelper.MoveMouse(MoveDirection.Up, sliderSensitivity.Value);
                } else if(KeyboardHelper.DownPressed) {
                    MouseHelper.MoveMouse(MoveDirection.Down, sliderSensitivity.Value);
                }
            }
        }
        
        private void chkActivateLeftRight_CheckedChanged(object sender, EventArgs e) {
            sliderSensitivity.Enabled = (!chkActivateLeftRight.Checked);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {
            if(checkKeyDown != null)
                checkKeyDown.Dispose();
            KeyboardHelper.StopLowLevelHook();
        }
    }
}
