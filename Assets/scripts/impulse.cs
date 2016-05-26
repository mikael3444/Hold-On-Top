using UnityEngine;
using System.Collections;

public class impulse : MonoBehaviour
{
   
    Rigidbody2D rgd;
    void Start()
    {
        rgd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
       // transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")

        {
           // rgd = coll.transform.GetComponent<Rigidbody2D>();
          //  rgd.AddRelativeForce (new Vector2(5, 5),ForceMode2D.
          //      Impulse);

        }
    }

}