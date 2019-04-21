using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JogoMemoria : MonoBehaviour {

public Button button_ajuda;
public Button button_responder;
public Button button_parar;
public Button carta_1;
public Button carta_2;
public Button carta_3;
public Button carta_4;
public Button carta_5;
public Button carta_6;
public Button carta_7;
public Button carta_8;
public Button carta_9;
public Button carta_10;
public Button carta_11;
public Button carta_12;
public Button carta_13;
public Button carta_14;
public GameObject obj_carta1;
public GameObject obj_carta2;
public GameObject obj_carta3;
public GameObject obj_carta4;
public GameObject obj_carta5;
public GameObject obj_carta6;
public GameObject obj_carta7;
public GameObject obj_carta8;
public GameObject obj_carta9;
public GameObject obj_carta10;
public GameObject obj_carta11;
public GameObject obj_carta12;
public GameObject obj_carta13;
public GameObject obj_carta14;
public GameObject obj_figura1;
public GameObject obj_figura2;
public GameObject obj_figura3;
public GameObject obj_figura4;
public GameObject obj_figura5;
public GameObject obj_figura6;
public GameObject obj_figura7;
public GameObject obj_figura8;
public GameObject obj_figura9;
public GameObject obj_figura10;
public GameObject obj_figura11;
public GameObject obj_figura12;
public GameObject obj_figura13;
public GameObject obj_figura14;
public string num_gerado;
public string url_selectJogoQuiz = "https://qualif.000webhostapp.com/html/selectJogoQuiz.php";
public string url_salvar = "https://qualif.000webhostapp.com/html/salvarJogadorQuiz.php";
public string url_aleatorio = "https://qualif.000webhostapp.com/html/num_aleatorio.php";
public int primeira_escolha = 0, segunda_escolha = 0;
public int cantor;




void Start(){
        //button_ajuda.onClick.AddListener(Ajuda);
        //button_responder.onClick.AddListener(Responder);
        //button_parar.onClick.AddListener(Parar);
        carta_1.onClick.AddListener(Carta1);
        carta_2.onClick.AddListener(Carta2);
        carta_3.onClick.AddListener(Carta3);
        carta_4.onClick.AddListener(Carta4);
        carta_5.onClick.AddListener(Carta5);
        carta_6.onClick.AddListener(Carta6);
        carta_7.onClick.AddListener(Carta7);
        carta_8.onClick.AddListener(Carta8);
        carta_9.onClick.AddListener(Carta9);
        carta_10.onClick.AddListener(Carta10);
        carta_11.onClick.AddListener(Carta11);
        carta_12.onClick.AddListener(Carta12);
        carta_13.onClick.AddListener(Carta13);
        carta_14.onClick.AddListener(Carta14);
        //WWW www_gerarnumero = new WWW (url_aleatorio);
        //StartCoroutine(Num_aleatorio(www_gerarnumero));
}

void Carta1(){
     obj_carta1.SetActive(false);
     obj_figura1.SetActive(true);
     if (primeira_escolha == 0){
         primeira_escolha = 1;
     }
     else{
        segunda_escolha = 1;
        VerificarJogada();
     }
}

void Carta2(){
     obj_carta2.SetActive(false);
     obj_figura2.SetActive(true);
     if (primeira_escolha == 0){
         primeira_escolha = 2;
     }
     else{
        segunda_escolha = 2;
        VerificarJogada();
     }
}

void Carta3(){
     obj_carta3.SetActive(false);
     obj_figura3.SetActive(true);
     if (primeira_escolha == 0){
         primeira_escolha = 3;
     }
     else{
        segunda_escolha = 3;
        VerificarJogada();
     }
}

void Carta4(){
     obj_carta4.SetActive(false);
     obj_figura4.SetActive(true);
     if (primeira_escolha == 0){
         primeira_escolha = 4;
     }
     else{
        segunda_escolha = 4;
        VerificarJogada();
     }
}

void Carta5(){
     obj_carta5.SetActive(false);
     obj_figura5.SetActive(true);
     if (primeira_escolha == 0){
         primeira_escolha = 5;
     }
     else{
        segunda_escolha = 5;
        VerificarJogada();
     }
}

void Carta6(){
     obj_carta6.SetActive(false);
     obj_figura6.SetActive(true);
     if (primeira_escolha == 0){
         primeira_escolha = 6;
     }
     else{
        segunda_escolha = 6;
        VerificarJogada();
     }
}

void Carta7(){
     obj_carta7.SetActive(false);
     obj_figura7.SetActive(true);
     if (primeira_escolha == 0){
         primeira_escolha = 7;
     }
     else{
        segunda_escolha = 7;
        VerificarJogada();
     }
}

void Carta8(){
     obj_carta8.SetActive(false);
     obj_figura8.SetActive(true);
     if (primeira_escolha == 0){
         primeira_escolha = 8;
     }
     else{
        segunda_escolha = 8;
        VerificarJogada();
     }
}

void Carta9(){
     obj_carta9.SetActive(false);
     obj_figura9.SetActive(true);
     if (primeira_escolha == 0){
         primeira_escolha = 9;
     }
     else{
        segunda_escolha = 9;
        VerificarJogada();
     }
}

void Carta10(){
     obj_carta10.SetActive(false);
     obj_figura10.SetActive(true);
     if (primeira_escolha == 0){
         primeira_escolha = 10;
     }
     else{
        segunda_escolha = 10;
        VerificarJogada();
     }
}

void Carta11(){
     obj_carta11.SetActive(false);
     obj_figura11.SetActive(true);
     if (primeira_escolha == 0){
         primeira_escolha = 11;
     }
     else{
        segunda_escolha = 11;
        VerificarJogada();
     }
}

void Carta12(){
     obj_carta12.SetActive(false);
     obj_figura12.SetActive(true);
     if (primeira_escolha == 0){
         primeira_escolha = 12;
     }
     else{
        segunda_escolha = 12;
        VerificarJogada();
     }
}

void Carta13(){
     obj_carta13.SetActive(false);
     obj_figura13.SetActive(true);
     if (primeira_escolha == 0){
         primeira_escolha = 13;
     }
     else{
        segunda_escolha = 13;
        VerificarJogada();
     }
}

void Carta14(){
     obj_carta14.SetActive(false);
     obj_figura14.SetActive(true);
     if (primeira_escolha == 0){
         primeira_escolha = 14;
     }
     else{
        segunda_escolha = 14;
        VerificarJogada();
     }
}

void VerificarJogada(){
}

IEnumerator Num_aleatorio(WWW www_gerarnumero){
        yield return www_gerarnumero;
        num_gerado = www_gerarnumero.text.ToString();
        num_gerado = num_gerado.TrimEnd();
        if (num_gerado == "1"){
        } 
}

}
