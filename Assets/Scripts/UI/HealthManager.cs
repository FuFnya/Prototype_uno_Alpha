using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public Image healthBar;
    public float healthAmount = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void lowerHP(float dmg) 
    {
        healthAmount -= dmg;
        healthBar.fillAmount = healthAmount/5f;
    }

    public void increaseHP(float hp)
    {
        healthAmount += hp;
        healthAmount = Mathf.Clamp(healthAmount, 0, 5);

        healthBar.fillAmount = healthAmount / 5f;
    }

}
