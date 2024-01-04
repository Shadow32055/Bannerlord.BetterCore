using BetterCore.Utils;
using System;
using TaleWorlds.MountAndBlade;

namespace BetterCore {
    public class BetterCore : MBSubModuleBase {

		public static string ModName { get; private set; } = "ForgotToSet";

		private bool isInitialized = false;
        private bool isLoaded = false;

		protected override void OnSubModuleLoad() {
			try {
                if (isInitialized)
                    return;

                ModName = base.GetType().Assembly.GetName().Name;

                isInitialized = true;
            } catch (Exception e) {
                NotifyHelper.ReportError(ModName, "OnSubModuleLoad threw exception " + e);
            }
		}

        protected override void OnBeforeInitialModuleScreenSetAsRoot() {
			base.OnBeforeInitialModuleScreenSetAsRoot();
			try {

                if (isLoaded)
                    return;

                NotifyHelper.ChatMessage(ModName + " Loaded.", MsgType.Good);

                isLoaded = true;
			} catch (Exception e) {
                NotifyHelper.ReportError(ModName, "OnBeforeInitialModuleScreenSetAsRoot threw exception " + e);
            }
		}
    }
}
