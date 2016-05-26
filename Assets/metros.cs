using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class metros : MonoBehaviour {

    float tempoM = 0;
    public Text texto;
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        tempoM += Time.deltaTime*8;
        texto.text = "" + Mathf.Round(tempoM)+"m"+"/580m";

    }
}
