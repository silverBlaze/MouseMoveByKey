using System.Windows.Forms;

namespace MouseMoveByKey {
    public partial class GetKeyPress : Form {

        public bool Cancelled { get; set; } = false;
        public Keys KeyPressed { get; set; } = Keys.None;

        public GetKeyPress() {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if(keyData == Keys.Escape) {
                Cancelled = true;
                Close();
                return true;
            }
            KeyPressed = keyData;
            Close();
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
