using System.IO;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace MouseMoveByKey {
    public class ConfigHelper {
        public static KeyBindings LoadKeyBindingsFromConfig() {
            var serializer = new JavaScriptSerializer();

            FileInfo jsonFile = new FileInfo("KeyBindings.json");
            if(jsonFile.Exists) {
                try {
                    string json = File.ReadAllText(jsonFile.FullName);
                    var binding = serializer.Deserialize<KeyBindings>(json);
                    return binding;
                } catch {
                    MessageBox.Show("Unable to load file KeyBindings.json. Starting with blank settings.", "Error Loading KeyBindings", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return new KeyBindings();
        }

        public static void SaveKeyBindingsToConfig(KeyBindings keyBindings) {
            var serializer = new JavaScriptSerializer();
            var json = serializer.Serialize(keyBindings);
            File.WriteAllText("KeyBindings.json", json);
        }
    }
}
