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
public string num_gerado;
public string url_aleatorio = "https://qualif.000webhostapp.com/html/num_aleatorio.php";

 void Start()
    {
        //button_jogar.onClick.AddListener(Jogar);
        //button_sair.onClick.AddListener(Sair);
        button_forca.onClick.AddListener(Forca);
        button_voltar.onClick.AddListener(Voltar);
        button_ferramentas.onClick.AddListener(Ferramentas);
        Debug.Log(""+UserData.email);
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

        WWW www = new WWW (url_aleatorio);
        StartCoroutine(Num_aleatorio(www));         
        //SceneManager.LoadScene("JogoForca1");
    }

 void Ferramentas(){
        SceneManager.LoadScene("Cena1");
    }

IEnumerator Num_aleatorio(WWW www){
        yield return www;
        num_gerado = www.text.ToString();
        num_gerado = num_gerado.TrimEnd();
        Debug.Log(""+num_gerado); 
        Debug.Log("Gerou esse número: "+num_gerado); 
        Debug.Log("E também esse: "+num_gerado);  
}
}
