using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace BattleLords.model
{
    public class Player : MonoBehaviour
    {

        private int goldAmount;

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
