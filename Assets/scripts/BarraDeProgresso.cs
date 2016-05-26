using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class BarraDeProgresso : MonoBehaviour {
    
    public StatusBarra _StatusBarra;
    public GameObject barraDeProgresso;
    public Text textoProgresso;
    public float MaxProgresso;
    public float ValorAtual;
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        _StatusBarra = this.GetComponent<StatusBarra>();
        barraDeProgresso.transform.localScale = new Vector3(_StatusBarra.PegarTamanhoBarra(ValorAtual, MaxProgresso), barraDeProgresso.transform.localScale.y, barraDeProgresso.transform.localScale.z);
        textoProgresso.text = _StatusBarra.PegarPorcentagemBarra(ValorAtual, MaxProgresso, 100) + "%";
        if (ValorAtual < MaxProgresso) {
            ValorAtual = gerenciadordePontos.pontos;
        } else {

            textoProgresso.text = "2X";
         }
    } }
