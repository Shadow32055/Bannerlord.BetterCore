using BetterCore.Utils;
using System;
using TaleWorlds.MountAndBlade;

namespace BetterCore {
    public class BetterCore : MBSubModuleBase {

        public static string ModName { get; private set; } = "BetterCore";

        private bool isLoaded = false;

        protected override void OnBeforeInitialModuleScreenSetAsRoot() {
			base.OnBeforeInitialModuleScreenSetAsRoot();
			try {

                if (isLoaded)
                    return;

                ModName = base.GetType().Assembly.GetName().Name;

                NotifyHelper.WriteMessage(ModName + " Loaded.", MsgType.Good);
                Integrations.BetterCoreLoaded = true;

                isLoaded = true;
			} catch (Exception e) {
                NotifyHelper.WriteError(ModName, "OnBeforeInitialModuleScreenSetAsRoot threw exception " + e);
            }
		}
    }
}
