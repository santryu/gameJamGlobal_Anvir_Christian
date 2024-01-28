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

   public int cost;
    public int add;
    public int which;
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(buttonWasClicked);
        source = GameObject.FindGameObjectWithTag("AudioSources").GetComponents<AudioSource>();
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
    
        if ( which == 0)
        {
            gameManager.setAdd(add);
            if (gameManager.addOneClickPower(cost)) {
                cost += ((int)cost / 2);
                source[1].Play();
            }
                
        
        } else if (which == 1)
        {
            gameManager.setAdd(add);
          if (  gameManager.addOneCps(cost))
            {
                source[1].Play();
                cost += ((int)cost / 2);
            }
          
         
        }

        price.text = cost.ToString();
    }

 

}
