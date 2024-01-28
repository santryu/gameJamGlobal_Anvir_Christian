using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class amountPerSecondDisplay : MonoBehaviour
{
    public gameManager manager;
    TextMeshProUGUI amountPerSecond;
    // Start is called before the first frame update
    void Start()
    {
        amountPerSecond = gameObject.GetComponent<TMPro.TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        string text = manager.cookiesPerSec.ToString();
        text += " per second";
        amountPerSecond.text = text;
    }
}
