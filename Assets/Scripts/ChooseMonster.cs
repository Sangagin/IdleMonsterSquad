using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseMonster : MonoBehaviour
{
    public VarManager varManager;
    public Monster monster;
    public MonsterType monsterType;
    public GameObject buttonHire,squadWindow;
    public void hire()
    {
        var posActual = varManager.getPos();


        monster.appareanceDeployed[posActual-1].sprite = monsterType.front;
        monster.listMonstersHired[posActual-1]=monsterType;

        List<float> currentDamageC =monster.getDamageC();
        List<float> currentDamageA =monster.getDamageA();



        varManager.addClickDamageTotal(currentDamageC[monsterType.id]);
        varManager.addAutoDamage(currentDamageA[monsterType.id]);




        squadWindow.SetActive(false);
        buttonHire.SetActive(false);

    }
}
