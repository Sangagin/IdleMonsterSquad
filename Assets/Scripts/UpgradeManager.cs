using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class UpgradeManager : MonoBehaviour
{


    public List<int> upgradesClick = new List<int>();
    public List<int> upgradesAuto = new List<int>();
    // Start is called before the first frame update
    void Start()
    {
        int[] init = { 0, 0, 0, 0, 0, };
        upgradesClick = new List<int>(init);
        upgradesAuto = new List<int>(init);

    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public List<int> getUpgradesClick() { return upgradesClick; }
    public List<int> getUpgradesAuto() { return upgradesAuto; }

    public void setUpgradesClick(List<int> update) { upgradesClick = update; }
    public void setUpgradesAuto(List<int> update) { upgradesAuto = update; }


}
