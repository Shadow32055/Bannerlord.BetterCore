using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;

namespace BetterCore.Utils {
    public class AttributeHelper {

        public static float GetAttributeEffect(float bonus, CharacterAttribute attribute, CharacterObject character) {
            int attributeLevel = GetAttributeLevel(attribute, character);

            return bonus * attributeLevel;
        }

        public static int GetAttributeLevel(CharacterAttribute attribute, CharacterObject character) {
            int level = 0;

            if (attribute == DefaultCharacterAttributes.Vigor) {
                level = character.HeroObject.GetAttributeValue(DefaultCharacterAttributes.Vigor);
            } else if (attribute == DefaultCharacterAttributes.Control) {
                level = character.HeroObject.GetAttributeValue(DefaultCharacterAttributes.Control);
            } else if (attribute == DefaultCharacterAttributes.Endurance) {
                level = character.HeroObject.GetAttributeValue(DefaultCharacterAttributes.Endurance);
            } else if (attribute == DefaultCharacterAttributes.Cunning) {
                level = character.HeroObject.GetAttributeValue(DefaultCharacterAttributes.Cunning);
            } else if (attribute == DefaultCharacterAttributes.Social) {
                level = character.HeroObject.GetAttributeValue(DefaultCharacterAttributes.Social);
            } else if (attribute == DefaultCharacterAttributes.Intelligence) {
                level = character.HeroObject.GetAttributeValue(DefaultCharacterAttributes.Intelligence);
            }

            return level;
        }

        public static CharacterAttribute GetAttributeTypeFromIndex(int index) {

            if (index == 0) {
                return DefaultCharacterAttributes.Vigor;
            } else if (index == 1) {
                return DefaultCharacterAttributes.Control;
            } else if (index == 2) {
                return DefaultCharacterAttributes.Endurance;
            } else if (index == 3) {
                return DefaultCharacterAttributes.Cunning;
            } else if (index == 4) {
                return DefaultCharacterAttributes.Social;
            } else {
                return DefaultCharacterAttributes.Intelligence;
            }
        }
    }
}
