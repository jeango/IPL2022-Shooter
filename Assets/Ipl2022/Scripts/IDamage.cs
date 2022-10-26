using System;

namespace Ipl2022
{
    public interface IDamage
    {
        Action<int> DamageDealt { get; set; }
        int DamageValue{ get; }
    }
}