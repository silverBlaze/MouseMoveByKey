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

        public static MouseSettings LoadMouseSettingsFromConfig() {
            var serializer = new JavaScriptSerializer();

            FileInfo jsonFile = new FileInfo("MouseSettings.json");
            if(jsonFile.Exists) {
                try {
                    string json = File.ReadAllText(jsonFile.FullName);
                    var settings = serializer.Deserialize<MouseSettings>(json);
                    return settings;
                } catch {
                    MessageBox.Show("Unable to load MouseSettings.json. Starting with default settings.", "Error Loading MouseSettings", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return new MouseSettings();
        }

        public static void SaveMouseSettingsToConfig(MouseSettings mouseSettings) {
            var serializer = new JavaScriptSerializer();
            var json = serializer.Serialize(mouseSettings);
            File.WriteAllText("MouseSettings.json", json);
        }
    }
}
