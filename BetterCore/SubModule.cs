using BetterCore.Utils;
using HarmonyLib;
using TaleWorlds.MountAndBlade;

namespace BetterCore {
    public class SubModule : MBSubModuleBase {

		protected override void OnSubModuleLoad() {
			base.OnSubModuleLoad();

			Harmony h = new("Bannerlord.Shadow.BetterCore");

            //*** Manual patching reference
            //MethodInfo original = typeof(Hero).GetProperty("AddSkillXp").GetGetMethod();
            //MethodInfo postfix = typeof(XPPatch).GetMethod("AddSkillXp");
            //h.Patch(original, postfix: new HarmonyMethod(postfix));

            h.PatchAll();
		}

		protected override void OnBeforeInitialModuleScreenSetAsRoot() {
			base.OnBeforeInitialModuleScreenSetAsRoot();

			string modName = base.GetType().Assembly.GetName().Name;

			Helper.SetModName(modName);
		}
    }
}
