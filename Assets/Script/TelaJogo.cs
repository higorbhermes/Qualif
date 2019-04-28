using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TelaJogo : MonoBehaviour {
	

public Button button_jogar;
public Button button_dados;
public Button button_caderno;
public Button button_estatisticas;
public Button button_sair;
public Button button_quiz;
public Button button_forca;
public Button button_voltar;
public Button button_ferramentas;
public string num_gerado, num_gerado2, num_letras;
public string url_aleatorio = "https://qualif.000webhostapp.com/html/num_aleatorio.php";
public string url_aleatorio_memoria = "https://qualif.000webhostapp.com/html/num_aleatorio_memoria.php";
public string url_selectJogoForca = "https://qualif.000webhostapp.com/html/selectJogoForca.php";
public string url_selectJogoQuiz = "https://qualif.000webhostapp.com/html/selectJogoQuiz.php";
public int num, merda, opcao;

 void Start()
    {
        //button_jogar.onClick.AddListener(Jogar);
        //button_sair.onClick.AddListener(Sair);
        button_forca.onClick.AddListener(Forca);
        button_dados.onClick.AddListener(Dados);
        button_quiz.onClick.AddListener(Quiz);
        button_estatisticas.onClick.AddListener(Pontuacao);
        button_voltar.onClick.AddListener(Voltar);
        button_ferramentas.onClick.AddListener(Memória);
        Debug.Log(""+UserData.email);
     }

void Jogar(){
        SceneManager.LoadScene("TelaJogo");
    }

void Pontuacao(){
        SceneManager.LoadScene("Pontuacao");
    }

void Quiz(){
     opcao = 1;
     UserData.escolha = "1";
     SceneManager.LoadScene("TelaFiltro");
     //WWW www = new WWW (url_aleatorio);
     //StartCoroutine(Num_aleatorio(www));
}

void Voltar(){
        SceneManager.LoadScene("Main");
    }

void Dados(){
        SceneManager.LoadScene("TelaMeusDados");
    }


void Sair(){
     Application.Quit();
}

void Forca(){
     opcao = 2;
     UserData.escolha = "2";
     SceneManager.LoadScene("TelaFiltro");
}

void Memória(){
        WWW www = new WWW (url_aleatorio_memoria);
        StartCoroutine(Num_aleatorio_Memoria(www));
}

IEnumerator Num_aleatorio_Memoria(WWW www){
        yield return www;
        num_gerado = www.text.ToString();
        num_gerado = num_gerado.TrimEnd();
        WWW wwwww = new WWW (url_aleatorio);
        StartCoroutine(IniciarMemoria(wwwww));
}


IEnumerator Num_aleatorio(WWW www){
        yield return www;
        num_gerado = www.text.ToString();
        num_gerado = num_gerado.TrimEnd();
        Debug.Log(num_gerado);
        if (opcao == 1){
            num = int.Parse(num_gerado);
            UserData.id_jogo_quiz_atual = num;
            UserData.cont_jogo_quiz = 0;
            SceneManager.LoadScene("JogoQuiz");
        }
        if (opcao == 2){
            WWW wwww = new WWW (url_selectJogoForca+"?id="+num_gerado+"&opcao=2");
            StartCoroutine(IniciarForca(wwww)); 
        }
}

IEnumerator IniciarMemoria(WWW wwwww){
        yield return wwwww;
        num_gerado2 = wwwww.text.ToString();
        num_gerado2 = num_gerado2.TrimEnd();
        UserData.cod_memoria = num_gerado2;
        UserData.cont_jogo_memoria = 0;
        if (num_gerado == "1"){
            if (num_gerado2 == "1" || num_gerado2 == "2"){
               SceneManager.LoadScene("JogoMemoria");
            }
            if (num_gerado2 == "3" || num_gerado2 == "4"){
               SceneManager.LoadScene("JogoMemoriav2");
            }
            if (num_gerado2 == "5" || num_gerado2 == "6"){
               SceneManager.LoadScene("JogoMemoriav3");
            }
            if (num_gerado2 == "7" || num_gerado2 == "8"){
               SceneManager.LoadScene("JogoMemoriav4");
            }
            if (num_gerado2 == "9" || num_gerado2 == "10"){
               SceneManager.LoadScene("JogoMemoriav5");
            }
        }
        if (num_gerado == "2"){
            if (num_gerado2 == "1" || num_gerado2 == "2"){
               SceneManager.LoadScene("JogoMemoria2v1");
            }
            if (num_gerado2 == "3" || num_gerado2 == "4"){
               SceneManager.LoadScene("JogoMemoria2v2");
            }
            if (num_gerado2 == "5" || num_gerado2 == "6"){
               SceneManager.LoadScene("JogoMemoria2v3");
            }
            if (num_gerado2 == "7" || num_gerado2 == "8"){
               SceneManager.LoadScene("JogoMemoria2v4");
            }
            if (num_gerado2 == "9" || num_gerado2 == "10"){
               SceneManager.LoadScene("JogoMemoria2v5");
            }
        }
        if (num_gerado == "3"){
            if (num_gerado2 == "1" || num_gerado2 == "2"){
               SceneManager.LoadScene("JogoMemoria3v1");
            }
            if (num_gerado2 == "3" || num_gerado2 == "4"){
               SceneManager.LoadScene("JogoMemoria3v2");
            }
            if (num_gerado2 == "5" || num_gerado2 == "6"){
               SceneManager.LoadScene("JogoMemoria3v3");
            }
            if (num_gerado2 == "7" || num_gerado2 == "8"){
               SceneManager.LoadScene("JogoMemoria3v4");
            }
            if (num_gerado2 == "9" || num_gerado2 == "10"){
               SceneManager.LoadScene("JogoMemoria3v5");
            }
        }
        if (num_gerado == "4"){
            if (num_gerado2 == "1" || num_gerado2 == "2"){
               SceneManager.LoadScene("JogoMemoria4v1");
            }
            if (num_gerado2 == "3" || num_gerado2 == "4"){
               SceneManager.LoadScene("JogoMemoria4v2");
            }
            if (num_gerado2 == "5" || num_gerado2 == "6"){
               SceneManager.LoadScene("JogoMemoria4v3");
            }
            if (num_gerado2 == "7" || num_gerado2 == "8"){
               SceneManager.LoadScene("JogoMemoria4v4");
            }
            if (num_gerado2 == "9" || num_gerado2 == "10"){
               SceneManager.LoadScene("JogoMemoria4v5");
            }
        }
        
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
