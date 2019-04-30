using UnityEngine;
using UnityEngine.UI;
﻿using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using Image = UnityEngine.Experimental.UIElements.Image;
using Object = UnityEngine.Object;


public class Player : MonoBehaviour {
    public float forcaPulo = 2;
    public float velocidadeMaxima = 4;
    public int moedas, vidas;
    public Text TextLives;
    public Text TextMoedas;
    public bool estaNoChao;
    public bool ferramenta;
    public bool lado_direito;
    public GameObject PainelGameOver;
    public GameObject PainelInicio;
    public Button button_inicio;
    public Button button_GameOver;
    public Text text_inicio;
    public LayerMask LayerMaskPlatform;
    public LayerMask LayerMaskMonsters;
    public GameObject LastCheckpoint;
    private float distToGround;
    public GameObject ferramenta_folha, ferramenta_peixe, ferramenta_pareto, ferramenta_histograma, ferramenta_fluxograma, ferramenta_carta, ferramenta_dispersao;
    public GameObject raw_folha, raw_peixe, raw_pareto, raw_histograma, raw_fluxograma, raw_carta, raw_dispersao;
    public GameObject painel_folha, painel_peixe, painel_pareto, painel_histograma, painel_fluxograma, painel_carta, painel_dispersao;
    public bool folha = false, peixe = false, pareto = false, histograma = false, fluxograma = false, carta = false, dispersao = false;
    public Text text_folha, text_peixe, text_pareto, text_histograma, text_fluxograma, text_carta, text_dispersao;
    public Button button_sim_folha, button_sim_peixe, button_sim_pareto, button_sim_histograma, button_sim_fluxograma, button_sim_carta, button_sim_dispersao;
    public Button button_não_folha, button_não_peixe, button_não_pareto, button_não_histograma, button_não_fluxograma, button_não_carta, button_não_dispersao;

	// Use this for initialization
	void Start () {
		moedas = 0;
		vidas = 3;
		ferramenta = true;
        button_GameOver.onClick.AddListener(GameOver);
        button_inicio.onClick.AddListener(Inicio);
		TextLives.text = vidas.ToString();
		TextMoedas.text = moedas.ToString();
        PainelInicio.SetActive(true);
        text_inicio.text = "A equipe de desenvolvimento do Qualif necessita realizar um mapeamento dos possíveis problemas do aplicativo, para isso pretende utilizar uma ferramenta que possibilite visualizar as causas e seus possiveis efeitos. Sua missão é encontrar a ferramenta de software adequada e levá-la até a equipe para auxiliá-los. Porém, tome cuidado, pois você irá encontrar várias ferramentas, entretanto, somente uma é a solução da sua missão. Boa sorte!";
        text_folha.text = "SE VOCÊ ACHA QUE ESSA É A FERRAMENTA UTILIZADA PARA MAPEAR AS CAUSAS E EFEITOS, CLIQUE EM 'SIM' E LEVE ATÉ A EQUIPE DE SOFTWARE.";
        text_peixe.text = "SE VOCÊ ACHA QUE ESSA É A FERRAMENTA UTILIZADA PARA MAPEAR AS CAUSAS E EFEITOS, CLIQUE EM 'SIM' E LEVE ATÉ A EQUIPE DE SOFTWARE.";
        text_pareto.text = "SE VOCÊ ACHA QUE ESSA É A FERRAMENTA UTILIZADA PARA MAPEAR AS CAUSAS E EFEITOS, CLIQUE EM 'SIM' E LEVE ATÉ A EQUIPE DE SOFTWARE.";
        text_histograma.text = "SE VOCÊ ACHA QUE ESSA É A FERRAMENTA UTILIZADA PARA MAPEAR AS CAUSAS E EFEITOS, CLIQUE EM 'SIM' E LEVE ATÉ A EQUIPE DE SOFTWARE.";
        text_fluxograma.text = "SE VOCÊ ACHA QUE ESSA É A FERRAMENTA UTILIZADA PARA MAPEAR AS CAUSAS E EFEITOS, CLIQUE EM 'SIM' E LEVE ATÉ A EQUIPE DE SOFTWARE.";
        text_carta.text = "SE VOCÊ ACHA QUE ESSA É A FERRAMENTA UTILIZADA PARA MAPEAR AS CAUSAS E EFEITOS, CLIQUE EM 'SIM' E LEVE ATÉ A EQUIPE DE SOFTWARE.";
        text_dispersao.text = "SE VOCÊ ACHA QUE ESSA É A FERRAMENTA UTILIZADA PARA MAPEAR AS CAUSAS E EFEITOS, CLIQUE EM 'SIM' E LEVE ATÉ A EQUIPE DE SOFTWARE.";
}

    void GameOver(){
         SceneManager.LoadScene("TelaJogo");
    }

    void Inicio(){
         PainelInicio.SetActive(false);
    }
	
	// Update is called once per frame
	void FixedUpdate () {
		Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
		float movimento = Input.GetAxis("Horizontal");
		lado_direito = transform.localScale.x > 0;
		rigidbody.velocity = new Vector2(movimento*velocidadeMaxima, rigidbody.velocity.y);
        if (vidas <0){
            TextLives.text = "0";
           PainelGameOver.SetActive(true);
        }
		if (Input.GetKeyDown(KeyCode.Space)){
			if (estaNoChao==true){
				rigidbody.AddForce(new Vector2(0,450));
			    GetComponent<Animator>().SetBool("jump", true);
			}

		}
		else{
			GetComponent<Animator>().SetBool("jump", false);
		}
		if (Input.GetKeyDown(KeyCode.LeftControl)){
			if (ferramenta==true){
				GetComponent<Animator>().SetTrigger("espada");
				Collider2D[] colliders = new Collider2D[3];
				transform.Find("SquareEspada").gameObject.GetComponent<Collider2D>()
					.OverlapCollider(new ContactFilter2D(), colliders);
				for (int i = 0; i<colliders.Length; i++){
					if(colliders[i]!=null && colliders[i].gameObject.CompareTag("Monstro"))
					{
						Destroy(colliders[i].gameObject);
					}
				}

			}
		}
		GetComponent<Animator>().SetBool("run", movimento != 0);
        if (movimento <0 || movimento>0){

       			 if (movimento> 0 && !lado_direito)
       			 {
       			lado_direito = !lado_direito;
     			Vector3 theScale = transform.localScale;
      			theScale.x *= -1;
      			transform.localScale = theScale;

        }
        else if (movimento < 0 && lado_direito)
        {
        		lado_direito = !lado_direito;
     			Vector3 theScale = transform.localScale;
      			theScale.x *= -1;
      			transform.localScale = theScale;
        }
          GetComponent<Animator>().SetBool("run", true);

        }
        else{   
            GetComponent<Animator>().SetBool("run", false);
        }
        /*if (estaNoChao = true){
        	  GetComponent<Animator>().SetBool("jump", false);
        }
        else{
       	  GetComponent<Animator>().SetBool("jump", true);

        }*/
	}

	void OnCollisionEnter2D(Collision2D collision2D){
		if (collision2D.gameObject.CompareTag("Moeda")){
			Destroy(collision2D.gameObject);
			moedas++;
			TextMoedas.text = moedas.ToString();
		}
		if (collision2D.gameObject.CompareTag("Vida")){
			Destroy(collision2D.gameObject);
		}

		if (collision2D.gameObject.CompareTag("Flutuante")){
			Destroy(collision2D.gameObject);
			vidas++;
			TextLives.text = vidas.ToString();
		}

		if (collision2D.gameObject.CompareTag("FerramentaPeixe")){
			Destroy(collision2D.gameObject);
			ferramenta = true;
		}

		if (collision2D.gameObject.CompareTag("Ferramenta")){
			Destroy(collision2D.gameObject);
			ferramenta = true;
		}


		if (collision2D.gameObject.CompareTag("Plataforma")){
			estaNoChao = true;
		}

        if (collision2D.gameObject.CompareTag("Espinho")) {
            vidas--;
            TextLives.text = vidas.ToString();
            transform.position = LastCheckpoint.transform.position;
        }
        if (collision2D.gameObject.CompareTag("Monstro")) {
            vidas--;
            TextLives.text = vidas.ToString();
            transform.position = LastCheckpoint.transform.position;
        }

	}

	void OnTriggerEnter2D(Collider2D collision2D){        
        if (collision2D.gameObject.CompareTag("CheckPoint"))
        {
            LastCheckpoint = collision2D.gameObject;
        }
        if (collision2D.gameObject.CompareTag("CheckInicial")) {
            LastCheckpoint = collision2D.gameObject;
        }
    }    

    /*void OnTriggerExit2D(Collider2D collision2D){        
        if (collision2D.gameObject.CompareTag("CheckPoint"))
        {
            estaNoChao = false;
        }
        if (collision2D.gameObject.CompareTag("Obstaculo")){
			estaNoChao = false;
		}
    }  */  


	void OnCollisionExit2D(Collision2D collision2D){
		if (collision2D.gameObject.CompareTag("Plataforma")){
			estaNoChao = false;
		}

		/*if (collision2D.gameObject.CompareTag("Obstaculo")){
			estaNoChao = false;
		}

		if (collision2D.gameObject.CompareTag("CheckInicial")){
			estaNoChao = false;
		}*/


	}

	 bool IsGrounded()
    {
        Vector3 pos = transform.position;
        Debug.DrawRay(pos, Vector3.down * distToGround, Color.green, 1f);
        RaycastHit2D hit = Physics2D.Raycast(pos, Vector3.down, distToGround, LayerMaskPlatform);
        bool grounded = hit.collider != null;
        GetComponent<Animator>().SetBool("grounded", grounded);
        return grounded;
    }
}
