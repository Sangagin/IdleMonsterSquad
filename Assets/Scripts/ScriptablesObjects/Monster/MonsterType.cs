using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Monster_00", menuName = "Monster", order = 00)]

public class MonsterType : ScriptableObject
{


    public int clicDamage, autoDamage, basePriceUpgradeCD, basePriceUpgradeAD,id;
    public string monsterName;
    public Sprite front;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
