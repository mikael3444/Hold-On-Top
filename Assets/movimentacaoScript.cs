using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class movimentacaoScript : MonoBehaviour
{

    public Rigidbody2D rigd;
    public float cima;
    public float baixo;
    public float direcaoX;
    public int botao;
    //bool estaNoCanhao;
    public float playerX, playerY;
    public float velocidade;


    void Start()
    {

        rigd = GetComponent<Rigidbody2D>();
     //   estaNoCanhao = false;
    }

    float tempo;
    public float gravidade = 10;
    public float velocidadeDirecao = 2;
    
	void Update()
    {
        

        playerX = Input.GetAxis("Horizontal");
        playerY = Input.GetAxis("Vertical");

        if (playerX != 0 || playerY != 0)

        {
            tempo = 0;
            tempo = tempo + Time.deltaTime;
            velocidade = (tempo * gravidade) / tempo;

            transform.position = new Vector2(transform.position.x + velocidadeDirecao * playerX,
            transform.position.y + velocidadeDirecao * playerY + (velocidade * -1));
            GetComponent<Animator>().SetInteger("numero", -1);
        }
        else
        {
            GetComponent<Animator>().SetInteger("numero", 1);
            tempo = 0;
            tempo = tempo + Time.deltaTime;
            transform.position = new Vector2(transform.position.x, transform.position.y + (velocidade * -1));
        }
			
    }
		
}

