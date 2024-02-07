using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Player : MonoBehaviour, IAgent, IHittable
{
    [field: SerializeField]
    public int Health { get; set; } = 5;

    [field: SerializeField]
    public int MAX_HEALTH { get; set; } = 5;

    [field: SerializeField]
    private Image healthBar;

    [field: SerializeField]
    public UnityEvent OnDie { get; set; }
    [field: SerializeField]
    public UnityEvent OnGetHit { get; set; }

    private bool dead = false;

    public void Awake()
    {
        //DontDestroyOnLoad(this);
    }

    public void GetHit(int damage, GameObject damageDealer)
    {
        if (dead) return;

        Health -= damage;
        OnGetHit?.Invoke();
        healthBar.fillAmount = Health / (float)MAX_HEALTH;
        if (Health <= 0)
        {
            OnDie?.Invoke();
            dead = true;
        }
    }

    public void GetHeal(int heal)
    {
        if (dead) return;
        Health += heal;
        healthBar.fillAmount = Health / (float)MAX_HEALTH;
    }

    public void OnDeath()
    {
        Destroy(gameObject);
    }
}