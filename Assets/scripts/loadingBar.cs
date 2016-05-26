using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class loadingBar : MonoBehaviour {
 
    public Transform loadingbarra;
    float pontos;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        pontos = gerenciadordePontos.pontos;
       loadingbarra.transform.GetComponent<Image>().fillAmount =pontos  / 100;


    }
}
