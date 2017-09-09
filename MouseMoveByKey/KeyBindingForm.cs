using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseMoveByKey {
    public partial class KeyBindingForm : Form {
        public KeyBindingForm() {
            InitializeComponent();
        }

        private void btnAddUpKey_Click(object sender, EventArgs e) {
            using(var getUpKeyPress = new GetKeyPress()) {
                getUpKeyPress.ShowDialog();
                if(!getUpKeyPress.Cancelled && !listUpKeys.Items.Contains(getUpKeyPress.KeyPressed)) {
                    listUpKeys.Items.Add(getUpKeyPress.KeyPressed);
                }
            }
        }

        private void btnAddDownKeys_Click(object sender, EventArgs e) {
            using(var getDownKeyPress = new GetKeyPress()) {
                getDownKeyPress.ShowDialog();
                if(!getDownKeyPress.Cancelled && !listDownKeys.Items.Contains(getDownKeyPress.KeyPressed)) {
                    listDownKeys.Items.Add(getDownKeyPress.KeyPressed);
                }
            }
        }

        private void btnAddLeftKey_Click(object sender, EventArgs e) {
            using(var getLeftKeyPress = new GetKeyPress()) {
                getLeftKeyPress.ShowDialog();
                if(!getLeftKeyPress.Cancelled && !listLeftKeys.Items.Contains(getLeftKeyPress.KeyPressed)) {
                    listLeftKeys.Items.Add(getLeftKeyPress.KeyPressed);
                }
            }
        }

        private void btnAddRightKey_Click(object sender, EventArgs e) {
            using(var getRightKeyPress = new GetKeyPress()) {
                getRightKeyPress.ShowDialog();
                if(!getRightKeyPress.Cancelled && !listRightKeys.Items.Contains(getRightKeyPress.KeyPressed)) {
                    listRightKeys.Items.Add(getRightKeyPress.KeyPressed);
                }
            }
        }
    }
}
