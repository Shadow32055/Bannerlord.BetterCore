using System;
using TaleWorlds.MountAndBlade;

namespace BetterCore.Utils {
    public class HealthHelper {

        public static float HealLimit { get; set; } = 1f;

        public static float GetHealthPercentage(Agent agent) {

            return agent.Health / agent.HealthLimit;
        }

        //Marking obsolete to flag in mods that may still be using this, maybe(?) updated to private in future version.
        [Obsolete("GetMaxHealAmount(float, agent) is deprecated, use HealAgent.")]
        public static float GetMaxHealAmount(float amount, Agent agent) {

            if (agent == null) {
                return 0f;
            }

            if ((amount + agent.Health) > agent.HealthLimit) {
                return agent.HealthLimit - agent.Health;
            }

            return amount;
        }

        //Marking obsolete to flag in mods that may still be using this, maybe(?) updated to private in future version.
        [Obsolete("GetMaxHealAmount(float, float, float) is deprecated, use HealAgent.")]
        public static float GetMaxHealAmount(float amount, float current, float max) {
            if ((amount + current) > max) {
                return max - current;
            }

            return amount;
        }

        public static float HealAgent(Agent agent, float healAmount) {
            if (healAmount <= 0)
                return 0;
            
            if (agent == null)
                return 0;

            if (agent.Health >= agent.HealthLimit)
                return 0;

            healAmount = GetMaxHealAmount(healAmount, agent.Health, HealLimit * agent.HealthLimit);

            if (healAmount > 0)
                agent.Health += healAmount;

            return healAmount;
        }
    }
}
