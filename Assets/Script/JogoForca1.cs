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
public Button button_dica;
public Button button_quiz;
public Button button_forca;
public Button button_voltar;
public Button button_ferramentas;
public string url_selectJogoForca = "https://qualif.000webhostapp.com/html/selectJogoForca.php";
public string url_completa;
public string letra, letra_digitada;
public int cont, opcao, acertos, erros = 0;
public Text letra_um, letra_dois, letra_tres, letra_quatro, letra_cinco, letra_seis, letra_sete, letra_oito, letra_nove, letra_dez, letra_onze, letras_digitadas;
public string letra_1, letra_2, letra_3, letra_4, letra_5, letra_6, letra_7, letra_8, letra_9, letra_10, letra_11;
public GameObject forca1, forca2, forca3, forca4, emoji_normal, emoji_triste, emoji_feliz, emoji_vitoria, emoji_derrota;
public bool acertou;

 void Start()
    {
      button_sair.onClick.AddListener(Sair);
      letras_digitadas.text = "";
      Debug.Log("Id do Jogo:"+UserData.id_jogo_forca_atual); 
      url_completa = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=3";
      WWW www1 = new WWW (url_completa);
      StartCoroutine(Verificar_Letra1(www1));  
     }

void FixedUpdate(){
    if (Input.GetKeyDown(KeyCode.A)){
        letra_digitada = "A";
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.B)){
        letra_digitada = "B";
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.C)){
        letra_digitada = "C";
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.D)){
        letra_digitada = "D";
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.E)){
        letra_digitada = "E";
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.F)){
        letra_digitada = "F";
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.G)){
        letra_digitada = "G";
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.H)){
        letra_digitada = "H";
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.I)){
        letra_digitada = "I";
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.J)){
        letra_digitada = "J";
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.K)){
        letra_digitada = "K";
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.L)){
        letra_digitada = "L";
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.M)){
        letra_digitada = "M";
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.N)){
        letra_digitada = "N";
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.O)){
        letra_digitada = "O";
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.P)){
        letra_digitada = "P";
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.Q)){
        letra_digitada = "Q";
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.R)){
        letra_digitada = "R";
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.S)){
        letra_digitada = "S";
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.T)){
        letra_digitada = "T";
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.U)){
        letra_digitada = "U";
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.V)){
        letra_digitada = "V";
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.X)){
        letra_digitada = "X";
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.W)){
        letra_digitada = "W";
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.Y)){
        letra_digitada = "Y";
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.Z)){
        letra_digitada = "Z";
        ConferirLetra(letra_digitada);
    }

}

IEnumerator Verificar_Letra1(WWW www1){
        yield return www1;
        letra_1 = www1.text.ToString();
        letra_1 = letra_1.TrimEnd();
        url_completa = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=4";
        WWW www2 = new WWW (url_completa);
        StartCoroutine(Verificar_Letra2(www2)); 
}

IEnumerator Verificar_Letra2(WWW www2){
        yield return www2;
        letra_2 = www2.text.ToString();
        letra_2 = letra_2.TrimEnd();
        url_completa = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=5";
        WWW www3 = new WWW (url_completa);
        StartCoroutine(Verificar_Letra3(www3)); 
}

IEnumerator Verificar_Letra3(WWW www3){
        yield return www3;
        letra_3 = www3.text.ToString();
        letra_3 = letra_3.TrimEnd();
        url_completa = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=6";
        WWW www4 = new WWW (url_completa);
        StartCoroutine(Verificar_Letra4(www4)); 
}

IEnumerator Verificar_Letra4(WWW www4){
        yield return www4;
        letra_4 = www4.text.ToString();
        letra_4 = letra_4.TrimEnd();
        url_completa = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=7";
        WWW www5 = new WWW (url_completa);
        StartCoroutine(Verificar_Letra5(www5)); 
}

IEnumerator Verificar_Letra5(WWW www5){
        yield return www5;
        letra_5 = www5.text.ToString();
        letra_5 = letra_5.TrimEnd();
        url_completa = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=8";
        WWW www6 = new WWW (url_completa);
        StartCoroutine(Verificar_Letra6(www6)); 
}

IEnumerator Verificar_Letra6(WWW www6){
        yield return www6;
        letra_6 = www6.text.ToString();
        letra_6 = letra_6.TrimEnd();
        url_completa = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=9";
        WWW www7 = new WWW (url_completa);
        StartCoroutine(Verificar_Letra7(www7)); 
}

IEnumerator Verificar_Letra7(WWW www7){
        yield return www7;
        letra_7 = www7.text.ToString();
        letra_7 = letra_7.TrimEnd();
        url_completa = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=10";
        WWW www8 = new WWW (url_completa);
        StartCoroutine(Verificar_Letra8(www8)); 
}

IEnumerator Verificar_Letra8(WWW www8){
        yield return www8;
        letra_8 = www8.text.ToString();
        letra_8 = letra_8.TrimEnd();
        url_completa = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=11";
        WWW www9 = new WWW (url_completa);
        StartCoroutine(Verificar_Letra9(www9)); 
}

IEnumerator Verificar_Letra9(WWW www9){
        yield return www9;
        letra_9 = www9.text.ToString();
        letra_9 = letra_9.TrimEnd();
        url_completa = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=12";
        WWW www10 = new WWW (url_completa);
        StartCoroutine(Verificar_Letra10(www10)); 
}

IEnumerator Verificar_Letra10(WWW www10){
        yield return www10;
        letra_10 = www10.text.ToString();
        letra_10 = letra_10.TrimEnd();
        url_completa = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=13";
        WWW www11 = new WWW (url_completa);
        StartCoroutine(Verificar_Letra11(www11)); 
}

IEnumerator Verificar_Letra11(WWW www11){
        yield return www11;
        letra_11 = www11.text.ToString();
        letra_11 = letra_11.TrimEnd();
}

void ConferirLetra(string letra_digitada){
    if (letra_digitada == letra_1){
        letra_um.text = letra_digitada;
        acertos++;
        acertou = true;
    }
    if (letra_digitada == letra_2){
        letra_dois.text = letra_digitada;
        acertos++;
        acertou = true;
    }
    if (letra_digitada == letra_3){
        letra_tres.text = letra_digitada;
        acertos++;
        acertou = true;
    }
    if (letra_digitada == letra_4){
        letra_quatro.text = letra_digitada;
        acertos++;
        acertou = true;
    }
    if (letra_digitada == letra_5){
        letra_cinco.text = letra_digitada;
        acertos++;
        acertou = true;
    }
    if (letra_digitada == letra_6){
        letra_seis.text = letra_digitada;
        acertos++;
        acertou = true;
    }
    if (letra_digitada == letra_7){
        letra_sete.text = letra_digitada;
        acertos++;
        acertou = true;
    }
    if (letra_digitada == letra_8){
        letra_oito.text = letra_digitada;
        acertos++;
        acertou = true;
    }
    if (letra_digitada == letra_9){
        letra_nove.text = letra_digitada;
        acertos++;
        acertou = true;
    }
    if (letra_digitada == letra_10){
        letra_dez.text = letra_digitada;
        acertos++;
        acertou = true;
    }
    if (letra_digitada == letra_11){
        letra_onze.text = letra_digitada;
        acertos++;
        acertou = true;
    }
    Controle();
}

void Controle(){
    letras_digitadas.text = letras_digitadas.text+" "+letra_digitada+" -";
    if (acertou == true){   
            emoji_feliz.SetActive(true);
            emoji_normal.SetActive(false);
            emoji_triste.SetActive(false);
    }
    else{
        emoji_feliz.SetActive(false);
        emoji_normal.SetActive(false);
        emoji_triste.SetActive(true);
        erros = erros+1;
        if (erros == 1){
            forca1.SetActive(false);
            forca2.SetActive(true);
        }
        if (erros == 2){
            forca2.SetActive(false);
            forca3.SetActive(true);
        }
        if (erros == 3){
            forca3.SetActive(false);
            forca4.SetActive(true);
        }
    }
    acertou = false;
}

void Jogar(){SceneManager.LoadScene("TelaJogo");}
void Voltar(){SceneManager.LoadScene("Main"); }
void Sair(){SceneManager.LoadScene("TelaJogo");}

 void Forca(){
        SceneManager.LoadScene("JogoForca1");
    }

 void Ferramentas(){
        SceneManager.LoadScene("Cena1");
    }
}
