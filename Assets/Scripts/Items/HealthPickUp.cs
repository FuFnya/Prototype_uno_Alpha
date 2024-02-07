using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthPickUp : CollidableObject
{
    [SerializeField]
    private UnityEvent OnPickUp;

    protected override void OnCollided(GameObject collidedObject)
    {
        if (collidedObject == null) return;
        //FindObjectOfType<Player>().gameObject.GetComponent<Player>().GetHeal(1);
        Player player = FindObjectOfType<Player>().gameObject.GetComponent<Player>();
        if (player.MAX_HEALTH > player.Health)
        {
            OnPickUp?.Invoke();
            Destroy(this.gameObject);
        }
    }
}
