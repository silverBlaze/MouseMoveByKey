﻿using System;
using System.Windows.Forms;

namespace MouseMoveByKey {
    public partial class MainForm : Form {

        private Timer checkKeyDown = null;

        public MainForm() {
            InitializeComponent();
        }
        
        private void MainForm_Load(object sender, EventArgs e) {
            //load the key bindings from the current JSON config, if any
            KeyboardHelper.CurrentKeyBindings = ConfigHelper.LoadKeyBindingsFromConfig();

            //load mouse settings from current JSON config, if any
            var mouseSettings = ConfigHelper.LoadMouseSettingsFromConfig();
            sliderSensitivity.Value = mouseSettings.Sensitivity;

            //setup low level keyboard hook to detect keypresses
            KeyboardHelper.StartLowLevelHook();

            //start thread to check key-down flags
            checkKeyDown = new Timer();
            checkKeyDown.Interval = 5; //millisecond resolution for checking keydown state
            checkKeyDown.Tick += CheckKeyDown_Tick;
            checkKeyDown.Start();
        }

        private void CheckKeyDown_Tick(object sender, EventArgs e) {
            if(chkActivate.Checked) {
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
        
        private void chkActivate_CheckedChanged(object sender, EventArgs e) {
            sliderSensitivity.Enabled = (!chkActivate.Checked);
            btnEditKeyBindings.Enabled = (!chkActivate.Checked);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {
            if(checkKeyDown != null)
                checkKeyDown.Dispose();
            KeyboardHelper.StopLowLevelHook();
        }

        private void btnEditKeyBindings_Click(object sender, EventArgs e) {
            using(var keyDialog = new KeyBindingForm()) {
                keyDialog.KeyBindings = KeyboardHelper.CurrentKeyBindings;
                keyDialog.ShowDialog();
                KeyboardHelper.CurrentKeyBindings = keyDialog.KeyBindings;
                //save the config file with the new bindings
                ConfigHelper.SaveKeyBindingsToConfig(KeyboardHelper.CurrentKeyBindings);
            }
        }

        private void sliderSensitivity_Scroll(object sender, EventArgs e) {
            ConfigHelper.SaveMouseSettingsToConfig(new MouseSettings { Sensitivity = sliderSensitivity.Value });
        }
    }
}
