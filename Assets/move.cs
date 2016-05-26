using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
    public float forca;
	void Start () {
      
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {

           
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, forca));
        }

    
	}

    void OnCollisionEnter2D(Collision2D other)

    {
        if (other.gameObject.tag == "barra1")
        {
            GetComponent<Animator>().SetInteger("num", 1);
        }
        if (other.gameObject.tag == "barra2")
        {
            GetComponent<Animator>().SetInteger("num", -1);
        }
    }
    }
