using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Events;

public class buttonHandler : MonoBehaviour , IPointerEnterHandler, IPointerExitHandler
{
    public AudioSource[] source;
    public Animator animator;
    public Button button;
    public TextMeshProUGUI price;
    public gameManager gameManager;


    int cost;
    public int add;
    public int which;
   public int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(buttonWasClicked);
        source = GameObject.FindGameObjectWithTag("AudioSources").GetComponents<AudioSource>();

    }

    void Update()
    {

        if (index == 1)
        {
            cost = gameManager.cost1;
        }
        if (index == 2)
        {
            cost = gameManager.cost2;
        }
        if (index == 3)
        {
            cost = gameManager.cost3;
        }
        if (index == 4)
        {
            cost = gameManager.cost4;
        }
        if (index == 5)
        {
            cost = gameManager.cost5;
        }

        price.text = cost.ToString();
    }

    // When highlighted with mouse.
    public void OnPointerEnter(PointerEventData eventData)
    {
        source[0].Play();
        animator.SetBool("MouseOnTop", true);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        animator.SetBool("MouseOnTop", false);
      
    }
    
    void buttonWasClicked()
    {


        Debug.Log(index.ToString());
        if ( which == 0)
        {


            gameManager.setAdd(add);
            if (gameManager.addOneClickPower(cost)) {
                cost +=  (cost / 2);
                source[1].Play();

                if (index == 1)
                {
                    gameManager.cost1 = cost;
                }
                if (index == 2)
                {
                    gameManager.cost2 = cost;
                }
                if (index == 3)
                {
                    gameManager.cost3 = cost;
                }
                if (index == 4)
                {
                    gameManager.cost4 = cost;
                }
                if (index == 5)
                {
                    gameManager.cost5 = cost;
                }
            }


        } else if (which == 1)
        {
            gameManager.setAdd(add);
          if (  gameManager.addOneCps(cost))
            {
                source[1].Play();
                cost += (cost / 2);

                if (index == 1)
                {
                    gameManager.cost1 = cost;
                }
                if (index == 2)
                {
                    gameManager.cost2 = cost;
                }
                if (index == 3)
                {
                    gameManager.cost3 = cost;
                }
                if (index == 4)
                {
                    gameManager.cost4 = cost;
                }
                if (index == 5)
                {
                    gameManager.cost5 = cost;
                }
            }
          
         
        }



     
    }

 

}
