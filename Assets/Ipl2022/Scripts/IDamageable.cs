using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ipl2022
{
    public interface IDamageable
    {

        Action<IDamage> DamageTaken{ get; set; }
        void TakeDamage(IDamage damage);

    }
}
