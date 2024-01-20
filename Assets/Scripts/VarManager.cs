using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VarManager : MonoBehaviour
{


    private float clickDamageTotal = 1, autoDamageTotal = 0, gold = 0;
    private int countAcheiv, evilShards=0,enemyKilled=0;
    private int posActual;
    public Enemy enemy;
    public TextMeshProUGUI textGold, textEvil;


    void Start()
    {
        StartCoroutine(autoDamage());
    }

    // Update is called once per frame
    void Update()
    {

        textGold.text = "Gold : " + gold;
        textEvil.text = "Evil Shard : " + evilShards;

    }


    public float getClickDamageTotal() { return clickDamageTotal; }
    public void setClickDamageTotal(int newDamage) { clickDamageTotal = newDamage; }
    public void addClickDamageTotal(float addedDamage) { clickDamageTotal += addedDamage; }

    public float getAutoDamageTotal() { return autoDamageTotal; }
    public void updateAutoDamageTotal(int autoNew) { autoDamageTotal = autoNew; }
    public void addAutoDamage(float addedDamage) { autoDamageTotal += addedDamage; }

    public int getPos() { return posActual; }

    public void setPos(int newPos) { posActual = newPos; }

    public float getGold() { return gold; }
    public void setGold(float newGold) { gold = newGold; }
    public void addGold(int newGold) { gold += newGold; }

    public float getEvilShard() { return evilShards; }
    public void setEvilShard(int newEV) { evilShards = newEV; }
    public void addEvilShard() { evilShards ++; }

    public float getEnemyKilled() { return enemyKilled; }
    public void setEnemyKilled(int killed) { enemyKilled = killed; }
    public void addEnemyKilled() { enemyKilled ++; }

    public IEnumerator autoDamage()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            float currentLife=enemy.getLife();
            currentLife -= autoDamageTotal;
            enemy.setLife(currentLife);
        }
    }


}
