using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

using UnityEngine.UI;
public class buttonAnimationHandler : MonoBehaviour
{
    public Button Button;
    public Image sprite;
    public TextMeshProUGUI title;
    public TextMeshProUGUI comment;
    public TextMeshProUGUI price;
    public gameManager gameManager;
   public int cost;
    public int add;
    public int which;
    // Start is called before the first frame update
    void Start()
    {
        Button.onClick.AddListener(buttonWasClicked);
    }

    // Update is called once per frame
    void Update()
    {

    }


    void buttonWasClicked()
    {
        if ( which == 0)
        {
            gameManager.setAdd(add);
            gameManager.addOneClickPower(cost);
        } else if (which == 1)
        {
            gameManager.setAdd(add);
            gameManager.addOneCps(cost);
        }
    }


}
