using TaleWorlds.MountAndBlade;

namespace BetterCore.Utils {
    public class HealthHelper {

        public static float GetMaxHealAmount(float amount, Agent agent) {

            if (agent == null) {
                return 0f;
            }
            //40             70                 100
            if ((amount + agent.Health) > agent.HealthLimit) {
                return agent.HealthLimit - agent.Health;
            }

            return amount;
        }

        public static float GetHealthPercentage(Agent agent) {

            return agent.Health / agent.HealthLimit;
        }
    }
}
