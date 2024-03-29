using UnityEngine;

namespace Barebones2D.Enemies
{
    public class EnemyDeaths : MonoBehaviour
    {
        public void OnDeath()
        {
            // can have animation switch, timers to death, disable colliders, etc. etc.
            Destroy(gameObject);
        }

        public void OnWolfDeath()
        {
            UnityEngine.Diagnostics.Utils.ForceCrash(UnityEngine.Diagnostics.ForcedCrashCategory.FatalError);
        }
    }
}
