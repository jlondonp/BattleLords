using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAssets : MonoBehaviour
{
    private static GameAssets _i;

    public static GameAssets instance
    {
        get
        {
            if (_i == null) _i = (Instantiate(Resources.Load("GameAssets")) as GameObject).GetComponent<GameAssets>();
            return _i;
        }
    }

    public Sprite s_ArmorNone;
    public Sprite s_Armor_1;
    public Sprite s_Armor_2;
    public Sprite s_HelmetNone;
    public Sprite s_Helmet;
    public Sprite s_HealthPotion;
    public Sprite s_Sword_1;
    public Sprite s_Sword_2;
    public Sprite s_Enemy_Zombie;
    public Sprite s_Enemy_Wizard;
    public Sprite s_Enemy_Boss;



}
