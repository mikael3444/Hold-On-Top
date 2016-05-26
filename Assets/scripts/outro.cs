﻿using UnityEngine;
using System.Collections;

public class outro : MonoBehaviour {


    public GameObject explosion;
    Rigidbody2D rgd;
    public GameObject bol;
    Vector2 posbola;
    bool atirou;
    float tempo = 0f, velox = 5f, veloxy = 6f;
    void Start()
    {
        rgd = GetComponent<Rigidbody2D>();
        atirou = false;

    }
    float angle = 90.0f;
    // Update is called once per frame
    void FixedUpdate()
    {


        angle += Input.GetAxis("Vertical") * 10f * Time.deltaTime * 10;
        angle = Mathf.Clamp(angle, -90, 90);
        transform.localRotation = Quaternion.AngleAxis(angle, Vector3.forward);


        if (Input.GetMouseButtonDown(1))
        {
            //atirou = true;
            Instantiate(explosion, explosion.transform.position, Quaternion.identity);
            explosion.SetActive(false);
            GetComponent<PolygonCollider2D>().usedByEffector = true;

            bol.GetComponent<Rigidbody2D>().isKinematic = false;





        }else
        {
            
        }
    }
}
