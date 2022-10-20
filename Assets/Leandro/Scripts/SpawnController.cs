using System;
using System.Collections;
using System.Collections.Generic;
using Ipl2022;
using UnityEngine;

namespace Ipl2022.Leandro
{
    public class SpawnController : MonoBehaviour
    {
        [SerializeField] public SpawnMode mode ;
        [SerializeField] public GameObject[] spawners;

        private void Start()
        {
            InvokeRepeating(nameof(Spawn),0,0.5f);
        }

        public void Spawn()
        {
            switch (mode)
            {
                case SpawnMode.ALL:
                    SpawnAll();
                    break;
                case SpawnMode.ROUND_ROBIN:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            
        }

        private void SpawnAll()
        {
            foreach (var spawner in spawners)
            {
                spawner.GetComponent<ISpawner>()?.Spawn();
            }
        }
    }

    public enum SpawnMode
    {
        ALL,
        ROUND_ROBIN,
    }
 
}
