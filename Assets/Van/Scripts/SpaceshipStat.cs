using System;
using UnityEngine;
namespace Ipl2022.Van
{
    public class SpaceshipStat : MonoBehaviour, IDamageable
    {
        [SerializeField] private int currentHealth;
        [SerializeField] private int maxHealth;
        [SerializeField] private GameObject spaceship;
        public Action<IDamage> DamageTaken { get; set; }

        // Start is called before the first frame update
        void Start()
        {
            currentHealth = maxHealth;
        }

        private void OnEnable()
        {
            DamageTaken += TakeDamage;
        }

        private void OnDisable()
        {
            DamageTaken -= TakeDamage;
        }

        public void TakeDamage(IDamage damage)
        {
            currentHealth -= damage.DamageValue;
            CheckDeath();
        }

        private void CheckDeath()
        {
            if (currentHealth <= 0)
            {
                currentHealth = 0;
                Destroy(spaceship);
            }
        }
    }
}
