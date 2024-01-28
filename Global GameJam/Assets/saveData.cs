using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class saveData : MonoBehaviour
{


    public buttonHandler buttonHandler;

    public gameManager manager;
    // Start is called before the first frame update
    void Start()
    {
   

        LoadData();
    }
    public void SaveData()
    {
        PlayerPrefs.SetFloat("Amount", manager.amount);
        PlayerPrefs.SetFloat("perSecond", manager.cookiesPerSec);
        PlayerPrefs.SetFloat("clickPower", manager.clickPower);
        PlayerPrefs.SetInt("1", manager.cost1);
        PlayerPrefs.SetInt("2", manager.cost2);
        PlayerPrefs.SetInt("3", manager.cost3);
        PlayerPrefs.SetInt("4", manager.cost4);
        PlayerPrefs.SetInt("5", manager.cost5);
    }

    public void LoadData()
    {

        manager.cost1 = PlayerPrefs.GetInt("1");
        manager.cost2 = PlayerPrefs.GetInt("2");
        manager.cost3 = PlayerPrefs.GetInt("3");
        manager.cost4 = PlayerPrefs.GetInt("4");
        manager.cost5 = PlayerPrefs.GetInt("5");

        manager.amount = PlayerPrefs.GetFloat("Amount");
        manager.cookiesPerSec = PlayerPrefs.GetFloat("perSecond");
        manager.clickPower = PlayerPrefs.GetFloat("clickPower");

    }

    void OnApplicationQuit()
    {
        SaveData();
        Debug.Log("Application ending after " + Time.time + " seconds");
    }
    public void DeleteData()
    {
        PlayerPrefs.DeleteAll();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
