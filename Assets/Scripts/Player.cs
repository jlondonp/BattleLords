using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace BattleLords.model
{
    public class Player : MonoBehaviour
    {

        private Weapon weapon;
        private Health health;
        private int goldAmount;

        public Player(Weapon weapon, Health health, int goldAmount)
        {
            this.weapon = weapon;
            this.health = health;
            this.goldAmount = goldAmount;
        }

        public void AddGoldAmount( int addGoldAmount )
        {
            goldAmount += addGoldAmount;
        }

        public int GetGoldAmount()
        {
            return goldAmount;
        }

    }
}
