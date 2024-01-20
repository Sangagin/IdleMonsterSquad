using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissmiss : MonoBehaviour
{
    public VarManager varManager;
    public Monster monster;
    public GameObject statWindow;
    public List<GameObject> listHireButton = new List<GameObject>();
    public List<float> currentDamageC;
    public List<float> currentDamageA;
    public void dissmiss()
    {
        var posActual = varManager.getPos();

        monster.appareanceDeployed[posActual - 1].sprite = monster.empty;


        currentDamageC = monster.getDamageC();
        currentDamageA = monster.getDamageA();


        var id = monster.listMonstersHired[posActual-1].id;


        varManager.addClickDamageTotal(-currentDamageC[id]);
        varManager.addAutoDamage(-currentDamageA[id]);



        for(int i = 0; i < monster.listMonsters.Count; i++)
        {
           if (monster.listMonsters[i] == monster.listMonstersHired[posActual - 1]) {
                listHireButton[i].SetActive(true);
            }


        }



        
        monster.listMonstersHired[posActual-1] = null;



        statWindow.SetActive(false);



    }
}
