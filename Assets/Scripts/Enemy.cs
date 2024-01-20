using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{

    public float life;
    public int current;
    public Image appareance;
    public List<EnemyType> listEnemy = new List<EnemyType>();
    public VarManager varManager;

    private EnemyType currentMob;

    // Start is called before the first frame update
    void Start()
    {


        currentMob = listEnemy[0];
        appareance.sprite = listEnemy[0].appearance;
        life = listEnemy[0].life;


    }

    // Update is called once per frame
    void Update()
    {

        if (life <= 0)
        {

            varManager.addGold(currentMob.gold);
            varManager.addEnemyKilled();
            var killed = varManager.getEnemyKilled();
            if (current > 2)
            {
                varManager.addEvilShard();
            }


            //respawn new enemy here
            current = Random.Range(0, 6);
            appareance.sprite = listEnemy[current].appearance;
            life = listEnemy[current].life+killed*2;
            currentMob = listEnemy[current];

        }
        







    }


    public float getLife() {  return life; }
    public void setLife(float life) {  this.life = life; }
}
