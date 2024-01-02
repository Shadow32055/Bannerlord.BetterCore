using System.Collections.Generic;
using System.Linq;
using TaleWorlds.CampaignSystem;

namespace BetterCore.Utils {
    public class RelationHelper {
        public static void ChangeRelation(Hero lord1, Hero lord2, int change) {
            if (lord1 != null && lord2 != null) {
                int relation = CharacterRelationManager.GetHeroRelation(lord1, lord2) + change;

                if (relation > 100)
                    relation = 100;
                else {
                    if (relation < -100)
                        relation = -100;
                }

                CharacterRelationManager.SetHeroRelation(lord1, lord2, relation);
            }
        }

        /*** Change Family Relation ***/
        public static void ChangeFamilyRelation(Hero lord1, Hero lord2, int change) {
            List<Hero> familyMembers = FindFamily(lord2);

            for (int i = 0; i < familyMembers.Count; i++) { ChangeRelation(lord1, familyMembers[i], change); }
        }

        public static List<Hero> FindFamily(Hero hero) {
            List<Hero> familyMembers = new List<Hero>();

            if (hero != null) {
                Hero familyMember;

                for (int i = 0; i < hero.Children.Count; i++) {
                    familyMember = hero.Children[i];

                    if (familyMember != null) {
                        if (familyMember.IsAlive)
                            familyMembers.Add(familyMember);
                    }
                }

                for (int i = 0; i < hero.Siblings.Count(); i++) {
                    familyMember = hero.Siblings.ElementAt<Hero>(i);

                    if (familyMember != null) {
                        if (familyMember.IsAlive)
                            familyMembers.Add(familyMember);
                    }
                }

                if (hero.Spouse != null) {
                    if (hero.Spouse.IsAlive)
                        familyMembers.Add(hero.Spouse);
                }

                if (hero.Father != null) {
                    if (hero.Father.IsAlive)
                        familyMembers.Add(hero.Father);
                }

                if (hero.Mother != null) {
                    if (hero.Mother.IsAlive)
                        familyMembers.Add(hero.Mother);
                }
            }

            return familyMembers;
        }
    }
}
