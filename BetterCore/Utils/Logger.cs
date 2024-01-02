using TaleWorlds.Library;

namespace BetterCore.Utils {
    public class Logger {
        public static void SendMessage(string text, Severity sev) {

            if (sev == Severity.High || sev == Severity.Medium || sev == Severity.Low) {
                text = Helper.modName + ": " + text;
                PrintToLog(text);
            }

            Color color = Colors.Gray;

            switch (sev) {
                case Severity.Good:
                    color = Colors.Green;
                    break;
                case Severity.Notify:
                    color = Colors.White;
                    break;
                case Severity.Alert:
                    color = Colors.Cyan;
                    break;
                case Severity.Warn:
                    color = Colors.Magenta;
                    break;
                case Severity.Low:
                    color = Colors.Blue;
                    break;
                case Severity.Medium:
                    color = Colors.Yellow;
                    break;
                case Severity.High:
                    color = Colors.Red;
                    break;
            }

            PrintToChat(text, color);
        }

        public static void PrintToChat(string msg, Color color) {
            InformationManager.DisplayMessage(new InformationMessage(msg, color));
        }

        public static void PrintToLog(string text) {
            Debug.Print(text);
        }
    }

    public enum Severity {
        Normal,
        Notify,
        Alert,
        Warn,
        Good,
        Low,
        Medium,
        High
    }
}
