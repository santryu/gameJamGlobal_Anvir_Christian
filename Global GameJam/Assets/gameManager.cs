using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
public class gameManager : MonoBehaviour
{
    public float amount = 0;
    public float cookiesPerSec=0;
    float timer =0f;
    public clickerScript clicker;
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


    public void addOneClickPower()
    {

        if (amount >=100)
        {
            amount -= 100;
            clicker.clickPower += 1;
        }


    }
}
