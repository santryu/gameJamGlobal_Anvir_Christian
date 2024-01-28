using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class saveData : MonoBehaviour
{

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
    }

    public void LoadData()
    {
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
