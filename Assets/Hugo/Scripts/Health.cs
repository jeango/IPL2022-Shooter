using Ipl2022;
using System;
using UnityEngine;

namespace proxysoulCode
{
    public class Health : MonoBehaviour, IDamageable
    {
        [SerializeField] private int initHealth;
        private int currentHealth;

        public Action<IDamage> DamageTaken { get; set; }

        public void TakeDamage(IDamage damage)
        {
            currentHealth -= damage.DamageValue();
            DamageTaken?.Invoke(damage);
            if (currentHealth <= 0)
                Destroy(gameObject);
        }
    }
}
