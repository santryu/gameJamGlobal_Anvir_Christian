using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleAnimation : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    Rigidbody2D body;
    float timeToDisapear = 1f;
    public Sprite[] spriteArray;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        body = gameObject.GetComponent<Rigidbody2D>();
        body.velocity = new Vector3(0, 1, 0);
        body.angularVelocity = 30;

        int whichSprite = (Random.Range(0, spriteArray.Length));

        spriteRenderer.sprite = spriteArray[whichSprite];


    }

    float transparency=1;
    float timer;
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

         transparency += (-1 / timeToDisapear) * Time.deltaTime;
       
     
        Color test = new Color(1.0f, 0.9063347f, 0, transparency);

        if (transparency <= 0)
        {
            Debug.Log(timer.ToString());
            Destroy(gameObject);
         
           
        }

        spriteRenderer.color = test;
        

    }
}
