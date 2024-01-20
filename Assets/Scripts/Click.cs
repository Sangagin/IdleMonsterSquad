using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Click : MonoBehaviour
{
    public Enemy enemy;
    public VarManager varManager;
    public Slider sliderLife;

    public void clickOnEnemy()
    {


        var currentLife = enemy.getLife();
        var currentClickDamage = varManager.getClickDamageTotal();
        currentLife -= currentClickDamage;
        enemy.setLife(currentLife);
        sliderLife.value = currentLife;



    }
}
