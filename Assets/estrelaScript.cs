using UnityEngine;
using System.Collections;

public class estrelaScript : MonoBehaviour {


	public float velocidade;
	

	void Update () 
	{

		transform.Translate(velocidade, 0,0);
	}

	void OnTriggerEnter2D(Collider2D other)
	{

		if (other.gameObject.tag == "Player") 
		{

			velocidade = 0;
		}
	}

}
