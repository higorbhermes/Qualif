﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public bool pause = false;
	public Button b_pause;
	public Button b_continuar;
	public GameObject PainelPause;
	// Use this for initialization
	void Start () {

		b_pause.onClick.AddListener(Pause);
		b_continuar.onClick.AddListener(Pause);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Pause () {
		/*if (pause == false){
			PainelPause.SetActive(true);
			pause = true;
		}
		else{
			PainelPause.SetActive(false);
			pause = false;
		}*/
        SceneManager.LoadScene("TelaJogo");
	}

	public void UnPause () {
		PainelPause.SetActive(false);
	}
}
