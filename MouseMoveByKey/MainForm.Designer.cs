namespace MouseMoveByKey {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.sliderSensitivity = new System.Windows.Forms.TrackBar();
            this.lblSensitivity = new System.Windows.Forms.Label();
            this.chkActivateLeftRight = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSensitivity)).BeginInit();
            this.SuspendLayout();
            // 
            // sliderSensitivity
            // 
            this.sliderSensitivity.Enabled = false;
            this.sliderSensitivity.LargeChange = 15;
            this.sliderSensitivity.Location = new System.Drawing.Point(85, 146);
            this.sliderSensitivity.Maximum = 50;
            this.sliderSensitivity.Minimum = 1;
            this.sliderSensitivity.Name = "sliderSensitivity";
            this.sliderSensitivity.Size = new System.Drawing.Size(401, 56);
            this.sliderSensitivity.TabIndex = 0;
            this.sliderSensitivity.Value = 20;
            // 
            // lblSensitivity
            // 
            this.lblSensitivity.AutoSize = true;
            this.lblSensitivity.Location = new System.Drawing.Point(85, 123);
            this.lblSensitivity.Name = "lblSensitivity";
            this.lblSensitivity.Size = new System.Drawing.Size(399, 17);
            this.lblSensitivity.TabIndex = 1;
            this.lblSensitivity.Text = "Mouse-Move Sensitivity (De-activate above to enable change)";
            // 
            // chkActivateLeftRight
            // 
            this.chkActivateLeftRight.AutoSize = true;
            this.chkActivateLeftRight.Checked = true;
            this.chkActivateLeftRight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivateLeftRight.Location = new System.Drawing.Point(85, 49);
            this.chkActivateLeftRight.Name = "chkActivateLeftRight";
            this.chkActivateLeftRight.Size = new System.Drawing.Size(365, 21);
            this.chkActivateLeftRight.TabIndex = 2;
            this.chkActivateLeftRight.Text = "Activate Mouse-Move by Arrow Keys and PgUp/PgDn";
            this.chkActivateLeftRight.UseVisualStyleBackColor = true;
            this.chkActivateLeftRight.CheckedChanged += new System.EventHandler(this.chkActivateLeftRight_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 226);
            this.Controls.Add(this.chkActivateLeftRight);
            this.Controls.Add(this.lblSensitivity);
            this.Controls.Add(this.sliderSensitivity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MouseMove-By-Key";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sliderSensitivity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar sliderSensitivity;
        private System.Windows.Forms.Label lblSensitivity;
        private System.Windows.Forms.CheckBox chkActivateLeftRight;
    }
}

