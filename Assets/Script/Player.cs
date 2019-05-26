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
    public LayerMask LayerMaskPlatform;
    public LayerMask LayerMaskMonsters;
    public GameObject LastCheckpoint, obj_botoes, obj_botoes2;
    private float distToGround;
    public GameObject ferramenta_folha, ferramenta_peixe, ferramenta_pareto, ferramenta_histograma, ferramenta_fluxograma, ferramenta_carta, ferramenta_dispersao;
    public GameObject raw_folha, raw_peixe, raw_pareto, raw_histograma, raw_fluxograma, raw_carta, raw_dispersao;
    public GameObject painel_folha, painel_peixe, painel_pareto, painel_histograma, painel_fluxograma, painel_carta, painel_dispersao, painel_fimJogo, painel_Vitoria, painel_equipe, painel_pause, painel_regras;
    public bool folha = false, peixe = false, pareto = false, histograma = false, fluxograma = false, carta = false, dispersao = false;
    public Text text_fimJogo, text_Vitoria;
    public Button button_sim_folha, button_sim_peixe, button_sim_pareto, button_sim_histograma, button_sim_fluxograma, button_sim_carta, button_sim_dispersao;
    public Button button_não_folha, button_não_peixe, button_não_pareto, button_não_histograma, button_não_fluxograma, button_não_carta, button_não_dispersao;
    public Button button_sim, button_nao, button_fimJogo, button_Vitoria, button_pause, button_continuar, button_sair;
    public bool pause = false;
    public Button button_esquerda, button_direita, button_pular, button_espada, button_regras, button_fecharRegras;
    public Rigidbody2D rigidbody;
    public float movimento;
	// Use this for initialization
	void Start () {
		moedas = 0;
		vidas = 3;
        Time.timeScale = 0;
		ferramenta = true;
        button_GameOver.onClick.AddListener(GameOver);
        button_inicio.onClick.AddListener(Inicio);
        button_sim_folha.onClick.AddListener(SimFolha); 
        button_sim_peixe.onClick.AddListener(SimPeixe); 
        button_sim_pareto.onClick.AddListener(SimPareto); 
        button_sim_histograma.onClick.AddListener(SimHistograma); 
        button_sim_fluxograma.onClick.AddListener(SimFluxograma); 
        button_sim_carta.onClick.AddListener(SimCarta); 
        button_sim_dispersao.onClick.AddListener(SimDispersao);
        button_não_folha.onClick.AddListener(NãoFolha); 
        button_não_peixe.onClick.AddListener(NãoPeixe); 
        button_não_pareto.onClick.AddListener(NãoPareto); 
        button_não_histograma.onClick.AddListener(NãoHistograma); 
        button_não_fluxograma.onClick.AddListener(NãoFluxograma); 
        button_não_carta.onClick.AddListener(NãoCarta); 
        button_não_dispersao.onClick.AddListener(NãoDispersao);
        button_sim.onClick.AddListener(SimEquipe);
        button_nao.onClick.AddListener(NaoEquipe);
        button_fimJogo.onClick.AddListener(FimJogo);
        button_Vitoria.onClick.AddListener(FimJogo);
        button_sair.onClick.AddListener(FimJogo);
        button_espada.onClick.AddListener(Espada);
        button_pular.onClick.AddListener(Pular);
        button_regras.onClick.AddListener(Regras);
        button_fecharRegras.onClick.AddListener(FecharRegras);
        //button_esquerda.onClick.AddListener(Esquerda);
       // button_direita.onClick.AddListener(Direita);
        button_pause.onClick.AddListener(Pause);
        button_continuar.onClick.AddListener(Continuar);
		TextLives.text = vidas.ToString();
		TextMoedas.text = moedas.ToString();
        PainelInicio.SetActive(true);
        obj_botoes2.SetActive(false);
        obj_botoes.SetActive(false);
        
}

    void Regras(){
        painel_regras.SetActive(true);
    }

    void FecharRegras(){
        painel_regras.SetActive(false);
    }

    void GameOver(){
         SceneManager.LoadScene("TelaJogo");
    }

    void Pause(){
            painel_pause.SetActive(true);
            Time.timeScale = 0;
            obj_botoes.SetActive(false);
            obj_botoes2.SetActive(false);
        raw_folha.SetActive(false);
        raw_peixe.SetActive(false);
        raw_pareto.SetActive(false);
        raw_histograma.SetActive(false);
        raw_fluxograma.SetActive(false);
        raw_carta.SetActive(false);
        raw_dispersao.SetActive(false);
    }

    void Espada(){
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


    void Pular(){
			if (estaNoChao==true){
				rigidbody.AddForce(new Vector2(0,450));
			    GetComponent<Animator>().SetBool("jump", true);
			}
    }

    void Continuar(){
            painel_pause.SetActive(false);
            Time.timeScale = 1;
        obj_botoes.SetActive(true);
        obj_botoes2.SetActive(true);
        if (folha == true){
            raw_folha.SetActive(true);
        }
        if (pareto == true){
            raw_pareto.SetActive(true);
        }
        if (peixe == true){
            raw_peixe.SetActive(true);
        }
        if (histograma == true){
            raw_histograma.SetActive(true);
        } 
        if (fluxograma == true){
            raw_fluxograma.SetActive(true);
        }  
        if (dispersao == true){
            raw_dispersao.SetActive(true);
        } 
        if (carta == true){
            raw_carta.SetActive(true);
        } 
    }

    void FimJogo(){
         SceneManager.LoadScene("TelaJogo");
        obj_botoes.SetActive(false);
        obj_botoes2.SetActive(false);
    }

    void Inicio(){
         PainelInicio.SetActive(false);
            Time.timeScale = 1;
        obj_botoes.SetActive(true);
        obj_botoes2.SetActive(true);
    }

    void SimEquipe(){
        painel_equipe.SetActive(false);
         Time.timeScale = 0;
        if (peixe == true){
           painel_Vitoria.SetActive(true);
        }
        else{
           painel_fimJogo.SetActive(true);
        }
    }

    void NaoEquipe(){
        painel_equipe.SetActive(false);
        obj_botoes.SetActive(true);
        obj_botoes2.SetActive(true);
            movimento = 0;
        if (folha == true){
            raw_folha.SetActive(true);
        }
        if (pareto == true){
            raw_pareto.SetActive(true);
        }
        if (peixe == true){
            raw_peixe.SetActive(true);
        }
        if (histograma == true){
            raw_histograma.SetActive(true);
        } 
        if (fluxograma == true){
            raw_fluxograma.SetActive(true);
        }  
        if (dispersao == true){
            raw_dispersao.SetActive(true);
        } 
        if (carta == true){
            raw_carta.SetActive(true);
        }   
    }

    void SimFolha(){
        painel_folha.SetActive(false);
        ferramenta_folha.SetActive(false);
        ferramenta_peixe.SetActive(true);
        ferramenta_pareto.SetActive(true);
        ferramenta_histograma.SetActive(true);
        ferramenta_fluxograma.SetActive(true);
        ferramenta_carta.SetActive(true);
        ferramenta_dispersao.SetActive(true);
        raw_folha.SetActive(true);
        raw_peixe.SetActive(false);
        raw_pareto.SetActive(false);
        raw_histograma.SetActive(false);
        raw_fluxograma.SetActive(false);
        raw_carta.SetActive(false);
        raw_dispersao.SetActive(false);
        folha = true;
        peixe = false;
        pareto = false; 
        histograma = false;
        fluxograma = false;
        carta = false;
        dispersao = false; 
        obj_botoes.SetActive(true); 
        obj_botoes2.SetActive(true);
            movimento = 0;           
    }

    void NãoFolha(){
        painel_folha.SetActive(false); 
        obj_botoes.SetActive(true);
        obj_botoes2.SetActive(true);
            movimento = 0; 
        if (folha == true){
            raw_folha.SetActive(true);
        }
        if (pareto == true){
            raw_pareto.SetActive(true);
        }
        if (peixe == true){
            raw_peixe.SetActive(true);
        }
        if (histograma == true){
            raw_histograma.SetActive(true);
        } 
        if (fluxograma == true){
            raw_fluxograma.SetActive(true);
        }  
        if (dispersao == true){
            raw_dispersao.SetActive(true);
        } 
        if (carta == true){
            raw_carta.SetActive(true);
        }      
    }

    void SimPeixe(){
        painel_peixe.SetActive(false);
        ferramenta_folha.SetActive(true);
        ferramenta_peixe.SetActive(false);
        ferramenta_pareto.SetActive(true);
        ferramenta_histograma.SetActive(true);
        ferramenta_fluxograma.SetActive(true);
        ferramenta_carta.SetActive(true);
        ferramenta_dispersao.SetActive(true);
        raw_folha.SetActive(false);
        raw_peixe.SetActive(true);
        raw_pareto.SetActive(false);
        raw_histograma.SetActive(false);
        raw_fluxograma.SetActive(false);
        raw_carta.SetActive(false);
        raw_dispersao.SetActive(false);
        folha = false;
        peixe = true;
        pareto = false; 
        histograma = false;
        fluxograma = false;
        carta = false;
        dispersao = false; 
        obj_botoes.SetActive(true);    
        obj_botoes2.SetActive(true); 
            movimento = 0;            
    }

    void NãoPeixe(){
        painel_peixe.SetActive(false);      
        obj_botoes.SetActive(true);   
        obj_botoes2.SetActive(true); 
            movimento = 0;   
        if (folha == true){
            raw_folha.SetActive(true);
        }
        if (pareto == true){
            raw_pareto.SetActive(true);
        }
        if (peixe == true){
            raw_peixe.SetActive(true);
        }
        if (histograma == true){
            raw_histograma.SetActive(true);
        } 
        if (fluxograma == true){
            raw_fluxograma.SetActive(true);
        }  
        if (dispersao == true){
            raw_dispersao.SetActive(true);
        } 
        if (carta == true){
            raw_carta.SetActive(true);
        }      
    }

    void SimPareto(){
        painel_pareto.SetActive(false);
        ferramenta_folha.SetActive(true);
        ferramenta_peixe.SetActive(true);
        ferramenta_pareto.SetActive(false);
        ferramenta_histograma.SetActive(true);
        ferramenta_fluxograma.SetActive(true);
        ferramenta_carta.SetActive(true);
        ferramenta_dispersao.SetActive(true);
        obj_botoes2.SetActive(true);     
        raw_folha.SetActive(false);
        raw_peixe.SetActive(false);
        raw_pareto.SetActive(true);
        raw_histograma.SetActive(false);
        raw_fluxograma.SetActive(false);
        raw_carta.SetActive(false);
        raw_dispersao.SetActive(false);
        folha = false;
        peixe = false;
        pareto = true; 
        histograma = false;
        fluxograma = false;
        carta = false;
        dispersao = false;  
        obj_botoes.SetActive(true); 
            movimento = 0;          
    }

    void NãoPareto(){
        painel_pareto.SetActive(false); 
        obj_botoes.SetActive(true);
        obj_botoes2.SetActive(true); 
            movimento = 0; 
        if (folha == true){
            raw_folha.SetActive(true);
        }
        if (pareto == true){
            raw_pareto.SetActive(true);
        }
        if (peixe == true){
            raw_peixe.SetActive(true);
        }
        if (histograma == true){
            raw_histograma.SetActive(true);
        } 
        if (fluxograma == true){
            raw_fluxograma.SetActive(true);
        }  
        if (dispersao == true){
            raw_dispersao.SetActive(true);
        } 
        if (carta == true){
            raw_carta.SetActive(true);
        }                
    }


    void SimHistograma(){
        painel_histograma.SetActive(false);
        ferramenta_folha.SetActive(true);
        ferramenta_peixe.SetActive(true);
        ferramenta_pareto.SetActive(true);
        ferramenta_histograma.SetActive(false);
        ferramenta_fluxograma.SetActive(true);
        ferramenta_carta.SetActive(true);
        ferramenta_dispersao.SetActive(true);
        raw_folha.SetActive(false);
        raw_peixe.SetActive(false);
        raw_pareto.SetActive(false);
        obj_botoes2.SetActive(true);     
        raw_histograma.SetActive(true);
        raw_fluxograma.SetActive(false);
        raw_carta.SetActive(false);
        raw_dispersao.SetActive(false);
        folha = false;
        peixe = false;
        pareto = false; 
        histograma = true;
        fluxograma = false;
        carta = false;
        dispersao = false; 
        obj_botoes.SetActive(true);  
            movimento = 0;          
    }

    void NãoHistograma(){
        painel_histograma.SetActive(false);
        obj_botoes.SetActive(true);
        obj_botoes2.SetActive(true);  
            movimento = 0;   
        if (folha == true){
            raw_folha.SetActive(true);
        }
        if (pareto == true){
            raw_pareto.SetActive(true);
        }
        if (peixe == true){
            raw_peixe.SetActive(true);
        }
        if (histograma == true){
            raw_histograma.SetActive(true);
        } 
        if (fluxograma == true){
            raw_fluxograma.SetActive(true);
        }  
        if (dispersao == true){
            raw_dispersao.SetActive(true);
        } 
        if (carta == true){
            raw_carta.SetActive(true);
        }              
    }

    void SimFluxograma(){
        painel_fluxograma.SetActive(false);
        obj_botoes.SetActive(true);     
        ferramenta_folha.SetActive(true);
        ferramenta_peixe.SetActive(true);
        ferramenta_pareto.SetActive(true);
        ferramenta_histograma.SetActive(true);
        ferramenta_fluxograma.SetActive(false);
        ferramenta_carta.SetActive(true);
        ferramenta_dispersao.SetActive(true);
        raw_folha.SetActive(false);
        raw_peixe.SetActive(false);
        obj_botoes2.SetActive(true);     
        raw_pareto.SetActive(false);
        raw_histograma.SetActive(false);
        raw_fluxograma.SetActive(true);
        raw_carta.SetActive(false);
        raw_dispersao.SetActive(false);
        folha = false;
        peixe = false;
        pareto = false; 
        histograma = false;
        fluxograma = true;
        carta = false;
        dispersao = false;      
            movimento = 0;  
    }

    void NãoFluxograma(){
        painel_fluxograma.SetActive(false); 
        obj_botoes.SetActive(true);
        obj_botoes2.SetActive(true); 
            movimento = 0;  
        if (folha == true){
            raw_folha.SetActive(true);
        }
        if (pareto == true){
            raw_pareto.SetActive(true);
        }
        if (peixe == true){
            raw_peixe.SetActive(true);
        }
        if (histograma == true){
            raw_histograma.SetActive(true);
        } 
        if (fluxograma == true){
            raw_fluxograma.SetActive(true);
        }  
        if (dispersao == true){
            raw_dispersao.SetActive(true);
        } 
        if (carta == true){
            raw_carta.SetActive(true);
        }               
    }
	
    void SimCarta(){
        painel_carta.SetActive(false);
        obj_botoes.SetActive(true);     
        ferramenta_folha.SetActive(true);
        ferramenta_peixe.SetActive(true);
        ferramenta_pareto.SetActive(true);
        ferramenta_histograma.SetActive(true);
        ferramenta_fluxograma.SetActive(true);
        ferramenta_carta.SetActive(false);
        ferramenta_dispersao.SetActive(true);
        obj_botoes2.SetActive(true);     
        raw_folha.SetActive(false);
        raw_peixe.SetActive(false);
        raw_pareto.SetActive(false);
        raw_histograma.SetActive(false);
        raw_fluxograma.SetActive(false);
        raw_carta.SetActive(true);
        raw_dispersao.SetActive(false);
        folha = false;
        peixe = false;
        pareto = false; 
        histograma = false;
        fluxograma = false;
        carta = true;
        dispersao = false;  
        obj_botoes2.SetActive(true);    
            movimento = 0;       
    }


    void NãoCarta(){
        painel_carta.SetActive(false); 
        obj_botoes.SetActive(true);  
        obj_botoes2.SetActive(true);   
            movimento = 0; 
        if (folha == true){
            raw_folha.SetActive(true);
        }
        if (pareto == true){
            raw_pareto.SetActive(true);
        }
        if (peixe == true){
            raw_peixe.SetActive(true);
        }
        if (histograma == true){
            raw_histograma.SetActive(true);
        } 
        if (fluxograma == true){
            raw_fluxograma.SetActive(true);
        }  
        if (dispersao == true){
            raw_dispersao.SetActive(true);
        } 
        if (carta == true){
            raw_carta.SetActive(true);
        }            
    }

    void SimDispersao(){
        painel_dispersao.SetActive(false);
        obj_botoes2.SetActive(true);     
        obj_botoes.SetActive(true);     
        ferramenta_folha.SetActive(true);
        ferramenta_peixe.SetActive(true);
        ferramenta_pareto.SetActive(true);
        ferramenta_histograma.SetActive(true);
        ferramenta_fluxograma.SetActive(true);
        ferramenta_carta.SetActive(true);
        ferramenta_dispersao.SetActive(false);
        raw_folha.SetActive(false);
        raw_peixe.SetActive(false);
        raw_pareto.SetActive(false);
        raw_histograma.SetActive(false);
        raw_fluxograma.SetActive(false);
        raw_carta.SetActive(false);
        raw_dispersao.SetActive(true);
        folha = false;
        peixe = false;
        pareto = false; 
        histograma = false;
        fluxograma = false;
        carta = false;
        dispersao = true;  
            movimento = 0;      
    }

    void NãoDispersao(){
        painel_dispersao.SetActive(false); 
        obj_botoes.SetActive(true); 
        obj_botoes2.SetActive(true);  
            movimento = 0; 
        if (folha == true){
            raw_folha.SetActive(true);
        }
        if (pareto == true){
            raw_pareto.SetActive(true);
        }
        if (peixe == true){
            raw_peixe.SetActive(true);
        }
        if (histograma == true){
            raw_histograma.SetActive(true);
        } 
        if (fluxograma == true){
            raw_fluxograma.SetActive(true);
        }  
        if (dispersao == true){
            raw_dispersao.SetActive(true);
        } 
        if (carta == true){
            raw_carta.SetActive(true);
        }              
    }

	// Update is called once per frame
	void FixedUpdate () {
        bool andando_direita = false;
        bool andando_esquerda = false;
        if (moedas>50){
            vidas = vidas+1;
            moedas = 0;
			TextMoedas.text = moedas.ToString();
            TextLives.text = vidas.ToString();
        }
        if (button_direita.tag == "A"){
            movimento = 1;
            andando_direita = true;
        }
        if (button_direita.tag == "B"){
               andando_direita = false;
        }
        if (andando_direita == false && andando_esquerda == false){
            movimento = 0;
        }
        if (button_esquerda.tag == "A"){
            movimento = -1;
            andando_esquerda = true;
        }
        if (button_esquerda.tag == "B"){
               andando_esquerda = false;
        }
		rigidbody = GetComponent<Rigidbody2D>();
		lado_direito = transform.localScale.x > 0;
		rigidbody.velocity = new Vector2(movimento*velocidadeMaxima, rigidbody.velocity.y);
        if (vidas <0){
            TextLives.text = "0";
            Time.timeScale = 0;
           PainelGameOver.SetActive(true);
         obj_botoes.SetActive(false);
         obj_botoes2.SetActive(false);
        obj_botoes2.SetActive(false); 
        raw_folha.SetActive(false);
        raw_peixe.SetActive(false);
        obj_botoes2.SetActive(false);     
        raw_pareto.SetActive(false);
        raw_histograma.SetActive(false);
        raw_fluxograma.SetActive(false);
        raw_carta.SetActive(false);
        raw_dispersao.SetActive(false);  
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

		if (collision2D.gameObject.CompareTag("FerramentaFolha")){
           painel_folha.SetActive(true);
           button_direita.tag = "B";
           button_esquerda.tag = "B";
           obj_botoes.SetActive(false); 
        obj_botoes2.SetActive(false); 
        raw_folha.SetActive(false);
        raw_peixe.SetActive(false);
        obj_botoes2.SetActive(false);     
        raw_pareto.SetActive(false);
        raw_histograma.SetActive(false);
        raw_fluxograma.SetActive(false);
        raw_carta.SetActive(false);
        raw_dispersao.SetActive(false);        
		}

		if (collision2D.gameObject.CompareTag("FerramentaPeixe")){
           painel_peixe.SetActive(true);
           button_direita.tag = "B";
           button_esquerda.tag = "B";
           obj_botoes.SetActive(false); 
        obj_botoes2.SetActive(false); 
        obj_botoes2.SetActive(false); 
        raw_folha.SetActive(false);
        raw_peixe.SetActive(false);
        obj_botoes2.SetActive(false);     
        raw_pareto.SetActive(false);
        raw_histograma.SetActive(false);
        raw_fluxograma.SetActive(false);
        raw_carta.SetActive(false);
        raw_dispersao.SetActive(false);              
		}

		if (collision2D.gameObject.CompareTag("FerramentaPareto")){
           painel_pareto.SetActive(true);
           button_direita.tag = "B";
           button_esquerda.tag = "B";
           obj_botoes.SetActive(false);  
        obj_botoes2.SetActive(false); 
        obj_botoes2.SetActive(false); 
        raw_folha.SetActive(false);
        raw_peixe.SetActive(false);
        obj_botoes2.SetActive(false);     
        raw_pareto.SetActive(false);
        raw_histograma.SetActive(false);
        raw_fluxograma.SetActive(false);
        raw_carta.SetActive(false);
        raw_dispersao.SetActive(false);             
		}

		if (collision2D.gameObject.CompareTag("FerramentaHistograma")){
           painel_histograma.SetActive(true);
           button_direita.tag = "B";
           button_esquerda.tag = "B";
           obj_botoes.SetActive(false);   
        obj_botoes2.SetActive(false); 
        obj_botoes2.SetActive(false); 
        raw_folha.SetActive(false);
        raw_peixe.SetActive(false);
        obj_botoes2.SetActive(false);     
        raw_pareto.SetActive(false);
        raw_histograma.SetActive(false);
        raw_fluxograma.SetActive(false);
        raw_carta.SetActive(false);
        raw_dispersao.SetActive(false);            
		}

		if (collision2D.gameObject.CompareTag("FerramentaFluxograma")){
           painel_fluxograma.SetActive(true);
           button_direita.tag = "B";
           button_esquerda.tag = "B";
           obj_botoes.SetActive(false); 
        obj_botoes2.SetActive(false); 
        obj_botoes2.SetActive(false); 
        raw_folha.SetActive(false);
        raw_peixe.SetActive(false);
        obj_botoes2.SetActive(false);     
        raw_pareto.SetActive(false);
        raw_histograma.SetActive(false);
        raw_fluxograma.SetActive(false);
        raw_carta.SetActive(false);
        raw_dispersao.SetActive(false);              
		}

		if (collision2D.gameObject.CompareTag("FerramentaCarta")){
           painel_carta.SetActive(true);
           obj_botoes.SetActive(false); 
           button_direita.tag = "B";
           button_esquerda.tag = "B";
        obj_botoes2.SetActive(false);  
        obj_botoes2.SetActive(false); 
        raw_folha.SetActive(false);
        raw_peixe.SetActive(false);
        obj_botoes2.SetActive(false);     
        raw_pareto.SetActive(false);
        raw_histograma.SetActive(false);
        raw_fluxograma.SetActive(false);
        raw_carta.SetActive(false);
        raw_dispersao.SetActive(false);             
		}

		if (collision2D.gameObject.CompareTag("FerramentaDispersao")){
           painel_dispersao.SetActive(true);
           obj_botoes.SetActive(false); 
           button_direita.tag = "B";
           button_esquerda.tag = "B";
        obj_botoes2.SetActive(false);
        obj_botoes2.SetActive(false); 
        raw_folha.SetActive(false);
        raw_peixe.SetActive(false);
        obj_botoes2.SetActive(false);     
        raw_pareto.SetActive(false);
        raw_histograma.SetActive(false);
        raw_fluxograma.SetActive(false);
        raw_carta.SetActive(false);
        raw_dispersao.SetActive(false);               
		}

		if (collision2D.gameObject.CompareTag("EquipeQualif")){
           painel_equipe.SetActive(true);
           obj_botoes.SetActive(false); 
           button_direita.tag = "B";
           button_esquerda.tag = "B";
        obj_botoes2.SetActive(false); 
        obj_botoes2.SetActive(false); 
        raw_folha.SetActive(false);
        raw_peixe.SetActive(false);
        obj_botoes2.SetActive(false);     
        raw_pareto.SetActive(false);
        raw_histograma.SetActive(false);
        raw_fluxograma.SetActive(false);
        raw_carta.SetActive(false);
        raw_dispersao.SetActive(false);              
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
