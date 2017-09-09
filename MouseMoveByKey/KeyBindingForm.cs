using System;
using System.Windows.Forms;

namespace MouseMoveByKey {
    public partial class KeyBindingForm : Form {
        public KeyBindingForm() {
            InitializeComponent();
        }

        private void AddKey(ListBox list) {
            using(var getKeyPress = new GetKeyPress()) {
                getKeyPress.ShowDialog();
                if(!getKeyPress.Cancelled && !list.Items.Contains(getKeyPress.KeyPressed)) {
                    list.Items.Add(getKeyPress.KeyPressed);
                    list.SelectedItem = null;
                }
            }
        }

        private void RemoveKey(ListBox list) {
            if(list.SelectedItem != null)
                list.Items.Remove(list.SelectedItem);
            else
                MessageBox.Show("You must first select a key to remove", "No Key Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAddUpKey_Click(object sender, EventArgs e) {
            AddKey(listUpKeys);
        }

        private void btnAddDownKeys_Click(object sender, EventArgs e) {
            AddKey(listDownKeys);
        }

        private void btnAddLeftKey_Click(object sender, EventArgs e) {
            AddKey(listLeftKeys);
        }

        private void btnAddRightKey_Click(object sender, EventArgs e) {
            AddKey(listRightKeys);
        }

        private void btnClearUpKey_Click(object sender, EventArgs e) {
            RemoveKey(listUpKeys);
        }

        private void btnClearDownKey_Click(object sender, EventArgs e) {
            RemoveKey(listDownKeys);
        }

        private void btnClearLeftKey_Click(object sender, EventArgs e) {
            RemoveKey(listLeftKeys);
        }

        private void btnClearRightKey_Click(object sender, EventArgs e) {
            RemoveKey(listRightKeys);
        }
    }
}
