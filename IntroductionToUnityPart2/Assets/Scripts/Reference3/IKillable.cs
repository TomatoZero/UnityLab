using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Reference3
{
    public interface IKillable
    {
        void Kill();
    }

    public interface IDamageable<T>
    {
        void Damage(T damageTaken);
    }

}