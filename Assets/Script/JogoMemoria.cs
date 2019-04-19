using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JogoMemoria : MonoBehaviour {

public Button button_ajuda;
public Button button_responder;
public Button button_parar;
public string banca, ano, gabarito, num_gerado;
public string url_selectJogoQuiz = "https://qualif.000webhostapp.com/html/selectJogoQuiz.php";
public string url_salvar = "https://qualif.000webhostapp.com/html/salvarJogadorQuiz.php";
public string url_aleatorio = "https://qualif.000webhostapp.com/html/num_aleatorio.php";



void Start(){
        //button_ajuda.onClick.AddListener(Ajuda);
        //button_responder.onClick.AddListener(Responder);
        //button_parar.onClick.AddListener(Parar);
        WWW www_gerarnumero = new WWW (url_aleatorio);
        StartCoroutine(Num_aleatorio(www_gerarnumero));
}

IEnumerator Num_aleatorio(WWW www_gerarnumero){
        yield return www_gerarnumero;
        num_gerado = www_gerarnumero.text.ToString();
        num_gerado = num_gerado.TrimEnd();
        if (num_gerado == "1"){
        } 
}

}
