using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BattleLords.store.model
{

    public class Item : MonoBehaviour
    {
   
        public enum ItemType
        {
            ArmorNone,
            Armor_1,
            Armor_2,
            HelmetNone,
            Helmet,
            HealthPotion,
            Sword_1,
            Sword_2
        }

        public static int GetCost(ItemType itemType)
        {
            switch (itemType) {
                default:
                case ItemType.ArmorNone:    return 0;
                case ItemType.Armor_1:      return 30;
                case ItemType.Armor_2:      return 1000;
                case ItemType.HelmetNone:   return 0;
                case ItemType.Helmet:       return 90;
                case ItemType.HealthPotion: return 30;
                case ItemType.Sword_1:      return 0;
                case ItemType.Sword_2:      return 150;
            }
        }

        
        public static Sprite GetSprite( ItemType itemType)
        {
            switch (itemType)
            {
                default:
                case ItemType.ArmorNone:    return GameAssets.instance.s_ArmorNone;
                case ItemType.Armor_1:      return GameAssets.instance.s_Armor_1;
                case ItemType.Armor_2:      return GameAssets.instance.s_Armor_2;
                case ItemType.HelmetNone:   return GameAssets.instance.s_HelmetNone;
                case ItemType.Helmet:       return GameAssets.instance.s_Helmet;
                case ItemType.HealthPotion: return GameAssets.instance.s_HealthPotion;
                case ItemType.Sword_1:      return GameAssets.instance.s_Sword_1;
                case ItemType.Sword_2:      return GameAssets.instance.s_Sword_2;
            }
        }
    }

}

