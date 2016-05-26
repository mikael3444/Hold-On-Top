using UnityEngine;
using System.Collections;

public class potencia : MonoBehaviour
{

    int ver = 1;
     public float forca = 0;
    public float forca2 = 0;
    public PointEffector2D potencimetro;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        forca = Mathf.Clamp(forca, 0f, 5f);
        if (ver == 1)
        {
            transform.Translate(0.5f, 0, 0);
            forca -= 0.1f;
        }
        if (ver == 2)
        {
            forca += 0.1f;
            transform.Translate(-0.5f, 0, 0);

            
        }

        if (Input.GetMouseButtonDown(0))
        {

            transform.Translate(0, 0, 0);

            forca2 = 600f;
            ver = 3;
            potencimetro.forceMagnitude = forca2;
        }

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "barra1")

        {
            ver = 1;
           
        }
        if (coll.gameObject.tag == "barra2")

        {
           
            ver = 2;
        }
    }
}
