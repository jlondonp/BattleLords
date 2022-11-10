using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BattleLords.model
{
    public abstract class Enemy : MonoBehaviour
    {

        private Weapon weapon;
        private Health health;

        public enum EnemyType
        {
            Zombie,
            Evil_Wizard,
            Dark_Boss
        }

    }
}
