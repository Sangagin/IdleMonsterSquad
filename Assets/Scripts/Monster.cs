using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monster : MonoBehaviour
{



    public UpgradeManager upgradeManager;
    public List<Image> appareanceDeployed = new List<Image>();

    public List<Image> appareanceToHire = new List<Image>();
    public Sprite plus,empty;
    public List<float> damageC, damageA;
    public List<MonsterType> listMonsters = new List<MonsterType>();
    public List<MonsterType> listMonstersHired = new List<MonsterType>();


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < appareanceDeployed.Count; i++)
        {
            appareanceDeployed[i].sprite = empty;
        }

        for (int i = 0;i < listMonsters.Count; i++)
        {
            appareanceToHire[i].sprite = listMonsters[i].front;
            damageC[i] = listMonsters[i].clicDamage;
            damageA[i] = listMonsters[i].autoDamage;
        }

        listMonstersHired.Clear();
        listMonstersHired.Add(null);
        listMonstersHired.Add(null);
        listMonstersHired.Add(null);
        listMonstersHired.Add(null);

    }

    // Update is called once per frame
    void Update()
    {



    }



    public List<float> getDamageC() { return damageC; }
    public List<float> getDamageA() {  return damageA; }
    public void setDamageC(List<float> newDamage) { damageC = newDamage; }
    public void setDamageA(List<float> newDamage) { damageA = newDamage; }




}
