using System.Collections.Generic;
using TaleWorlds.Core;

namespace BetterCore.Utils {
    public class LootHelper {
        public static List<EquipmentIndex> LootableSlots = new List<EquipmentIndex> {
            EquipmentIndex.WeaponItemBeginSlot,
            EquipmentIndex.Weapon1,
            EquipmentIndex.Weapon2,
            EquipmentIndex.Weapon3,
            EquipmentIndex.ExtraWeaponSlot,
            EquipmentIndex.NumAllWeaponSlots,
            EquipmentIndex.Body,
            EquipmentIndex.Leg,
            EquipmentIndex.Gloves,
            EquipmentIndex.Cape,
            EquipmentIndex.ArmorItemEndSlot,
            EquipmentIndex.HorseHarness
        };
    }
}
