using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StatusBarra : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public float PegarTamanhoBarra(float MinValor,float MaxValor)
    {
        return MinValor / MaxValor;
    }
    public int PegarPorcentagemBarra(float MinValor, float MaxValor,int fator)
    {

        return Mathf.RoundToInt(PegarTamanhoBarra(MinValor, MaxValor) * fator);
    }
}
