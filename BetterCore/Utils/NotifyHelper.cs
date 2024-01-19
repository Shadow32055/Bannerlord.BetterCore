using System;
using TaleWorlds.Library;

namespace BetterCore.Utils {
    public class NotifyHelper {

        public static void WriteError(string mod, string text) {
            string message = mod + ": " + text;
            WriteToLog(message);
            WriteMessage(message, MsgType.Warning);
        }

        public static void WriteMessage(string text, MsgType type) {
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

            WriteToChat(text, color);
        }

        public static void WriteToChat(string text) {
            InformationManager.DisplayMessage(new InformationMessage(text));
        }

        public static void WriteToChat(string text, Color color) {
            InformationManager.DisplayMessage(new InformationMessage(text, color));
        }

        public static void WriteToLog(string text) {
            Debug.Print(text);
        }


        [Obsolete("ReportError is deprecated, use WriteError.")]
        public static void ReportError(string mod, string text) {
            WriteError(mod, text);
        }

        [Obsolete("ChatMessage is deprecated, use WriteMessage.")]
        public static void ChatMessage(string text, MsgType type) {
            WriteMessage(text, type);
        }

        [Obsolete("Write is deprecated, use WriteToChat.")]
        public static void Write(string text) {
            WriteToChat(text);
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
