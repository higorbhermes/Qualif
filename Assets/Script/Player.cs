using UnityEngine;
using UnityEngine.UI;
﻿using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
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
    public LayerMask LayerMaskPlatform;
    public LayerMask LayerMaskMonsters;
    public GameObject LastCheckpoint;
    private float distToGround;

	// Use this for initialization
	void Start () {
		moedas = 0;
		vidas = 3;
		ferramenta = false;
		TextLives.text = vidas.ToString();
		TextMoedas.text = moedas.ToString();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
		float movimento = Input.GetAxis("Horizontal");
		lado_direito = transform.localScale.x > 0;
		rigidbody.velocity = new Vector2(movimento*velocidadeMaxima, rigidbody.velocity.y);
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
