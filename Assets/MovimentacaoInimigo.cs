using UnityEngine;
using System.Collections;

public class MovimentacaoInimigo : MonoBehaviour {

    public float velocidade;
    bool ver = true;
    void Update()

    {
       
           

    }
    void OnCollisionEnter2D(Collision2D other)
    {

        if(other.gameObject.tag == "up")
        {
            transform.Translate(0, -velocidade, 0);
         
        }


        if (other.gameObject.tag == "down")
        {
            transform.Translate(0, velocidade, 0);
            
        }
    }
    }
