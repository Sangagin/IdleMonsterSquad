using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class UpgradeClick : MonoBehaviour
{

    public float multiplier;
    public UpgradeManager upgradeManager;
    public VarManager varManager;
    public Monster monster;
    public TextMeshProUGUI textCost1,cd;
    // Start is called before the first frame update
    public void upgrade()
    {
        var currentPos = varManager.getPos();
        var id = monster.listMonstersHired[currentPos - 1].id;
        var mulC = monster.listMonstersHired[currentPos - 1].basePriceUpgradeCD;
       


        textCost1.text = (mulC * upgradeManager.upgradesClick[id] + 1) + " gold";
       

        var currentGold = varManager.getGold();
        if (currentGold >= (mulC * upgradeManager.upgradesClick[id] + 1))
        {















            var currentDamageC = monster.getDamageC();


            var listMonster = monster.listMonstersHired;


            varManager.addClickDamageTotal((currentDamageC[listMonster[currentPos - 1].id] * multiplier));

            currentDamageC[listMonster[currentPos - 1].id] += (currentDamageC[listMonster[currentPos - 1].id] * multiplier);
            
            
            
            
            
            
            
            monster.setDamageC(currentDamageC);
            varManager.setGold(currentGold - (mulC * upgradeManager.upgradesClick[id] + 1));



            var currentUpgrade = upgradeManager.getUpgradesClick();

            currentUpgrade[listMonster[currentPos - 1].id] += 1;

            upgradeManager.setUpgradesClick(currentUpgrade);


            cd.text = "Click Damage : " + currentDamageC[id];
        }



    }
}
