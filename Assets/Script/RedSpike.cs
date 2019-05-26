using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedSpike : MonoBehaviour {

	private bool colidde = false;

	private float move = -2;


	void Start()
	{
	}

	void Update()
	{
		GetComponent<Rigidbody2D>().velocity = new Vector2(move, GetComponent<Rigidbody2D>().velocity.y);
		if (colidde)
		{
			Flip();
		}
	}

	private void Flip()
	{
		move *= -1;
		GetComponent<SpriteRenderer>().flipX = !GetComponent<SpriteRenderer>().flipX;
		colidde = false;
	}


	void OnCollisionEnter2D(Collision2D col)
	{
       
		if (col.gameObject.CompareTag("Espinho"))
		{
			colidde = true;
		}


		if (col.gameObject.CompareTag("Vida"))
		{
			colidde = true;
		}


	}

	void OnCollisionExit2D(Collision2D col)
	{
        
		if (col.gameObject.CompareTag("Espinho"))
		{
			colidde = false;
		}

		if (col.gameObject.CompareTag("Vida"))
		{
			colidde = false;
		}

	}

	void OnTriggerEnter2D(Collider2D collision2D){        
        if (collision2D.gameObject.CompareTag("Obstaculo")) {
			colidde = true;
        }
    }    

    void OnTriggerExit2D(Collider2D collision2D){        

        if (collision2D.gameObject.CompareTag("Obstaculo")){
			colidde = false;
		}
    }  

    void Calejjjj(){}

}
