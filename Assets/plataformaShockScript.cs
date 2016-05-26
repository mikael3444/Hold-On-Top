using UnityEngine;
using System.Collections;

public class plataformaShockScript : MonoBehaviour
{

	public float velocidade;
	public movimentacaoScript movimentoPlayer;
	public float tempo;
	public float tempoPoder;
	public int marcadorDoShock;
	bool ativadorTempo;
	bool colidiuComPlayer;
     public SpriteRenderer renderer;
	void Start () 
	{


        ativadorTempo = false;

    }
	

	void Update () 
	{
        
        transform.Translate (velocidade, 0, 0);
		tempo += Time.deltaTime;
     
        if (ativadorTempo) 
		{
            
            tempoPoder = tempo + Time.deltaTime;
			ativadorTempo = false;
		}

		if (colidiuComPlayer) 
		{
            
          
            
			if (tempo - tempoPoder < marcadorDoShock) 
			{
		
				movimentoPlayer.velocidadeDirecao = 0.6f;
                renderer.material.color = new Color(1, 0, 0, 1);
            }

			else 
			{
                renderer.material.color = new Color(1, 1, 1, 1);
                movimentoPlayer.velocidadeDirecao = 1f;
				tempoPoder = 0;
				colidiuComPlayer = false;
			}
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{

		if (other.gameObject.tag == "Player") 
		{

			ativadorTempo = true;
			colidiuComPlayer = true;
			print ("Colidiu com a plataforma");
		}
	}
}
