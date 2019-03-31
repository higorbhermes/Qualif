using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JogoForca10Letras : MonoBehaviour {
	

public Button button_jogar;
public Button button_caderno;
public Button button_estatisticas;
public Button button_sair;
public Button button_dica;
public Button button_revelar;
public Button button_quiz;
public Button button_som;
public Button button_forca;
public Button button_voltar;
public Button button_ferramentas;
public string url_selectJogoForca = "https://qualif.000webhostapp.com/html/selectJogoForca.php";
public string url_converter = "https://qualif.000webhostapp.com/html/Converter.php";
public string url_salvar = "https://qualif.000webhostapp.com/html/salvarJogadorForca.php";
public string url_converter_auxiliar;
public string url_completa, url_completa1, url_completa2, url_completa3, url_completa4, url_completa5, url_completa6, url_completa7, url_completa8, url_completa9, url_completa10, url_completa11;
public string letra, letra_digitada;
public int cont, opcao, acertos = 0, erros = 0;
public Text letra_um, letra_dois, letra_tres, letra_quatro, letra_cinco, letra_seis, letra_sete, letra_oito, letra_nove, letra_dez, letra_onze, letras_digitadas, dica;
public Text pontuacao, proximo_desafio;
public string letra_1 = "", letra_2 = "", letra_3 = "", letra_4 = "", letra_5 = "", letra_6 = "", letra_7 = "", letra_8 = "", letra_9 = "", letra_10 = "", letra_11 = "";
public GameObject forca1, forca2, forca3, forca2_som, forca3_som, forca4_som, forca4, emoji_normal, emoji_triste, emoji_feliz, emoji_vitoria, emoji_derrota;
public bool acertou;
public string letra_revelada;
public int i = 1;
public int x, pontos;
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
public bool liberar_fase = false;
public bool bloquear_jogo = false;
public bool limpar_mensagem = true;
public GameObject linha1, linha2,  linha3, linha4, linha5, linha6, linha7, linha9, linha8, linha10, linha11;
public string url_aleatorio = "https://qualif.000webhostapp.com/html/num_aleatorio.php";
public string num_gerado, num_letras;
public int aux, num, agora_vai;
public bool é_igual = false, liberado = true;
public string numero_convertido;
public bool letra1_revelada = false, letra2_revelada = false, letra3_revelada = false, letra4_revelada = false, letra5_revelada = false, letra6_revelada = false, letra7_revelada = false, letra8_revelada = false, letra9_revelada = false, letra10_revelada = false, letra11_revelada = false;
public bool a = false, b = false, c = false, d = false, e = false, f = false, g = false, h = false, letra_i = false, j = false, k = false, l = false, m = false, n = false, o = false, p = false, q = false, r = false, s = false, t = false, u = false, v = false, letra_x = false, w = false, y = false, z = false; 
public AudioSource som_errado;


void Start(){
      pontos = UserData.pontuacao;
      Pontuacao();
      button_sair.onClick.AddListener(Sair);
      button_dica.onClick.AddListener(Dica);
      button_revelar.onClick.AddListener(Revelar);
      button_som.onClick.AddListener(Som);
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
      Conferir();
}

void Conferir(){
        if (ok_1 == false){
            url_completa1 = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=3";
            WWW www1 = new WWW (url_completa1);
            StartCoroutine(Verificar_Letra1(www1)); 
        }
        if (ok_2 == false){
            url_completa2 = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=4";
            WWW www2 = new WWW (url_completa2);
            Debug.Log(""+url_completa2); 
            StartCoroutine(Verificar_Letra2(www2));
        }
        if (ok_3 == false){
            url_completa3 = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=5";
            WWW www3 = new WWW (url_completa3);
            Debug.Log(""+url_completa3); 
            StartCoroutine(Verificar_Letra3(www3)); 
        }
        if (ok_4 == false){
            url_completa4 = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=6";
            WWW www4 = new WWW (url_completa4);
            Debug.Log(""+url_completa4); 
            StartCoroutine(Verificar_Letra4(www4)); 
        }
        if (ok_5 == false){
            url_completa5 = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=7";
            WWW www5 = new WWW (url_completa5);
            StartCoroutine(Verificar_Letra5(www5)); 
            Debug.Log(""+url_completa5);
        }
        if (ok_6 == false){
            url_completa6 = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=8";
            WWW www6 = new WWW (url_completa6);
            Debug.Log(""+url_completa6); 
            StartCoroutine(Verificar_Letra6(www6)); 
        }
        if (ok_7 == false){
            url_completa7 = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=9";
            WWW www7 = new WWW (url_completa7);
            Debug.Log(""+url_completa7); 
            StartCoroutine(Verificar_Letra7(www7)); 
        }
        if (ok_8 == false){
            url_completa8 = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=10";
            WWW www8 = new WWW (url_completa8);
            Debug.Log(""+url_completa8); 
            StartCoroutine(Verificar_Letra8(www8)); 
        }
        if (ok_9 == false){
            url_completa9 = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=11";
            WWW www9 = new WWW (url_completa9);
            Debug.Log(""+url_completa9); 
            StartCoroutine(Verificar_Letra9(www9)); 
        }
        if (ok_10 == false){
            url_completa10 = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=12";
            WWW www10 = new WWW (url_completa10);
            Debug.Log(""+url_completa10); 
            StartCoroutine(Verificar_Letra10(www10)); 
        }
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
    if (pontos<=0){
        pontos = 0;
        Pontuacao();
    }
    if (letra_1 =="" || letra_2  =="" || letra_3  =="" || letra_4 =="" || letra_5 =="" || letra_6 =="" || letra_7 =="" || letra_8 =="" || letra_9 =="" || letra_10 ==""){
       proximo_desafio.text = "Conectando ao Servidor...Aguarde um momento!";
       liberado = false;
    }
    else{
        liberado = true;
        if (acertos<10 || erros <3){  
            if (limpar_mensagem == true){
                    proximo_desafio.text = "";
            }
        }
    }
    if (Input.GetKeyDown(KeyCode.A) && acertos<10 && erros<3 && a == false && liberado == true){
        letra_digitada = "A";
        a = true;
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.B) && acertos<10 && erros<3 && b == false && liberado == true){
        letra_digitada = "B";
        b = true;
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.C) && acertos<10 && erros<3 && c == false && liberado == true){
        letra_digitada = "C";
        c = true;
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.D) && acertos<10 && erros<3 && d == false && liberado == true){
        letra_digitada = "D";
        d = true;
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.E) && acertos<10 && erros<3 && e == false && liberado == true){
        letra_digitada = "E";
        e = true;
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.F) && acertos<10 && erros<3 && f == false && liberado == true){
        letra_digitada = "F";
        f = true;
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.G) && acertos<10 && erros<3 && g == false && liberado == true){
        letra_digitada = "G";
        g = true;
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.H) && acertos<10 && erros<3 && h == false && liberado == true){
        letra_digitada = "H";
        h = true;
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.I) && acertos<10 && erros<3 && letra_i == false && liberado == true){
        letra_digitada = "I";
        letra_i = true;
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.J) && acertos<10 && erros<3 && j == false && liberado == true){
        letra_digitada = "J";
        j = true;
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.K) && acertos<10 && erros<3 && k == false && liberado == true){
        letra_digitada = "K";
        k = true;
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.L) && acertos<10 && erros<3 && l == false && liberado == true){
        letra_digitada = "L";
        l = true;
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.M) && acertos<10 && erros<3 && m == false && liberado == true){
        letra_digitada = "M";
        m = true;
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.N) && acertos<10 && erros<3 && n == false && liberado == true){
        letra_digitada = "N";
        n = true;
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.O) && acertos<10 && erros<3 && o == false && liberado == true){
        letra_digitada = "O";
        o = true;
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.P) && acertos<10 && erros<3 && p == false && liberado == true){
        letra_digitada = "P";
        p = true;
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.Q) && acertos<10 && erros<3 && q == false && liberado == true){
        letra_digitada = "Q";
        q = true;
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.R) && acertos<10 && erros<3 && r == false && liberado == true){
        letra_digitada = "R";
        r = true;
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.S) && acertos<10 && erros<3 && s == false && liberado == true){
        letra_digitada = "S";
        s = true;
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.T) && acertos<10 && erros<3 && t == false && liberado == true){
        letra_digitada = "T";
        t = true;
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.U) && acertos<10 && erros<3 && u == false && liberado == true){
        letra_digitada = "U";
        u = true;
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.V) && acertos<10 && erros<3 && v == false && liberado == true){
        letra_digitada = "V";
        v = true;
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.X) && acertos<10 && erros<3 && letra_x == false && liberado == true){
        letra_digitada = "X";
        letra_x = true;
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.W) && acertos<10 && erros<3 && w == false && liberado == true){
        letra_digitada = "W";
        w = true;
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.Y) && acertos<10 && erros<3 && y == false && liberado == true){
        letra_digitada = "Y";
        y = true;
        ConferirLetra(letra_digitada);
    }
    if (Input.GetKeyDown(KeyCode.Z) && acertos<10 && erros<3 && z == false && liberado == true){
        letra_digitada = "Z";
        z = true;
        ConferirLetra(letra_digitada);
    }
    /*if (é_igual == true){
        WWW www_gerarnumero = new WWW (url_aleatorio);
        StartCoroutine(Num_aleatorio(www_gerarnumero));
    }*/
    if (Input.GetKeyDown(KeyCode.Space) && liberar_fase == true){
        if (UserData.cont_jogo_forca<=9){
               PrepararDesafio();
               //while (é_igual == true){
               //é_igual == true;
                    //WWW www_gerarnumero = new WWW (url_aleatorio);
                    //StartCoroutine(Num_aleatorio(www_gerarnumero));
               //}
               //WWW wwww = new WWW (url_selectJogoForca+"?id="+num_gerado+"&opcao=2");
               //StartCoroutine(IniciarForca(wwww)); 
        }
        else{
            SceneManager.LoadScene("TelaVitoria");
        }
    }
    if (Input.GetKeyDown(KeyCode.Space) && bloquear_jogo == true){
            UserData.pontuacao = 100;
            SceneManager.LoadScene("TelaJogo");

    }
    if (acertos>=10){
        proximo_desafio.text = "Parabens! Aperte ESPAÇO para jogar o proximo desafio";
    }
    if (acertos>=10 && liberar_fase == false){
        UserData.cont_jogo_forca = UserData.cont_jogo_forca+1;
        UserData.JogoForcaAtual[UserData.cont_jogo_forca] = UserData.id_jogo_forca_atual;
        UserData.pontuacao = pontos;
        liberar_fase = true;
        WWW www_salvar = new WWW (url_salvar+"?id_forca="+UserData.id_jogo_forca_atual+"&email="+UserData.email+"&resposta=1");
        StartCoroutine(SalvarJogo(www_salvar));
        Debug.Log("Cont: "+ UserData.cont_jogo_forca); 
        Debug.Log("Cont: "+ UserData.JogoForcaAtual[UserData.cont_jogo_forca]); 
        Debug.Log(url_salvar+"?id_forca="+UserData.id_jogo_forca_atual+"&email="+UserData.email+"&resposta=1");
    }
    if (erros>=3 && bloquear_jogo == false){
        limpar_mensagem = false;
        WWW www_salvar = new WWW (url_salvar+"?id_forca="+UserData.id_jogo_forca_atual+"&email="+UserData.email+"&resposta=0");
        StartCoroutine(SalvarJogo(www_salvar));
        proximo_desafio.text = "Você Errou! A resposta correta era: "+letra_1+letra_2+letra_3+letra_4+letra_5+letra_6+letra_7+letra_8+letra_9+letra_10+". Aperte ESPAÇO ou clique em SAIR para encerrar a partida";
        bloquear_jogo = true;
    }

}

void PrepararDesafio(){ 
    WWW www_gerarnumero = new WWW (url_aleatorio);
    StartCoroutine(Num_aleatorio(www_gerarnumero));
}

IEnumerator SalvarJogo(WWW www_salvar){
        yield return www_salvar;   
}

IEnumerator IniciarForca(WWW wwww){
        yield return wwww;
        num_letras = wwww.text.ToString();
        num_letras = num_letras.TrimEnd();
        if (num_letras == "10"){
            num = int.Parse(num_gerado);
            UserData.id_jogo_forca_atual = num;
            UserData.cont_jogo_forca = UserData.cont_jogo_forca++;
            SceneManager.LoadScene("JogoForca10Letras");
        }  
        if (num_letras == "11"){
            num = int.Parse(num_gerado);
            UserData.id_jogo_forca_atual = num;
            UserData.cont_jogo_forca = UserData.cont_jogo_forca++;
            SceneManager.LoadScene("JogoForca1");
        } 
        if (num_letras == "12"){
            num = int.Parse(num_gerado);
            UserData.id_jogo_forca_atual = num;
            UserData.cont_jogo_forca = UserData.cont_jogo_forca++;
            SceneManager.LoadScene("JogoForca12Letras");
        }   
}

IEnumerator Num_aleatorio(WWW www_gerarnumero){
        yield return www_gerarnumero;
        num_gerado = www_gerarnumero.text.ToString();
        num_gerado = num_gerado.TrimEnd();
        Debug.Log("Número Gerado:"+num_gerado); 
        num = int.Parse(num_gerado);
        é_igual = false; 
        if (UserData.JogoForcaAtual[1] == num){
            é_igual = true;
        }
        if (UserData.JogoForcaAtual[2] == num && é_igual == false && UserData.cont_jogo_forca>=2){
            é_igual = true;
        }
        if (UserData.JogoForcaAtual[3] == num && é_igual == false && UserData.cont_jogo_forca>=3){
            é_igual = true;
        }
        if (UserData.JogoForcaAtual[4] == num && é_igual == false && UserData.cont_jogo_forca>=4){
            é_igual = true;
        }
        if (UserData.JogoForcaAtual[5] == num && é_igual == false && UserData.cont_jogo_forca>=5){
            é_igual = true;
        }
        if (UserData.JogoForcaAtual[6] == num && é_igual == false && UserData.cont_jogo_forca>=6){
            é_igual = true;
        }
        if (UserData.JogoForcaAtual[7] == num && é_igual == false && UserData.cont_jogo_forca>=7){
            é_igual = true;
        }
        if (UserData.JogoForcaAtual[8] == num && é_igual == false && UserData.cont_jogo_forca>=8){
            é_igual = true;
        }
        if (UserData.JogoForcaAtual[9] == num && é_igual == false && UserData.cont_jogo_forca>=9){
            é_igual = true;
        }
        if (UserData.JogoForcaAtual[10] == num && é_igual == false && UserData.cont_jogo_forca>=10){
            é_igual = true;
        }
        if (é_igual == true){
            PrepararDesafio();
        }
        else{
             WWW wwww = new WWW (url_selectJogoForca+"?id="+num_gerado+"&opcao=2");
             StartCoroutine(IniciarForca(wwww));
        }
}

IEnumerator ConverterNumero(WWW www_converter){
        yield return www_converter;
        numero_convertido = www_converter.text.ToString();
        numero_convertido = numero_convertido.TrimEnd();
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

void ConferirLetra(string letra_digitada){
      limpar_mensagem = true;
    if (letra_digitada == letra_1 && letra1_revelada == false){
        letra_um.text = letra_digitada;
        acertos++;
        acertou = true;
        pontos = pontos + 20;
        letra1_revelada = true;
        Destroy(linha1);
    }
    if (letra_digitada == letra_2 && letra2_revelada == false){
        letra_dois.text = letra_digitada;
        acertos++;
        acertou = true;
        pontos = pontos + 20;
        letra2_revelada = true;
        Destroy(linha2);
    }
    if (letra_digitada == letra_3 && letra3_revelada == false){
        letra_tres.text = letra_digitada;
        acertos++;
        acertou = true;
        pontos = pontos + 20;
        letra3_revelada = true;
        Destroy(linha3);
    }
    if (letra_digitada == letra_4 && letra4_revelada == false){
        letra_quatro.text = letra_digitada;
        acertos++;
        acertou = true;
        letra4_revelada = true;
        pontos = pontos + 20;
        Destroy(linha4);
    }
    if (letra_digitada == letra_5 && letra5_revelada == false){
        letra_cinco.text = letra_digitada;
        acertos++;
        acertou = true;
        letra5_revelada = true;
        pontos = pontos + 20;
        Destroy(linha5);
    }
    if (letra_digitada == letra_6 && letra6_revelada == false){
        letra_seis.text = letra_digitada;
        acertos++;
        letra6_revelada = true;
        acertou = true;
        pontos = pontos + 20;
        Destroy(linha6);

    }
    if (letra_digitada == letra_7 && letra7_revelada == false){
        letra_sete.text = letra_digitada;
        acertos++;
        acertou = true;
        letra7_revelada = true;
        pontos = pontos + 20;
        Destroy(linha7);
    }
    if (letra_digitada == letra_8 && letra8_revelada == false){
        letra_oito.text = letra_digitada;
        acertos++;
        acertou = true;
        pontos = pontos + 20;
        letra8_revelada = true;
        Destroy(linha8);
    }
    if (letra_digitada == letra_9 && letra9_revelada == false){
        letra_nove.text = letra_digitada;
        acertos++;
        acertou = true;
        pontos = pontos + 20;
        letra9_revelada = true;
        Destroy(linha9);
    }
    if (letra_digitada == letra_10 && letra10_revelada == false){
        letra_dez.text = letra_digitada;
        acertos++;
        acertou = true;
        pontos = pontos + 20;
        letra10_revelada = true;
        Destroy(linha10);
    }
    Controle();
}

void Controle(){
    letras_digitadas.text = letras_digitadas.text+" "+letra_digitada+" -";
    if (acertou == true){   
            emoji_feliz.SetActive(true);
            emoji_normal.SetActive(false);
            emoji_triste.SetActive(false);
            if (UserData.som == true){
                GetComponent<AudioSource>().Play();
            }
    }
    else{
        emoji_feliz.SetActive(false);
        emoji_normal.SetActive(false);
        emoji_triste.SetActive(true);
        erros = erros+1;
        pontos = pontos - 10; 
        if (UserData.som == true){
            if (erros == 1){
                 forca1.SetActive(false);
                 forca2_som.SetActive(true);
            }
            if (erros == 2){
                forca2.SetActive(false);
                forca2_som.SetActive(false);
                forca3_som.SetActive(true);
            }
            if (erros == 3){
                forca3.SetActive(false);
                forca3_som.SetActive(false);
                forca4_som.SetActive(true);
            }
        }
        else{
            if (erros == 1){
                forca1.SetActive(false);
                forca2.SetActive(true);
            }
            if (erros == 2){
                forca2.SetActive(false);
                forca2_som.SetActive(false);
                forca3.SetActive(true);
            }
            if (erros == 3){
                forca3.SetActive(false);
                forca3_som.SetActive(false);
                forca4.SetActive(true);
            }
        }
    }
    acertou = false;
    Pontuacao();
}

void Jogar(){SceneManager.LoadScene("TelaJogo");}

void Dica(){
    if (pontos>=40  && acertos<10 && erros<3){
        pontos = pontos - 40;
        Pontuacao();
        url_completa = url_selectJogoForca+"?id="+UserData.id_jogo_forca_atual+"&opcao=2";
        WWW www_dica = new WWW (url_completa);
        StartCoroutine(Verificar_Dica(www_dica));
    }
    else{
        if (pontos<=40){
            limpar_mensagem = false;
            proximo_desafio.text = "Você precisa de 40 pontos para utilizar essa ajuda!";
        }
    }
}

IEnumerator Verificar_Dica(WWW www_dica){
        yield return www_dica;
        dica.text = www_dica.text.ToString();
        dica.text = "DICA: "+dica.text.TrimEnd();
}

void Revelar(){
    i = 1;
    if (acertos<=10 && liberado == true && pontos>=80 && acertos<10 && erros<3){
      pontos = pontos-80;
        while (i<10){
            Pontuacao();
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
        letra_revelada = "";
    }
   else{
        if (pontos<=80){
            limpar_mensagem = false;
            proximo_desafio.text = "Você precisa de 80 pontos para utilizar essa ajuda!";
        }
    }
}


void Voltar(){SceneManager.LoadScene("Main"); }
void Sair(){UserData.pontuacao = 100; SceneManager.LoadScene("TelaJogo");}

void Pontuacao(){
      url_converter_auxiliar = url_converter+"?numero="+pontos;
      WWW www_converter = new WWW (url_converter_auxiliar);
      StartCoroutine(ConverterPontuacao(www_converter));  
}

IEnumerator ConverterPontuacao(WWW www_converter){
        yield return www_converter;
        pontuacao.text = www_converter.text.ToString();
        pontuacao.text = pontuacao.text.TrimEnd();
}

void Forca(){
        SceneManager.LoadScene("JogoForca1");
    }

void Som(){
    if (UserData.som == true){
        UserData.som = false;
    }
    else{
        UserData.som = true;
    }
}

void Ferramentas(){
        SceneManager.LoadScene("Cena1");
    }
}
