using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamagable
{
    [SerializeField] private UiDamagable uiDamagable;
    [SerializeField] private int health;
    [SerializeField] private int maxHealth;

    private void Awake()
    {
        uiDamagable.InitializeSliderValues(maxHealth, health);
    }
    public void Die()
    {
        // PlayAnimation then destroy on anim end
        Destroy(gameObject);
    }

    public void TakeDamage(int damage)
    {
        health -= damage; 
        uiDamagable.OnHealthChanged(health);
        
        if(health <= 0)
        {
            Die();
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(10);
        }
    }
}
