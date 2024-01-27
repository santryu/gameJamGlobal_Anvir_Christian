using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class amountDisplay : MonoBehaviour
{

    public gameManager manager;
    TextMeshProUGUI amount;
    // Start is called before the first frame update
    void Start()
    {
        amount = gameObject.GetComponent<TMPro.TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {

        amount.text = manager.amount.ToString();
    }
}
