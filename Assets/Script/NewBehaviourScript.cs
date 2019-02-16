using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    public float forcaPulo = 2;
    public float velocidadeMaxima = 4;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
		float movimento = Input.GetAxis("Horizontal");
		rigidbody.velocity = new Vector2(movimento*velocidadeMaxima, rigidbody.velocity.y);
		if (Input.GetKeyDown(KeyCode.Space)){
			rigidbody.AddForce(new Vector2(0,400));
		}
	}
}
