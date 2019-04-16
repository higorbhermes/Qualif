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
public string num_gerado, num_letras;
public string url_aleatorio = "https://qualif.000webhostapp.com/html/num_aleatorio.php";
public string url_selectJogoForca = "https://qualif.000webhostapp.com/html/selectJogoForca.php";
public int num, merda;

 void Start()
    {
        //button_jogar.onClick.AddListener(Jogar);
        //button_sair.onClick.AddListener(Sair);
        button_forca.onClick.AddListener(Forca);
        button_quiz.onClick.AddListener(Quiz);
        button_voltar.onClick.AddListener(Voltar);
        button_ferramentas.onClick.AddListener(Ferramentas);
        Debug.Log(""+UserData.email);
        //merda = System.Random.Range (4,6);
     }

 void Jogar(){
        SceneManager.LoadScene("TelaJogo");
    }

void Quiz(){
     SceneManager.LoadScene("JogoQuiz");
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
        WWW wwww = new WWW (url_selectJogoForca+"?id="+num_gerado+"&opcao=2");
        StartCoroutine(IniciarForca(wwww)); 
}

IEnumerator IniciarForca(WWW wwww){
        yield return wwww;
        num_letras = wwww.text.ToString();
        num_letras = num_letras.TrimEnd();
        if (num_letras == "10"){
            num = int.Parse(num_gerado);
            UserData.id_jogo_forca_atual = num;
            UserData.cont_jogo_forca = 0;
            SceneManager.LoadScene("JogoForca10Letras");
        }  
        if (num_letras == "11"){
            num = int.Parse(num_gerado);
            UserData.id_jogo_forca_atual = num;
            UserData.cont_jogo_forca = 0;
            SceneManager.LoadScene("JogoForca1");
        }  
        if (num_letras == "12"){
            num = int.Parse(num_gerado);
            UserData.id_jogo_forca_atual = num;
            UserData.cont_jogo_forca = 0;
            SceneManager.LoadScene("JogoForca12Letras");
        }
}
}
