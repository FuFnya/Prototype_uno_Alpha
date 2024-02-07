using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PowerUps/HealthBuff")]
public class HealthBuffDataOS : PowerUpDataOS
{
    [SerializeField]
    private int amount;
    public override void Apply(GameObject target)
    {
        target.GetComponent<Player>().MAX_HEALTH += amount;
        target.GetComponent<Player>().GetHeal(0);
    }
}
