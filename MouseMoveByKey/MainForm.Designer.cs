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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sliderSensitivity = new System.Windows.Forms.TrackBar();
            this.lblSensitivity = new System.Windows.Forms.Label();
            this.chkActivate = new System.Windows.Forms.CheckBox();
            this.btnEditKeyBindings = new System.Windows.Forms.Button();
            this.groupSettings = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSensitivity)).BeginInit();
            this.groupSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // sliderSensitivity
            // 
            this.sliderSensitivity.Enabled = false;
            this.sliderSensitivity.LargeChange = 15;
            this.sliderSensitivity.Location = new System.Drawing.Point(103, 98);
            this.sliderSensitivity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sliderSensitivity.Maximum = 50;
            this.sliderSensitivity.Minimum = 1;
            this.sliderSensitivity.Name = "sliderSensitivity";
            this.sliderSensitivity.Size = new System.Drawing.Size(602, 90);
            this.sliderSensitivity.TabIndex = 0;
            this.sliderSensitivity.Value = 20;
            this.sliderSensitivity.Scroll += new System.EventHandler(this.sliderSensitivity_Scroll);
            // 
            // lblSensitivity
            // 
            this.lblSensitivity.AutoSize = true;
            this.lblSensitivity.Location = new System.Drawing.Point(103, 62);
            this.lblSensitivity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSensitivity.Name = "lblSensitivity";
            this.lblSensitivity.Size = new System.Drawing.Size(241, 25);
            this.lblSensitivity.TabIndex = 1;
            this.lblSensitivity.Text = "Mouse-Move Sensitivity";
            // 
            // chkActivate
            // 
            this.chkActivate.AutoSize = true;
            this.chkActivate.Checked = true;
            this.chkActivate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivate.Location = new System.Drawing.Point(245, 61);
            this.chkActivate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkActivate.Name = "chkActivate";
            this.chkActivate.Size = new System.Drawing.Size(335, 29);
            this.chkActivate.TabIndex = 2;
            this.chkActivate.Text = "Activate Mouse-Move by Keys";
            this.chkActivate.UseVisualStyleBackColor = true;
            this.chkActivate.CheckedChanged += new System.EventHandler(this.chkActivate_CheckedChanged);
            // 
            // btnEditKeyBindings
            // 
            this.btnEditKeyBindings.Enabled = false;
            this.btnEditKeyBindings.Location = new System.Drawing.Point(103, 182);
            this.btnEditKeyBindings.Name = "btnEditKeyBindings";
            this.btnEditKeyBindings.Size = new System.Drawing.Size(602, 80);
            this.btnEditKeyBindings.TabIndex = 3;
            this.btnEditKeyBindings.Text = "Edit Keybindings";
            this.btnEditKeyBindings.UseVisualStyleBackColor = true;
            this.btnEditKeyBindings.Click += new System.EventHandler(this.btnEditKeyBindings_Click);
            // 
            // groupSettings
            // 
            this.groupSettings.Controls.Add(this.btnEditKeyBindings);
            this.groupSettings.Controls.Add(this.sliderSensitivity);
            this.groupSettings.Controls.Add(this.lblSensitivity);
            this.groupSettings.Location = new System.Drawing.Point(12, 130);
            this.groupSettings.Name = "groupSettings";
            this.groupSettings.Size = new System.Drawing.Size(800, 303);
            this.groupSettings.TabIndex = 4;
            this.groupSettings.TabStop = false;
            this.groupSettings.Text = "Settings (De-activate above to enable changes)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 453);
            this.Controls.Add(this.groupSettings);
            this.Controls.Add(this.chkActivate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MouseMove-By-Key";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sliderSensitivity)).EndInit();
            this.groupSettings.ResumeLayout(false);
            this.groupSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar sliderSensitivity;
        private System.Windows.Forms.Label lblSensitivity;
        private System.Windows.Forms.CheckBox chkActivate;
        private System.Windows.Forms.Button btnEditKeyBindings;
        private System.Windows.Forms.GroupBox groupSettings;
    }
}

