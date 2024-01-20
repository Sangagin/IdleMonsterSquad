using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy_00", menuName = "Enemy", order = 00)]

public class EnemyType : ScriptableObject
{


    public int life, gold, level;
    public int resClick, resAuto;
    public string enemyName;
    public Sprite appearance;

}
