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

   void Update()
    {
        if (deleteData == true)
        {
            DeleteData();
        }
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
        manager.clickPower = 1;
        manager.amount = 0;
       manager.cookiesPerSec=0;
    }

  public  bool deleteData = false;
 
}
