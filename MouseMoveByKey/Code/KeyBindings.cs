using System.Collections.Generic;
using System.Windows.Forms;

namespace MouseMoveByKey {
    public class KeyBindings {
        public List<Keys> UpKeyBindings { get; set; } = new List<Keys>();
        public List<Keys> DownKeyBindings { get; set; } = new List<Keys>();
        public List<Keys> LeftKeyBindings { get; set; } = new List<Keys>();
        public List<Keys> RightKeyBindings { get; set; } = new List<Keys>();
    }
}
