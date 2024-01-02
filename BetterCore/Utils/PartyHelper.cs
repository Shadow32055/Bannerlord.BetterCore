using TaleWorlds.CampaignSystem.Party;

namespace BetterCore.Utils {
    public class PartyHelper {

        public static int CalculatePartyStrength(PartyBase party) {
            int strength = 0;

            if (party != null) {
                int partyCount, addTroops = 0, number;

                partyCount = party.NumberOfHealthyMembers;

                int tier1 = party.GetNumberOfHealthyMenOfTier(1);
                int tier2 = party.GetNumberOfHealthyMenOfTier(2);
                int tier3 = party.GetNumberOfHealthyMenOfTier(3);
                int tier4 = party.GetNumberOfHealthyMenOfTier(4);
                int tier5 = party.GetNumberOfHealthyMenOfTier(5);
                int tier6 = party.GetNumberOfHealthyMenOfTier(6);

                number = tier1 + tier2 + tier3 + tier4 + tier5 + tier6;

                if (number < partyCount) {
                    //Using troops mods for higher tier units
                    addTroops = partyCount - number;
                }

                strength = tier1 + (2 * tier2) + (3 * tier3) + (4 * tier4) + (5 * tier5) + (6 * tier6) + (7 * addTroops);
            }

            return strength;
        }
    }
}
