using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gerenciadordePontos : MonoBehaviour {

	public Text textoNumerosPontuacao;
	public static int pontos = 0;
	public GameObject argola;
	public argolaScript argScript;


	public GameObject estrela1;
	public GameObject estrela2;
	//public GameObject estrela3;
	//public GameObject estrela4;
	//public GameObject estrela5;

	void Start () 
	{


		//textoNumerosPontuacao.GetComponent<Text> ();
		//textoNumerosPontuacao.text = "pontos: " + pontos;
	}
	

	void Update () 
	{

//		textoNumerosPontuacao.text = "pontos: " +pontos;
	}

	void OnTriggerEnter2D(Collider2D other)
	{
	
		if(other.gameObject.tag == "Argola")
		{

			//print ("Colidiu");
			pontos ++;
		}

		if(other.gameObject == estrela1)
		{

			estrela1.transform.position =  new Vector2(-14, 42);

		}

		if (other.gameObject == estrela2) 
		{
		
			estrela2.transform.position = new Vector2 (-10, 42);
		}
	}
}
