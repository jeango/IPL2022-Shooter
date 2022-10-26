using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ipl2022;
using System;

namespace Ipl2022.Tanguy
{
    public class Damage : MonoBehaviour, IDamage
    {
        public Action<int> DamageDealt { get; set; }

        public int DamageValue { get; private set; }

        private void OnTriggerEnter2D(Collider2D collider)
        {
            var other = collider.attachedRigidbody;

            if (other)
                DealDamage(other.gameObject);
            else
                DealDamage(collider.gameObject);
            
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            var other = collision.rigidbody;

            if (other)
                DealDamage(other.gameObject);
            else
                DealDamage(collision.gameObject);

        }

        void DealDamage(GameObject obj)
        {
            var damageable = obj.GetComponentInChildren<IDamageable>();//other.GetComponentInChildren(typeof(IDamageable));
            //verifie si objet null
            damageable?.TakeDamage(this);
        }
    }
}