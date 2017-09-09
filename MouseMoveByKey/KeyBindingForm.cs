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
    }
}
