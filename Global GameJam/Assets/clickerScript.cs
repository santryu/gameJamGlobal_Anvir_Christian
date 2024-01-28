using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickerScript : MonoBehaviour
{
    public Animator animator;
    public GameObject clickParticlePrefab;
    public gameManager manager;
    public AudioSource[] clickSound;
    // Start is called before the first frame update
    void Start()
    {
        
        clickSound= GetComponents<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }


    private void OnMouseDown()
    {

        int sound = Random.Range(0, clickSound.Length);

        clickSound[sound].Play();
    Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        mousePos = new Vector3(mousePos.x, mousePos.y, 0);

        Instantiate(clickParticlePrefab,mousePos,Quaternion.identity);

        manager.amount += manager.clickPower;

        animator.SetTrigger("wasClicked");


        



    }


}
