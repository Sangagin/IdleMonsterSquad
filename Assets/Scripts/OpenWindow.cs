using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OpenWindow : MonoBehaviour
{
    public GameObject window1,window2;
    public VarManager varManager;
    public Monster monster;
    public int pos;
    public Image imageStatWindow;
    public TextMeshProUGUI textCost1,textCost10, cD,aD;
    public UpgradeManager upgradeManager;

    public void open()
    {

        if (monster.listMonstersHired[pos-1]==null)
        {
            window1.SetActive(true);
            varManager.setPos(pos);
        }
        else
        {
            varManager.setPos(pos);

            window2.SetActive(true);
            imageStatWindow.sprite = monster.listMonstersHired[pos - 1].front;

            var id = monster.listMonstersHired[pos - 1].id;
            var mulC = monster.listMonstersHired[pos - 1].basePriceUpgradeCD;
            var mulA = monster.listMonstersHired[pos - 1].basePriceUpgradeAD;



            textCost1.text = (mulC * upgradeManager.upgradesClick[id]+1) + " gold";
            textCost10.text = (mulA * upgradeManager.upgradesClick[id] + 1) + " gold";


            var currentDamageCD = monster.getDamageC();
            var currentDamageAD = monster.getDamageA();


            cD.text = "Click Damage : " + currentDamageCD[id];
            aD.text = "Auto Damage : " + currentDamageAD[id];



        }



    }
}
