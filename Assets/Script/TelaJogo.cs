using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TelaJogo : MonoBehaviour {
	

public Button button_jogar;
public Button button_caderno;
public Button button_estatisticas;
public Button button_sair;
public Button button_quiz;
public Button button_forca;
public Button button_voltar;

public Button button_ferramentas;

 void Start()
    {
        //button_jogar.onClick.AddListener(Jogar);
        //button_sair.onClick.AddListener(Sair);
        button_forca.onClick.AddListener(Forca);
        button_voltar.onClick.AddListener(Voltar);
        button_ferramentas.onClick.AddListener(Ferramentas);
        Debug.Log("Tela Jogo");

     }

   
 void Jogar(){
        SceneManager.LoadScene("TelaJogo");
    }

void Voltar(){
        SceneManager.LoadScene("Main");
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
