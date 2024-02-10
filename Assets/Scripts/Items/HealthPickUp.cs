using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthPickUp : CollidableObject
{
    [SerializeField]
    private int heal;

    protected override void OnCollided(GameObject collidedObject)
    {
        if (collidedObject == null) return;

        if (collidedObject.GetComponent<Player>().MAX_HEALTH > collidedObject.GetComponent<Player>().Health)
        {
            collidedObject.GetComponent<Player>().GetHeal(heal);
            Destroy(this.gameObject);
        }
    }
}
