using UnityEngine;
using System.Collections;

public class movimentoBackground : MonoBehaviour {

	public float velocidade;

	void Start () {
	
	}
	

	void Update () {
		
		Vector2 ofset = new Vector2(Time.time*velocidade,0);
		GetComponent<Renderer>().material.mainTextureOffset = ofset;
	}
}
