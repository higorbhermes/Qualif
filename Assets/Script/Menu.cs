﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour {
	

public Button button_jogar;
public Button button_caderno;
public Button button_estatisticas;
public Button button_sair;
public Button button_quiz;
public Button button_forca;
public Button button_ferramentas;

 void Start()
    {
        button_jogar.onClick.AddListener(Jogar);
        button_sair.onClick.AddListener(Sair);
        //button_forca.onClick.AddListener(Forca);
        //button_ferramentas.onClick.AddListener(Ferramentas);

     }

   
 void Jogar(){
        SceneManager.LoadScene("TelaJogo");
    }

 void Sair(){
        Application.Quit();
    }

 void Forca(){
        SceneManager.LoadScene("JogoForca1");
    }

 void Ferramentas(){
        SceneManager.LoadScene("Cena1");
    }
}
