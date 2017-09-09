namespace MouseMoveByKey {
    partial class KeyBindingForm {
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
            this.groupUpKeys = new System.Windows.Forms.GroupBox();
            this.btnClearUpKeys = new System.Windows.Forms.Button();
            this.btnAddUpKey = new System.Windows.Forms.Button();
            this.listUpKeys = new System.Windows.Forms.ListBox();
            this.groupDownKeys = new System.Windows.Forms.GroupBox();
            this.btnClearDownKeys = new System.Windows.Forms.Button();
            this.btnAddDownKeys = new System.Windows.Forms.Button();
            this.listDownKeys = new System.Windows.Forms.ListBox();
            this.groupRightKeys = new System.Windows.Forms.GroupBox();
            this.btnClearRightKeys = new System.Windows.Forms.Button();
            this.btnAddRightKey = new System.Windows.Forms.Button();
            this.listRightKeys = new System.Windows.Forms.ListBox();
            this.groupLeftKeys = new System.Windows.Forms.GroupBox();
            this.btnClearLeftKeys = new System.Windows.Forms.Button();
            this.btnAddLeftKey = new System.Windows.Forms.Button();
            this.listLeftKeys = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.groupUpKeys.SuspendLayout();
            this.groupDownKeys.SuspendLayout();
            this.groupRightKeys.SuspendLayout();
            this.groupLeftKeys.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupUpKeys
            // 
            this.groupUpKeys.Controls.Add(this.btnClearUpKeys);
            this.groupUpKeys.Controls.Add(this.btnAddUpKey);
            this.groupUpKeys.Controls.Add(this.listUpKeys);
            this.groupUpKeys.Location = new System.Drawing.Point(12, 108);
            this.groupUpKeys.Name = "groupUpKeys";
            this.groupUpKeys.Size = new System.Drawing.Size(428, 186);
            this.groupUpKeys.TabIndex = 0;
            this.groupUpKeys.TabStop = false;
            this.groupUpKeys.Text = "Move Mouse UP Keys";
            // 
            // btnClearUpKeys
            // 
            this.btnClearUpKeys.Location = new System.Drawing.Point(271, 105);
            this.btnClearUpKeys.Name = "btnClearUpKeys";
            this.btnClearUpKeys.Size = new System.Drawing.Size(151, 60);
            this.btnClearUpKeys.TabIndex = 1;
            this.btnClearUpKeys.Text = "Clear Keys";
            this.btnClearUpKeys.UseVisualStyleBackColor = true;
            // 
            // btnAddUpKey
            // 
            this.btnAddUpKey.Location = new System.Drawing.Point(271, 39);
            this.btnAddUpKey.Name = "btnAddUpKey";
            this.btnAddUpKey.Size = new System.Drawing.Size(151, 60);
            this.btnAddUpKey.TabIndex = 1;
            this.btnAddUpKey.Text = "Add Key";
            this.btnAddUpKey.UseVisualStyleBackColor = true;
            this.btnAddUpKey.Click += new System.EventHandler(this.btnAddUpKey_Click);
            // 
            // listUpKeys
            // 
            this.listUpKeys.FormattingEnabled = true;
            this.listUpKeys.ItemHeight = 25;
            this.listUpKeys.Location = new System.Drawing.Point(6, 39);
            this.listUpKeys.Name = "listUpKeys";
            this.listUpKeys.Size = new System.Drawing.Size(259, 129);
            this.listUpKeys.TabIndex = 0;
            // 
            // groupDownKeys
            // 
            this.groupDownKeys.Controls.Add(this.btnClearDownKeys);
            this.groupDownKeys.Controls.Add(this.btnAddDownKeys);
            this.groupDownKeys.Controls.Add(this.listDownKeys);
            this.groupDownKeys.Location = new System.Drawing.Point(460, 108);
            this.groupDownKeys.Name = "groupDownKeys";
            this.groupDownKeys.Size = new System.Drawing.Size(428, 186);
            this.groupDownKeys.TabIndex = 2;
            this.groupDownKeys.TabStop = false;
            this.groupDownKeys.Text = "Move Mouse DOWN Keys";
            // 
            // btnClearDownKeys
            // 
            this.btnClearDownKeys.Location = new System.Drawing.Point(271, 105);
            this.btnClearDownKeys.Name = "btnClearDownKeys";
            this.btnClearDownKeys.Size = new System.Drawing.Size(151, 60);
            this.btnClearDownKeys.TabIndex = 1;
            this.btnClearDownKeys.Text = "Clear Keys";
            this.btnClearDownKeys.UseVisualStyleBackColor = true;
            // 
            // btnAddDownKeys
            // 
            this.btnAddDownKeys.Location = new System.Drawing.Point(271, 39);
            this.btnAddDownKeys.Name = "btnAddDownKeys";
            this.btnAddDownKeys.Size = new System.Drawing.Size(151, 60);
            this.btnAddDownKeys.TabIndex = 1;
            this.btnAddDownKeys.Text = "Add Key";
            this.btnAddDownKeys.UseVisualStyleBackColor = true;
            // 
            // listDownKeys
            // 
            this.listDownKeys.FormattingEnabled = true;
            this.listDownKeys.ItemHeight = 25;
            this.listDownKeys.Location = new System.Drawing.Point(6, 39);
            this.listDownKeys.Name = "listDownKeys";
            this.listDownKeys.Size = new System.Drawing.Size(259, 129);
            this.listDownKeys.TabIndex = 0;
            // 
            // groupRightKeys
            // 
            this.groupRightKeys.Controls.Add(this.btnClearRightKeys);
            this.groupRightKeys.Controls.Add(this.btnAddRightKey);
            this.groupRightKeys.Controls.Add(this.listRightKeys);
            this.groupRightKeys.Location = new System.Drawing.Point(459, 313);
            this.groupRightKeys.Name = "groupRightKeys";
            this.groupRightKeys.Size = new System.Drawing.Size(428, 186);
            this.groupRightKeys.TabIndex = 4;
            this.groupRightKeys.TabStop = false;
            this.groupRightKeys.Text = "Move Mouse RIGHT Keys";
            // 
            // btnClearRightKeys
            // 
            this.btnClearRightKeys.Location = new System.Drawing.Point(271, 105);
            this.btnClearRightKeys.Name = "btnClearRightKeys";
            this.btnClearRightKeys.Size = new System.Drawing.Size(151, 60);
            this.btnClearRightKeys.TabIndex = 1;
            this.btnClearRightKeys.Text = "Clear Keys";
            this.btnClearRightKeys.UseVisualStyleBackColor = true;
            // 
            // btnAddRightKey
            // 
            this.btnAddRightKey.Location = new System.Drawing.Point(271, 39);
            this.btnAddRightKey.Name = "btnAddRightKey";
            this.btnAddRightKey.Size = new System.Drawing.Size(151, 60);
            this.btnAddRightKey.TabIndex = 1;
            this.btnAddRightKey.Text = "Add Key";
            this.btnAddRightKey.UseVisualStyleBackColor = true;
            // 
            // listRightKeys
            // 
            this.listRightKeys.FormattingEnabled = true;
            this.listRightKeys.ItemHeight = 25;
            this.listRightKeys.Location = new System.Drawing.Point(6, 39);
            this.listRightKeys.Name = "listRightKeys";
            this.listRightKeys.Size = new System.Drawing.Size(259, 129);
            this.listRightKeys.TabIndex = 0;
            // 
            // groupLeftKeys
            // 
            this.groupLeftKeys.Controls.Add(this.btnClearLeftKeys);
            this.groupLeftKeys.Controls.Add(this.btnAddLeftKey);
            this.groupLeftKeys.Controls.Add(this.listLeftKeys);
            this.groupLeftKeys.Location = new System.Drawing.Point(11, 313);
            this.groupLeftKeys.Name = "groupLeftKeys";
            this.groupLeftKeys.Size = new System.Drawing.Size(428, 186);
            this.groupLeftKeys.TabIndex = 3;
            this.groupLeftKeys.TabStop = false;
            this.groupLeftKeys.Text = "Move Mouse LEFT Keys";
            // 
            // btnClearLeftKeys
            // 
            this.btnClearLeftKeys.Location = new System.Drawing.Point(271, 105);
            this.btnClearLeftKeys.Name = "btnClearLeftKeys";
            this.btnClearLeftKeys.Size = new System.Drawing.Size(151, 60);
            this.btnClearLeftKeys.TabIndex = 1;
            this.btnClearLeftKeys.Text = "Clear Keys";
            this.btnClearLeftKeys.UseVisualStyleBackColor = true;
            // 
            // btnAddLeftKey
            // 
            this.btnAddLeftKey.Location = new System.Drawing.Point(271, 39);
            this.btnAddLeftKey.Name = "btnAddLeftKey";
            this.btnAddLeftKey.Size = new System.Drawing.Size(151, 60);
            this.btnAddLeftKey.TabIndex = 1;
            this.btnAddLeftKey.Text = "Add Key";
            this.btnAddLeftKey.UseVisualStyleBackColor = true;
            // 
            // listLeftKeys
            // 
            this.listLeftKeys.FormattingEnabled = true;
            this.listLeftKeys.ItemHeight = 25;
            this.listLeftKeys.Location = new System.Drawing.Point(6, 39);
            this.listLeftKeys.Name = "listLeftKeys";
            this.listLeftKeys.Size = new System.Drawing.Size(259, 129);
            this.listLeftKeys.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(18, 535);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(272, 61);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(610, 535);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(272, 61);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(13, 24);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(840, 50);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Add keys to a Mouse Move direction, or clear all keys. Click Save Changes to save" +
    " all \r\nchanges, or Cancel to abandon your changes.";
            // 
            // KeyBindingForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(901, 610);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupRightKeys);
            this.Controls.Add(this.groupDownKeys);
            this.Controls.Add(this.groupLeftKeys);
            this.Controls.Add(this.groupUpKeys);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KeyBindingForm";
            this.Text = "Assign Key Bindings";
            this.groupUpKeys.ResumeLayout(false);
            this.groupDownKeys.ResumeLayout(false);
            this.groupRightKeys.ResumeLayout(false);
            this.groupLeftKeys.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupUpKeys;
        private System.Windows.Forms.Button btnClearUpKeys;
        private System.Windows.Forms.Button btnAddUpKey;
        private System.Windows.Forms.ListBox listUpKeys;
        private System.Windows.Forms.GroupBox groupDownKeys;
        private System.Windows.Forms.Button btnClearDownKeys;
        private System.Windows.Forms.Button btnAddDownKeys;
        private System.Windows.Forms.ListBox listDownKeys;
        private System.Windows.Forms.GroupBox groupRightKeys;
        private System.Windows.Forms.Button btnClearRightKeys;
        private System.Windows.Forms.Button btnAddRightKey;
        private System.Windows.Forms.ListBox listRightKeys;
        private System.Windows.Forms.GroupBox groupLeftKeys;
        private System.Windows.Forms.Button btnClearLeftKeys;
        private System.Windows.Forms.Button btnAddLeftKey;
        private System.Windows.Forms.ListBox listLeftKeys;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDescription;
    }
}