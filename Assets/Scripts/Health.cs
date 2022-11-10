using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BattleLords.model
{

    public class Health
    {
        private int healthMax;
        private int health;

        public Health( int maxHealth )
        {
            this.healthMax = maxHealth;
            this.health = maxHealth;
        }

        public int GetHealth()
        {
            return health;
        }

        public int GetHealthMax()
        {
            return healthMax;
        }

        public void Damage(int amount)
        {
            health -= amount;
        }

        public void Heal(int amount)
        {
            health += amount;
            if (health > healthMax)
            {
                health = healthMax;
            }
        }

        public bool IsDead()
        {
            return health <= 0;
        }
    }
}
