using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UnlockPos : MonoBehaviour
{
    public VarManager varManager;
    public Monster monster;
    public int pos;
    public Sprite plus;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var evil = varManager.getEvilShard();
        switch (pos)
        {

            case 0:
                if (evil >= 15)
                {
                    monster.appareanceDeployed[pos].sprite = plus;

                }
                break;
            case 1:
                if (evil >= 10)
                {
                    monster.appareanceDeployed[pos].sprite = plus;
                }
                break;
            case 2:
                if (evil >= 5)
                {
                    monster.appareanceDeployed[pos].sprite = plus;
                }
                break;
            case 3:
                if (evil ==0)
                {
                    monster.appareanceDeployed[pos].sprite = plus;
                }
                break;


        }



    }
}
