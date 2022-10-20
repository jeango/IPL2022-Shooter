using System;
using UnityEngine;

namespace Ipl2022
{
    public interface ISpawner
    {
        Action<GameObject> Spawned{ get; set; }
        GameObject Spawn();
    }
}
