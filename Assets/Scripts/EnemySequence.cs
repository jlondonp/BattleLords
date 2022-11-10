using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BattleLords.model;

public class EnemySequence 
{
    private static EnemySequence _i;
    private int enemyIndex;

    public static EnemySequence instance
    {
        get
        {
            if (_i == null) _i = new EnemySequence();
            return _i;
        }
    }

    private EnemySequence() {
        enemyIndex = 1;
    }

    public Enemy getNextEnemy()
    {
        switch (enemyIndex ++)
        {
            default:
            case 1: return new Zombie();
            case 2: return new EvilWizard();
            case 3: return new DarkBoss();
        }

    }
}
