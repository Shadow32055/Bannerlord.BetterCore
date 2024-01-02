namespace BetterCore.Utils {
    public class Helper {
        public static string modName = "ForgotToSet";

        public static void SetModName(string name) {
            modName = name;
            Logger.SendMessage(modName + " Loaded.", Severity.Good);
        }
    }
}