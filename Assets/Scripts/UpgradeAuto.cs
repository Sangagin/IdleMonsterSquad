using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpgradeAuto : MonoBehaviour
{
    public float multiplier;
    public UpgradeManager upgradeManager;
    public VarManager varManager;
    public Monster monster;
    public TextMeshProUGUI textCost10,ad;
    // Start is called before the first frame update
    public void upgrade()
    {

        var currentPos = varManager.getPos();
        var id = monster.listMonstersHired[currentPos - 1].id;
        var mulA = monster.listMonstersHired[currentPos - 1].basePriceUpgradeAD;



        textCost10.text = (mulA * upgradeManager.upgradesClick[id] + 1) + " gold";


        var currentGold = varManager.getGold();
        if (currentGold >= (mulA * upgradeManager.upgradesClick[id] + 1))
        {















            var currentDamageA = monster.getDamageA();


            var listMonster = monster.listMonstersHired;


            varManager.addAutoDamage((currentDamageA[listMonster[currentPos - 1].id] * multiplier));

            currentDamageA[listMonster[currentPos - 1].id] += (currentDamageA[listMonster[currentPos - 1].id] * multiplier);







            monster.setDamageA(currentDamageA);
            varManager.setGold(currentGold - (mulA * upgradeManager.upgradesClick[id] + 1));



            var currentUpgrade = upgradeManager.getUpgradesAuto();

            currentUpgrade[listMonster[currentPos - 1].id] += 1;

            upgradeManager.setUpgradesAuto(currentUpgrade);
            ad.text = "Auto Damage : " + currentDamageA[id];



        }



    }
}
