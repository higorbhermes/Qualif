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
public Button button_revelar;
public Button button_quiz;
public Button button_forca;
public Button button_voltar;
public Button button_ferramentas;
public string url_selectJogoForca = "https://qualif.000webhostapp.com/html/selectJogoForca.php";
public string url_completa, url_completa1, url_completa2, url_completa3, url_completa4, url_completa5, url_completa6, url_completa7, url_completa8, url_completa9, url_completa10, url_completa11;
public string letra, letra_digitada;
public int cont, opcao, acertos = 0, erros = 0;
public Text letra_um, letra_dois, letra_tres, letra_quatro, letra_cinco, letra_seis, letra_sete, letra_oito, letra_nove, letra_dez, letra_onze, letras_digitadas, dica;
public Text pontuacao, proximo_desafio;
public string letra_1, letra_2, letra_3, letra_4, letra_5, letra_6, letra_7, letra_8, letra_9, letra_10, letra_11;
public GameObject forca1, forca2, forca3, forca4, emoji_normal, emoji_triste, emoji_feliz, emoji_vitoria, emoji_derrota;
public bool acertou;
public string letra_revelada;
public int i = 1;
public int x;
public bool ok_1 = false;
public bool ok_2 = false;
public bool ok_3 = false; 
public bool ok_4 = false; 
public bool ok_5 = false; 
public bool ok_6 = false;
public bool ok_7 = false; 
public bool ok_8 = false;
public bool ok_9 = false; 
public bool ok_10 = false;
public bool ok_11 = false;
public GameObject linha1, linha2,  linha3, linha4, linha5, linha6, linha7, linha9, linha8, linha10, linha11;

 void Start()
    {
      button_sair.onClick.AddListener(Sair);
      button_dica.onClick.AddListener(Dica);
      button_revelar.onClick.AddListener(Revelar);
      letras_digitadas.text = "";
      Debug.Log("Id do Jogo:"+UserData.id_jogo_forca_atual); 
      url_completa1 = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=3";
      WWW www1 = new WWW (url_completa1);
      StartCoroutine(Verificar_Letra1(www1));  
      url_completa2 = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=4";
      WWW www2 = new WWW (url_completa2);
      Debug.Log(""+url_completa2); 
      StartCoroutine(Verificar_Letra2(www2));
      url_completa3 = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=5";
      WWW www3 = new WWW (url_completa3);
      Debug.Log(""+url_completa3); 
      StartCoroutine(Verificar_Letra3(www3));  
      url_completa4 = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=6";
      WWW www4 = new WWW (url_completa4);
      Debug.Log(""+url_completa4); 
      StartCoroutine(Verificar_Letra4(www4)); 
        url_completa5 = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=7";
        WWW www5 = new WWW (url_completa5);
        StartCoroutine(Verificar_Letra5(www5)); 
      Debug.Log(""+url_completa5); 
        url_completa6 = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=8";
        WWW www6 = new WWW (url_completa6);
      Debug.Log(""+url_completa6); 
        StartCoroutine(Verificar_Letra6(www6)); 
        url_completa7 = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=9";
        WWW www7 = new WWW (url_completa7);
      Debug.Log(""+url_completa7); 
        StartCoroutine(Verificar_Letra7(www7)); 
        url_completa8 = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=10";
        WWW www8 = new WWW (url_completa8);
      Debug.Log(""+url_completa8); 
        StartCoroutine(Verificar_Letra8(www8)); 
        url_completa9 = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=11";
        WWW www9 = new WWW (url_completa9);
      Debug.Log(""+url_completa9); 
        StartCoroutine(Verificar_Letra9(www9)); 
        url_completa10 = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=12";
        WWW www10 = new WWW (url_completa10);
      Debug.Log(""+url_completa10); 
        StartCoroutine(Verificar_Letra10(www10)); 
        url_completa11 = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=13";
        WWW www11 = new WWW (url_completa11);
      Debug.Log(""+url_completa11); 
        StartCoroutine(Verificar_Letra11(www11)); 

     }

void FixedUpdate(){
    if (letra_1 == "" && ok_1 == true){
      url_completa1 = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=3";
      WWW www1 = new WWW (url_completa1);
      StartCoroutine(Verificar_Letra1(www1)); 
    }
    if (letra_2 == "" && ok_2 == true){
        url_completa2 = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=4";
      WWW www2 = new WWW (url_completa2);
      Debug.Log(""+url_completa2); 
      StartCoroutine(Verificar_Letra2(www2)); 
    }
    if (letra_3 == "" && ok_3 == true){
     url_completa3 = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=5";
      WWW www3 = new WWW (url_completa3);
      Debug.Log(""+url_completa3); 
      StartCoroutine(Verificar_Letra3(www3));  
    }
    if (letra_4 == "" && ok_4 == true){
    url_completa4 = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=6";
      WWW www4 = new WWW (url_completa4);
      Debug.Log(""+url_completa4); 
      StartCoroutine(Verificar_Letra4(www4));
    }
    if (letra_5 == "" && ok_5 == true){
     url_completa5 = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=7";
        WWW www5 = new WWW (url_completa5);
        StartCoroutine(Verificar_Letra5(www5)); 
      Debug.Log(""+url_completa5); 
    }
    if (letra_6 == "" && ok_6 == true){
     url_completa6 = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=8";
        WWW www6 = new WWW (url_completa6);
      Debug.Log(""+url_completa6); 
        StartCoroutine(Verificar_Letra6(www6)); 
    }
    if (letra_7 == "" && ok_7 == true){
     url_completa7 = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=9";
        WWW www7 = new WWW (url_completa7);
      Debug.Log(""+url_completa7); 
        StartCoroutine(Verificar_Letra7(www7));  
    }
    if (letra_8 == "" && ok_8 == true){
        WWW www8 = new WWW (url_completa8);
     url_completa8 = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=10";
      Debug.Log(""+url_completa8); 
        StartCoroutine(Verificar_Letra8(www8));
    }
    if (letra_9 == "" && ok_9 == true){
 url_completa9 = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=11";
        WWW www9 = new WWW (url_completa9);
      Debug.Log(""+url_completa9); 
        StartCoroutine(Verificar_Letra9(www9)); 
    }
    if (letra_10 == "" && ok_10 == true){
     url_completa10 = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=12";
        WWW www10 = new WWW (url_completa10);
      Debug.Log(""+url_completa10); 
        StartCoroutine(Verificar_Letra10(www10));
    }
    if (letra_11 == "" && ok_11 == true){
      url_completa11 = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=13";
        WWW www11 = new WWW (url_completa11);
      Debug.Log(""+url_completa11); 
        StartCoroutine(Verificar_Letra11(www11)); 
    }
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
    if (acertos>=11){
        proximo_desafio.text = "Parabens! Aperte ENTER para o proximo desafio";
    }

}

IEnumerator Verificar_Letra1(WWW www1){
        yield return www1;
        letra_1 = www1.text.ToString();
        letra_1 = letra_1.TrimEnd();
        ok_1 = true;
}

IEnumerator Verificar_Letra2(WWW www2){
        yield return www2;
        letra_2 = www2.text.ToString();
        letra_2 = letra_2.TrimEnd();
        ok_2 = true;
}

IEnumerator Verificar_Letra3(WWW www3){
        yield return www3;
        letra_3 = www3.text.ToString();
        letra_3 = letra_3.TrimEnd();
        ok_3 = true;
}

IEnumerator Verificar_Letra4(WWW www4){
        yield return www4;
        letra_4 = www4.text.ToString();
        letra_4 = letra_4.TrimEnd();
        ok_4 = true;
}

IEnumerator Verificar_Letra5(WWW www5){
        yield return www5;
        letra_5 = www5.text.ToString();
        letra_5 = letra_5.TrimEnd();
        ok_5 = true;
}

IEnumerator Verificar_Letra6(WWW www6){
        yield return www6;
        letra_6 = www6.text.ToString();
        letra_6 = letra_6.TrimEnd();
        ok_6 = true;
}

IEnumerator Verificar_Letra7(WWW www7){
        yield return www7;
        letra_7 = www7.text.ToString();
        letra_7 = letra_7.TrimEnd();
        ok_7 = true;
}

IEnumerator Verificar_Letra8(WWW www8){
        yield return www8;
        letra_8 = www8.text.ToString();
        letra_8 = letra_8.TrimEnd();
        ok_8 = true;
}

IEnumerator Verificar_Letra9(WWW www9){
        yield return www9;
        letra_9 = www9.text.ToString();
        letra_9 = letra_9.TrimEnd();
        ok_9 = true;
}

IEnumerator Verificar_Letra10(WWW www10){
        yield return www10;
        letra_10 = www10.text.ToString();
        letra_10 = letra_10.TrimEnd();
        ok_10 = true;
}

IEnumerator Verificar_Letra11(WWW www11){
        yield return www11;
        letra_11 = www11.text.ToString();
        letra_11 = letra_11.TrimEnd();
        ok_11 = true;
}

void ConferirLetra(string letra_digitada){
     url_completa1 = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=3";
      WWW www1 = new WWW (url_completa1);
      StartCoroutine(Verificar_Letra1(www1));  
      url_completa2 = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=4";
      WWW www2 = new WWW (url_completa2);
      Debug.Log(""+url_completa2); 
      StartCoroutine(Verificar_Letra2(www2));
      url_completa3 = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=5";
      WWW www3 = new WWW (url_completa3);
      Debug.Log(""+url_completa3); 
      StartCoroutine(Verificar_Letra3(www3));  
      url_completa4 = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=6";
      WWW www4 = new WWW (url_completa4);
      Debug.Log(""+url_completa4); 
      StartCoroutine(Verificar_Letra4(www4)); 
        url_completa5 = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=7";
        WWW www5 = new WWW (url_completa5);
        StartCoroutine(Verificar_Letra5(www5)); 
      Debug.Log(""+url_completa5); 
        url_completa6 = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=8";
        WWW www6 = new WWW (url_completa6);
      Debug.Log(""+url_completa6); 
        StartCoroutine(Verificar_Letra6(www6)); 
        url_completa7 = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=9";
        WWW www7 = new WWW (url_completa7);
      Debug.Log(""+url_completa7); 
        StartCoroutine(Verificar_Letra7(www7)); 
        url_completa8 = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=10";
        WWW www8 = new WWW (url_completa8);
      Debug.Log(""+url_completa8); 
        StartCoroutine(Verificar_Letra8(www8)); 
        url_completa9 = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=11";
        WWW www9 = new WWW (url_completa9);
      Debug.Log(""+url_completa9); 
        StartCoroutine(Verificar_Letra9(www9)); 
        url_completa10 = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=12";
        WWW www10 = new WWW (url_completa10);
      Debug.Log(""+url_completa10); 
        StartCoroutine(Verificar_Letra10(www10)); 
        url_completa11 = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=13";
        WWW www11 = new WWW (url_completa11);
      Debug.Log(""+url_completa11); 
        StartCoroutine(Verificar_Letra11(www11)); 
    if (letra_digitada == letra_1){
        letra_um.text = letra_digitada;
        acertos++;
        acertou = true;
        Destroy(linha1);
    }
    if (letra_digitada == letra_2){
        letra_dois.text = letra_digitada;
        acertos++;
        acertou = true;
        Destroy(linha2);
    }
    if (letra_digitada == letra_3){
        letra_tres.text = letra_digitada;
        acertos++;
        acertou = true;
        Destroy(linha3);
    }
    if (letra_digitada == letra_4){
        letra_quatro.text = letra_digitada;
        acertos++;
        acertou = true;
        Destroy(linha4);
    }
    if (letra_digitada == letra_5){
        letra_cinco.text = letra_digitada;
        acertos++;
        acertou = true;
        Destroy(linha5);
    }
    if (letra_digitada == letra_6){
        letra_seis.text = letra_digitada;
        acertos++;
        acertou = true;
        Destroy(linha6);

    }
    if (letra_digitada == letra_7){
        letra_sete.text = letra_digitada;
        acertos++;
        acertou = true;
        Destroy(linha7);
    }
    if (letra_digitada == letra_8){
        letra_oito.text = letra_digitada;
        acertos++;
        acertou = true;
        Destroy(linha8);
    }
    if (letra_digitada == letra_9){
        letra_nove.text = letra_digitada;
        acertos++;
        acertou = true;
        Destroy(linha9);
    }
    if (letra_digitada == letra_10){
        letra_dez.text = letra_digitada;
        acertos++;
        acertou = true;
        Destroy(linha10);
    }
    if (letra_digitada == letra_11){
        letra_onze.text = letra_digitada;
        acertos++;
        acertou = true;
        Destroy(linha11);
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

void Dica(){
     url_completa = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=2";
     WWW www_dica = new WWW (url_completa);
     StartCoroutine(Verificar_Dica(www_dica));
}

IEnumerator Verificar_Dica(WWW www_dica){
        yield return www_dica;
        dica.text = www_dica.text.ToString();
        dica.text = "DICA: "+dica.text.TrimEnd();
}

void Revelar(){
    i = 1;
    if (acertos<=11){
      Debug.Log("Passou Aqui"); 
        while (i<11){
            if (i == 1){
                if(letra_um.text == ""){
                    letra_um.text = letra_1;
                    letra_revelada = letra_1;
                    acertos++;
                    i = 100;
                    x = 1;
                    Destroy(linha1);
                }
            }
            if (i == 2){
                if(letra_dois.text == ""){
                    letra_dois.text = letra_2;
                    letra_revelada = letra_2;
                    acertos++;
                    i = 100;
                    x = 2;
                    Destroy(linha2);
                }
            }
            if (i == 3){
                if(letra_tres.text == ""){
                    letra_tres.text = letra_3;
                    letra_revelada = letra_3;
                    acertos++;
                    i = 100;
                    x = 3;
                    Destroy(linha3);
                }
            }
            if (i == 4){
                if(letra_quatro.text == ""){
                    letra_quatro.text = letra_4;
                    letra_revelada = letra_4;
                    acertos++;
                    i = 100;
                    x = 4;
                    Destroy(linha4);
                }
            }
            if (i == 5){
                if(letra_cinco.text == ""){
                    letra_cinco.text = letra_5;
                    letra_revelada = letra_5;
                    acertos++;
                    i = 100;
                    x = 5;
                    Destroy(linha5);
                }
            }
            if (i == 6){
                if(letra_seis.text == ""){
                    letra_seis.text = letra_6;
                    letra_revelada = letra_6;
                    acertos++;
                    i = 100;
                    x = 6;
                    Destroy(linha6);
                }
            }
            if (i == 7){
                if(letra_sete.text == ""){
                    letra_sete.text = letra_7;
                    letra_revelada = letra_7;
                    acertos++;
                    i = 100;
                    x = 7;
                    Destroy(linha7);
                }
            }
            if (i == 8){
                if(letra_oito.text == ""){
                    letra_oito.text = letra_8;
                    letra_revelada = letra_8;
                    acertos++;
                    i = 100;
                    x = 8;
                    Destroy(linha8);
                }
            }
            if (i == 9){
                if(letra_nove.text == ""){
                    letra_nove.text = letra_9;
                    letra_revelada = letra_9;
                    acertos++;
                    i = 100;
                    x = 9;
                    Destroy(linha9);
                }
            }
            if (i == 10){
                if(letra_dez.text == ""){
                    letra_dez.text = letra_10;
                    letra_revelada = letra_10;
                    acertos++;
                    i = 100;
                    x = 10;
                    Destroy(linha10);
                }
            }
            if (i == 11){
                if(letra_onze.text == ""){
                    letra_onze.text = letra_11;
                    letra_revelada = letra_11;
                    acertos++;
                    i = 100;
                    x = 11;
                    Destroy(linha11);
                }
            }
            i++;
        }

        if (letra_revelada == letra_1 && x != 1){
            letra_um.text = letra_revelada;
            acertos++;
            Destroy(linha1);
        }
        if (letra_revelada == letra_2 && x != 2){
            letra_dois.text = letra_revelada;
            acertos++;
            Destroy(linha2);
        }
        if (letra_revelada == letra_3 && x != 3){
            letra_tres.text = letra_revelada;
            acertos++;
            Destroy(linha3);
        }
        if (letra_revelada == letra_4 && x != 4){
            letra_quatro.text = letra_revelada;
            acertos++;
            Destroy(linha4);
        }
        if (letra_revelada == letra_5 && x != 5){
            letra_cinco.text = letra_revelada;
            acertos++;
            Destroy(linha5);
        }
        if (letra_revelada == letra_6 && x != 6){
            letra_seis.text = letra_revelada;
            acertos++;
            Destroy(linha6);
        }
        if (letra_revelada == letra_7 && x != 7){
            letra_sete.text = letra_revelada;
            acertos++;
            Destroy(linha7);
        }
        if (letra_revelada == letra_8 && x != 8){
            letra_oito.text = letra_revelada;
            acertos++;
            Destroy(linha8);
        }
        if (letra_revelada == letra_9 && x != 9){
            letra_nove.text = letra_revelada;
            acertos++;
            Destroy(linha9);
        }
        if (letra_revelada == letra_10 && x != 10){
            letra_dez.text = letra_revelada;
            acertos++;
            Destroy(linha10);
        }
        if (letra_revelada == letra_11 && x != 11){
            letra_onze.text = letra_revelada;
            acertos++;
            Destroy(linha11);
        }
    }
}


void Voltar(){SceneManager.LoadScene("Main"); }
void Sair(){SceneManager.LoadScene("TelaJogo");}

 void Forca(){
        SceneManager.LoadScene("JogoForca1");
    }

 void Ferramentas(){
        SceneManager.LoadScene("Cena1");
    }
}
