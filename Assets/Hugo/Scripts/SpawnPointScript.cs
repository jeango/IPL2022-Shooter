using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ipl2022.proxysoulCode
{
    public class SpawnPointScript : MonoBehaviour, ISpawner
    {
        [SerializeField] private GameObject projectile;
        [SerializeField] private Transform spawnPointTransform;

        public Action<GameObject> Spawned { get; set; }

        public GameObject Spawn()
        {
            var spawnedObject = Instantiate(projectile, spawnPointTransform.position, Quaternion.identity);
            return spawnedObject;
        }
    }
}
