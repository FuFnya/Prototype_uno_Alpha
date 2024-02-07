using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public PowerUpDataOS PowerUpData;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "Player") return;
        Destroy(gameObject);
        PowerUpData.Apply(collision.gameObject);
    }
}
