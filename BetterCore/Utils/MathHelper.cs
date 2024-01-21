using System;
using TaleWorlds.Core;

namespace BetterCore.Utils {
    public class MathHelper {

        public static double GetPercentage(double min, double max) {
            //Prevent divide by zero
            if (max == 0) {
                max = min;
            }

            return min / max;
        }

        public static bool RandomChance (double chance) {
            double random = MBRandom.RandomFloat;

            if (random <= chance) {
                return true;
            }

            return false;
        }

        public static int RandomInt (int min, int max) {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
