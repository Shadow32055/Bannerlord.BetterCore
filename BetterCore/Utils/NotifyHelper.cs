using TaleWorlds.Library;

namespace BetterCore.Utils {
    public class NotifyHelper {

        public static void ReportError(string mod, string text) {
            string message = mod + ": " + text;
            PrintToLog(message);
            ChatMessage(message, MsgType.Warning);
        }

        public static void ChatMessage(string text, MsgType type) {
            Color color = Colors.Gray;

            switch (type) {
                case MsgType.Normal:
                    color = Colors.White;
                    break;
                case MsgType.Notify:
                    color = Colors.Cyan;
                    break;
                case MsgType.Risk:
                    color = Colors.Yellow;
                    break;
                case MsgType.Alert:
                    color = Colors.Magenta;
                    break;
                case MsgType.Warning:
                    color = Colors.Red;
                    break;
                case MsgType.Good:
                    color = Colors.Green;
                    break;
            }

            PrintToChat(text, color);
        }

        public static void PrintToChat(string text, Color color) {
            InformationManager.DisplayMessage(new InformationMessage(text, color));
            //ToDo - Add custom colors
            //InformationManager.DisplayMessage(new InformationMessage(s, color ?? new Color(1f, 0f, 0f)));
        }

        public static void PrintToLog(string text) {
            Debug.Print(text);
        }
    }

    public enum MsgType {
        None,//Gray
        Normal,//White
        Notify,//Cyan
        Risk,//Yellow
        Alert,//Magenta
        Warning,//Red
        Good //Green
    }
}
