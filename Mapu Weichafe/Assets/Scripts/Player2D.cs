using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2D : MonoBehaviour
{
    
    float velocidadX;
    float Fsalto = 8f;
    int limiteSaltos = 1;
    int saltosHechos;

    Rigidbody2D rb2D;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        velocidadX = 0f;

        if (Input.GetKey(KeyCode.D))
        {
            if (GetComponent<SpriteRenderer>().flipX==true)
            {
                GetComponent<SpriteRenderer>().flipX = false;
            }

            GetComponent<Animator>().SetBool("correr",true);
            velocidadX = 4f;
        }  

        if (Input.GetKey(KeyCode.A))
        {
            if (GetComponent<SpriteRenderer>().flipX==false)
            {
                GetComponent<SpriteRenderer>().flipX = true;
            }

            GetComponent<Animator>().SetBool("correr",true);
            velocidadX = -4f;
        }  

        transform.Translate(velocidadX*Time.deltaTime, 0f, 0f);

        if (velocidadX == 0f)
        {
            GetComponent<Animator>().SetBool("correr", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(saltosHechos<limiteSaltos)
            { 
            rb2D.AddForce(new Vector2(0f,Fsalto), ForceMode2D.Impulse);
            saltosHechos++;
            }
        }

    }

    void OnCollisionEnter2D(Collision2D colliison)
    {
        if (colliison.gameObject.tag == "Ground")
        {
            saltosHechos = 0;
        }
    }
}
