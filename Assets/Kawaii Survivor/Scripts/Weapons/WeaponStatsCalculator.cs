using System.Collections.Generic;
using UnityEngine;

public class WeaponStatsCalculator : MonoBehaviour
{
    public static Dictionary<Stat, float> GetStats(WeaponDataSO weaponData, int level)
    {
        // lv3 -> 2x stats, level 6 -> 3x stats
        float multiplier = 1 + (float)level / 3;

        Dictionary<Stat, float> calculatedStats = new Dictionary<Stat, float>();

        foreach (KeyValuePair<Stat, float> kvp in weaponData.BaseStats)
        {
            if (weaponData.Prefab.GetType() != typeof(RangeEnemy) && kvp.Key == Stat.Range)
            {
                calculatedStats.Add(kvp.Key, kvp.Value);
            }
            else
            {
                calculatedStats.Add(kvp.Key, kvp.Value * multiplier);

            }
        }

        return calculatedStats;
    }
}
