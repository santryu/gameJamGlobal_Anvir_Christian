using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
public class gameManager : MonoBehaviour
{

    public int cost1 = 100;
    public int cost2 = 150;
    public int cost3 = 500;
    public int cost4 = 500;
    public int cost5 = 1000;
    public float amount = 0;
    public float cookiesPerSec=0;
    float timer =0f;
    public float clickPower = 1;
  
    // Start is called before the first frame update
    void Start()
    {
        



    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;


        if (timer >= 1.0f) {

            amount += cookiesPerSec;
            timer = 0;
        }
    
    }

    int add = 1;
    public bool addOneClickPower(int cost)
    {

        if (amount >=cost)
        {
            amount -= cost;
           clickPower += add;
            add = 0;
            return true;
        }
        return false;

    }
    public void setAdd(int add_)
    {
        add = add_;
    }


    public bool addOneCps(int cost)
    {

        
        if (amount >= cost)
        {
            amount -= cost;
            cookiesPerSec += add;
            add = 0;
            return true;
        }

        return false;
    }


}
