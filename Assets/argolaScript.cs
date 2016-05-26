using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class argolaScript : MonoBehaviour {


    public float velocidade;
    public GameObject text;
   
    float tempo = 0f;
    
    void Update()
    {
        transform.Translate(velocidade, 0,0);

        
    }
  
    void OnTriggerEnter2D(Collider2D other)
    {


        if (other.gameObject.tag == "Player")
        {
            
          
            tempo += Time.deltaTime;
            Instantiate(text, new Vector3(transform.position.x,transform.position.y+10,3.5f), Quaternion.identity);
           
            if (tempo > 0.5) {

                Destroy(this);
         
            }

        }
    }
}
