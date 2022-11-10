using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BattleLords.model
{
    public abstract class Weapon
    {
        private int damageLevel;

        public int GetDamageLevel()
        {
            return damageLevel;
        }
    }

}