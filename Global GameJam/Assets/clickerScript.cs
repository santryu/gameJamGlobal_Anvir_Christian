using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickerScript : MonoBehaviour
{
    public Animator animator;
    public GameObject clickParticlePrefab;
    public gameManager manager;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }


    private void OnMouseDown()
    {
    Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        mousePos = new Vector3(mousePos.x, mousePos.y, 0);

        Instantiate(clickParticlePrefab,mousePos,Quaternion.identity);

        manager.amount += manager.clickPower;

        animator.SetTrigger("wasClicked");


        



    }


}
