using BetterCore.Utils;
using System;
using TaleWorlds.MountAndBlade;

namespace BetterCore {
    public class BetterCore : MBSubModuleBase {

		public static string modName { get; private set; } = "ForgotToSet";

		private bool _isInitialized = false;
        private bool _isLoaded = false;

		protected override void OnSubModuleLoad() {
			try {
                if (_isInitialized)
                    return;

                modName = base.GetType().Assembly.GetName().Name;

                _isInitialized = true;
            } catch (Exception e) {
                NotifyHelper.ReportError(modName, "OnSubModuleLoad threw exception " + e);
            }
		}

        protected override void OnBeforeInitialModuleScreenSetAsRoot() {
			base.OnBeforeInitialModuleScreenSetAsRoot();
			try {

                if (_isLoaded)
                    return;

                NotifyHelper.ChatMessage(modName + " Loaded.", MsgType.Good);

                _isLoaded = true;
			} catch (Exception e) {
                NotifyHelper.ReportError(modName, "OnBeforeInitialModuleScreenSetAsRoot threw exception " + e);
            }
		}
    }
}
