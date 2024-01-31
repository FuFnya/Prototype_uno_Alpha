using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int health = 100;

    private int MAX_HEALTH = 100;

    void Update()
    {

    }

    public void SetHealth (int maxHealth, int health)
    {
        this.MAX_HEALTH = maxHealth;
        this.health = health;
    }

    public void Damage(int damage)
    {
        if (damage < 0)
        {
            throw new System.ArgumentOutOfRangeException("No Negative Damage");
        }
        this.health -= damage;

        if (this.health <= 0)
        {
            Die();
        }
    }

    public void Heal(int heal)
    {
        if (heal < 0)
        {
            throw new System.ArgumentOutOfRangeException("No Negative Heal");
        }

        if (health + heal > MAX_HEALTH)
        {
            this.health = MAX_HEALTH;
        } else
        {
            this.health += heal;
        }
    }

    private void Die()
    {
        Debug.Log("I am Dead");
        Destroy(gameObject);
    }
}
