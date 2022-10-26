using System;
using System.Collections;
using System.Collections.Generic;
using Ipl2022;
using UnityEngine;

namespace ipl2022.Guillaume {
    public class Health : MonoBehaviour, IDamageable
    {
        [SerializeField] private int initHealth;
        [SerializeField] private int currentHealth;
    
        private void OnEnable()
        {
            currentHealth = initHealth;
        }
    
        public Action<IDamage> DamageTaken { get; set; }
    
        public void TakeDamage(IDamage damage)
        {
            currentHealth -= damage.DamageValue;
            if (currentHealth <= 0)
                Die();
        }
    
        private void Die()
        {
            Destroy(gameObject);
        }
    }
}
