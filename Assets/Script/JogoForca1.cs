using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JogoForca1 : MonoBehaviour {
	

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
      button_sair.onClick.AddListener(Sair);
     }

   
 void Jogar(){
        SceneManager.LoadScene("TelaJogo");
    }

void Voltar(){
        SceneManager.LoadScene("Main");
    }

 void Sair(){
        SceneManager.LoadScene("TelaJogo");
    }

 void Forca(){
        SceneManager.LoadScene("JogoForca1");
    }

 void Ferramentas(){
        SceneManager.LoadScene("Cena1");
    }
}
