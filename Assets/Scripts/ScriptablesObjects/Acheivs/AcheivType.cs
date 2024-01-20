using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Acheiv_00", menuName = "Acheiv", order = 00)]

public class AcheivType : ScriptableObject
{


    public int idMonsterToKill,countToUnlock,idMonster,nbUpgradeClick,nbUpgradeAuto;
    public Sprite badge;
    public bool unlocked = false;
    


}
