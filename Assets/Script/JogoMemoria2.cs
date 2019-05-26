using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JogoMemoria2 : MonoBehaviour {

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
public GameObject emoji_normal;
public GameObject emoji_feliz;
public GameObject emoji_triste;
public GameObject emoji_chorando;
public GameObject emoji_amei;
public Text mensagem1, mensagem2, titulo;
public GameObject object_pdca;
public GameObject object_kaizen;
public GameObject object_gut;
public GameObject object_swot;
public GameObject object_sigma;
public GameObject object_bcg;
public GameObject object_5W2H;
public GameObject object_referencias;
public Button continuar_pdca, continuar_kaizen, continuar_gut, continuar_swot, continuar_sigma, continuar_bcg, continuar_5W2H, continuar_referencias;
public Button button_referencias;
public string num_gerado;
public string url_selectJogoQuiz = "https://qualif.000webhostapp.com/html/selectJogoQuiz.php";
public string url_salvar = "https://qualif.000webhostapp.com/html/salvarJogadorQuiz.php";
public string url_aleatorio = "https://qualif.000webhostapp.com/html/num_aleatorio.php";
public int primeira_escolha = 0, segunda_escolha = 0, num;
public int contador = 0, aux = 0;
public bool acertou = false, errou = false, final = false, liberado = true, limpou1 = false,  limpou2 = false, inicio = true, amostra = true, é_igual = false;
public bool revelou1 = false, revelou2 = false, revelou3 = false, revelou4 = false, revelou5 = false, revelou6 = false, revelou7 = false, revelou8 = false, revelou9 = false, revelou10 = false, revelou11 = false, revelou12 = false, revelou13 = false, revelou14 = false;
public double timer = 0.5;
public double timerErro = 0.5;
public double oldTimer;
public int tt = UserData.cont_jogo_memoria;




void Start(){
        //button_ajuda.onClick.AddListener(Ajuda);
        //button_responder.onClick.AddListener(Responder);
        button_parar.onClick.AddListener(Parar);
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
        obj_figura1.SetActive(false);
        obj_figura2.SetActive(false);
        obj_figura3.SetActive(false);
        obj_figura4.SetActive(false);
        obj_figura5.SetActive(false);
        obj_figura6.SetActive(false);
        obj_figura7.SetActive(false);
        obj_figura8.SetActive(false);
        obj_figura9.SetActive(false);
        obj_figura10.SetActive(false);
        obj_figura11.SetActive(false);
        obj_figura12.SetActive(false);
        obj_figura13.SetActive(false);
        obj_figura14.SetActive(false);
        titulo.text = "JOGO DA MEMÓRIA";
        continuar_pdca.onClick.AddListener(ContinuarPdca);
        continuar_kaizen.onClick.AddListener(ContinuarKaizen);
        continuar_gut.onClick.AddListener(ContinuarGut);
        continuar_swot.onClick.AddListener(ContinuarSwot);
        continuar_sigma.onClick.AddListener(ContinuarSigma);
        continuar_bcg.onClick.AddListener(ContinuarBcg);
        continuar_5W2H.onClick.AddListener(Continuar5W2H);
        continuar_referencias.onClick.AddListener(ContinuarReferencia);
        button_referencias.onClick.AddListener(Referencia);
}

void ContinuarPdca(){
     if (final == true){
        if (UserData.cont_jogo_memoria<=3){
              WWW www_gerarnumero = new WWW (url_aleatorio);
              StartCoroutine(Num_aleatorio(www_gerarnumero));
        }
        else{
            SceneManager.LoadScene("TelaVitoria");
        }
     }
     else{
        object_pdca.SetActive(false);
     }
}

void ContinuarKaizen(){
     if (final == true){
        if (UserData.cont_jogo_memoria<=3){
              WWW www_gerarnumero = new WWW (url_aleatorio);
              StartCoroutine(Num_aleatorio(www_gerarnumero));
        }
        else{
            SceneManager.LoadScene("TelaVitoria");
        }
     }
     else{
        object_kaizen.SetActive(false);
     }
}

void ContinuarGut(){
     if (final == true){
        if (UserData.cont_jogo_memoria<=3){
              WWW www_gerarnumero = new WWW (url_aleatorio);
              StartCoroutine(Num_aleatorio(www_gerarnumero));
        }
        else{
            SceneManager.LoadScene("TelaVitoria");
        }
     }
     else{
        object_gut.SetActive(false);
     }
}

void ContinuarSwot(){
     if (final == true){
        if (UserData.cont_jogo_memoria<=3){
              WWW www_gerarnumero = new WWW (url_aleatorio);
              StartCoroutine(Num_aleatorio(www_gerarnumero));
        }
        else{
            SceneManager.LoadScene("TelaVitoria");
        }
     }
     else{
        object_swot.SetActive(false);
     }
}

void ContinuarSigma(){
     if (final == true){
        if (UserData.cont_jogo_memoria<=3){
              WWW www_gerarnumero = new WWW (url_aleatorio);
              StartCoroutine(Num_aleatorio(www_gerarnumero));
        }
        else{
            SceneManager.LoadScene("TelaVitoria");
        }
     }
     else{
        object_sigma.SetActive(false);
     }
}

void ContinuarBcg(){
     if (final == true){
        if (UserData.cont_jogo_memoria<=3){
              WWW www_gerarnumero = new WWW (url_aleatorio);
              StartCoroutine(Num_aleatorio(www_gerarnumero));
        }
        else{
            SceneManager.LoadScene("TelaVitoria");
        }
     }
     else{
        object_bcg.SetActive(false);
     }
}

void Continuar5W2H(){
     if (final == true){
        if (UserData.cont_jogo_memoria<=3){
              WWW www_gerarnumero = new WWW (url_aleatorio);
              StartCoroutine(Num_aleatorio(www_gerarnumero));
        }
        else{
            SceneManager.LoadScene("TelaVitoria");
        }
     }
     else{
        object_5W2H.SetActive(false);
     }
}

void ContinuarReferencia(){
     object_referencias.SetActive(false);
}

void Referencia(){
     object_referencias.SetActive(true);
}


void FixedUpdate(){
    timer -= Time.deltaTime;
    if (timer > -2.5){
       inicio = false;
        obj_carta1.SetActive(false);
        obj_carta2.SetActive(false);
        obj_carta3.SetActive(false);
        obj_carta4.SetActive(false);
        obj_carta5.SetActive(false);
        obj_carta6.SetActive(false);
        obj_carta7.SetActive(false);
        obj_carta8.SetActive(false);
        obj_carta9.SetActive(false);
        obj_carta10.SetActive(false);
        obj_carta11.SetActive(false);
        obj_carta12.SetActive(false);
        obj_carta13.SetActive(false);
        obj_carta14.SetActive(false);
        obj_figura1.SetActive(true);
        obj_figura2.SetActive(true);
        obj_figura3.SetActive(true);
        obj_figura4.SetActive(true);
        obj_figura5.SetActive(true);
        obj_figura6.SetActive(true);
        obj_figura7.SetActive(true);
        obj_figura8.SetActive(true);
        obj_figura9.SetActive(true);
        obj_figura10.SetActive(true);
        obj_figura11.SetActive(true);
        obj_figura12.SetActive(true);
        obj_figura13.SetActive(true);
        obj_figura14.SetActive(true);
    }
    else{
      if (amostra == true){
        obj_carta1.SetActive(true);
        obj_carta2.SetActive(true);
        obj_carta3.SetActive(true);
        obj_carta4.SetActive(true);
        obj_carta5.SetActive(true);
        obj_carta6.SetActive(true);
        obj_carta7.SetActive(true);
        obj_carta8.SetActive(true);
        obj_carta9.SetActive(true);
        obj_carta10.SetActive(true);
        obj_carta11.SetActive(true);
        obj_carta12.SetActive(true);
        obj_carta13.SetActive(true);
        obj_carta14.SetActive(true);
        obj_figura1.SetActive(false);
        obj_figura2.SetActive(false);
        obj_figura3.SetActive(false);
        obj_figura4.SetActive(false);
        obj_figura5.SetActive(false);
        obj_figura6.SetActive(false);
        obj_figura7.SetActive(false);
        obj_figura8.SetActive(false);
        obj_figura9.SetActive(false);
        obj_figura10.SetActive(false);
        obj_figura11.SetActive(false);
        obj_figura12.SetActive(false);
        obj_figura13.SetActive(false);
        obj_figura14.SetActive(false);
        amostra = false;
        inicio = true;
       }
    }
    if (timerErro > -2 && aux == 1){
        liberado = false;
    }
    else{
        if (aux == 1){
            primeira_escolha = 0;
            segunda_escolha = 0;
            aux = 0;
            mensagem1.text = "";
            errou = false;
            liberado = true;
            timerErro = 0.5;
            inicio = true;
        }
    }
    if (inicio == true){
        if (revelou1 == false){
            obj_carta1.SetActive(true);
            obj_figura1.SetActive(false);
        }
        if (revelou2 == false){
            obj_carta2.SetActive(true);
            obj_figura2.SetActive(false);
        }
        if (revelou3 == false){
            obj_carta3.SetActive(true);
            obj_figura3.SetActive(false);
        }
        if (revelou4 == false){
            obj_carta4.SetActive(true);
            obj_figura4.SetActive(false);
        }
        if (revelou5 == false){
            obj_carta5.SetActive(true);
            obj_figura5.SetActive(false);
        }
        if (revelou6 == false){
            obj_carta6.SetActive(true);
            obj_figura6.SetActive(false);
        }
        if (revelou7 == false){
            obj_carta7.SetActive(true);
            obj_figura7.SetActive(false);
        }
        if (revelou8 == false){
            obj_carta8.SetActive(true);
            obj_figura8.SetActive(false);
        }
        if (revelou9 == false){
            obj_carta9.SetActive(true);
            obj_figura9.SetActive(false);
        }
        if (revelou10 == false){
            obj_carta10.SetActive(true);
            obj_figura10.SetActive(false);
        }
        if (revelou11 == false){
            obj_carta11.SetActive(true);
            obj_figura11.SetActive(false);
        }
        if (revelou12 == false){
            obj_carta12.SetActive(true);
            obj_figura12.SetActive(false);
        }
        if (revelou13 == false){
            obj_carta13.SetActive(true);
            obj_figura13.SetActive(false);
        }
        if (revelou14 == false){
            obj_carta14.SetActive(true);
            obj_figura14.SetActive(false);
        }
        primeira_escolha = 0;
        segunda_escolha = 0;
    }
    /*if (Input.GetKeyDown(KeyCode.Space)){
          mensagem1.text = "";
          mensagem2.text = "";
          errou = false;
          liberado = true;
          inicio = true;
    }*/

    /*if (Input.GetKeyDown(KeyCode.Space) && final == true){
        mensagem1.text = "Você venceu";
        mensagem2.text = "";
    }*/
    /*if (timer<-5){
        if (final == true){
           if (UserData.cont_jogo_memoria<=3){
                WWW www_gerarnumero = new WWW (url_aleatorio);
                StartCoroutine(Num_aleatorio(www_gerarnumero));
            }
            else{
               SceneManager.LoadScene("TelaVitoria");
            }
        }
    }*/

/*
PAVAN, Evandro. Gestão da Qualidade. 2017. Disponivel em: <http://geqs.com.br/servicos/gestao-em-saude/qualidade-em-saude>. Acesso em 25 de maio de 2019.
IDEAL MARKETING. O que é análise SWOT. 2018. Disponivel em: <https://www.idealmarketing.com.br/blog/o-que-e-analise-swot>. Acesso em 25 de maio de 2019.
GUERRERA, JON. Using Kaizen for Your Personal Goals. 2012. Disponivel em: <https://livingforimprovement.com/slow-and-steady-using-kaizen>. Acesso em 25 de maio de 2019.
SABINO, Gabi. A ferramenta 5W2H é útil. 2015. Disponivel em: <http://www.radardeprojetos.com.br/2015/03/a-ferramenta-5w2h-e-util>. Acesso em 25 de maio de 2019.
PRIORITY PARTNERS. A Matriz GUT. 2015. Disponivel em: <http://p1p.com.br/wp-content/uploads/2015/08/GUT.png>. Acesso em 25 de maio de 2019.
SALES, Rafaela. Ferramentas de Qualidade: Conceito e Aplicação. 2017. Disponivel em: <http://www.portal-administracao.com/2017/09/sete-ferramentas-da-qualidade-conceito>. Acesso em 25 de maio de 2019.
2. RAVAZOLLO, Rafael. Administração MPU. Casa do Concurseiro. 17  de setembro de 2018.
DESIGN LIVRE RECURSOS E SOFTWARE


Referências Bibliográficas:

1. DEVMIDIA. Testes de Software. 2018. Disponivel em: <https://www.devmedia.com.br/guia/testes-de-software/34403>. Acesso em 25 de maio de 2019.

2. TARGETRUST. Os 13 Principais Testes de Software.  Disponivel em: <https://targettrust.com.br/blog/os-13-principais-tipos-de-testes-de-software/>. Acesso em 25 de maio de 2019.



GONÇALVES, Victor. As 7 ferramentas de qualidade.  23  de março de 2019. Disponível em: <https://www.voitto.com.br/blog/artigo/as-7-ferramentas-da-qualidade>, acesso em 25 de maio de 2019. 

2. RAVAZOLLO, Rafael. Administração MPU. Casa do Concurseiro. 17  de setembro de 2018.

ÍCONS8. Design Livre Recursos e Software. 2019. Disponivel em: <https://icons8.com.br/icons/set/diagrama>. Acesso em 25 de maio de 2019.
ÍCONS8. Design Livre Recursos e Software. 2019. Disponivel em: <https://icons8.com.br/icons/set/peixe>. Acesso em 25 de maio de 2019.
ÍCONS8. Design Livre Recursos e Software. 2019. Disponivel em: <https://icons8.com.br/icons/set/dispersao>. Acesso em 25 de maio de 2019.
ÍCONS8. Design Livre Recursos e Software. 2019. Disponivel em: <https://icons8.com.br/icons/set/grafico>. Acesso em 25 de maio de 2019.
ÍCONS8. Design Livre Recursos e Software. 2019. Disponivel em: <https://icons8.com.br/icons/set/histograma>. Acesso em 25 de maio de 2019.
ÍCONS8. Design Livre Recursos e Software. 2019. Disponivel em: <https://icons8.com.br/icons/set/checklist>. Acesso em 25 de maio de 2019.




SIX SIGMAS STYDY GUIDE. 2017. Disponível em: <https://sixsigmastudyguide.com/a-study-guide-to-the-founding-fathers-of-six-sigma-and-the-quality-movement>, acesso em 25 de maio de 2019. 
*/


    if (contador == 7){
       mensagem1.text = "Parabéns, você acertou!";
       liberado = false;
       final = true;
       emoji_chorando.SetActive(false);
       emoji_normal.SetActive(false);
       emoji_feliz.SetActive(false);
       emoji_triste.SetActive(false);
       emoji_amei.SetActive(true);
    }
    if (errou == true){
          aux = 1;
          timerErro -= Time.deltaTime;
    }
}

IEnumerator Num_aleatorio(WWW www_gerarnumero){
        yield return www_gerarnumero;
        num_gerado = www_gerarnumero.text.ToString();
        num_gerado = num_gerado.TrimEnd();
        UserData.cont_jogo_memoria =  UserData.cont_jogo_memoria+1;
            if (num_gerado == "1" || num_gerado == "2"){
               UserData.cod_memoria = "";
               UserData.cod_memoria = num_gerado;
               SceneManager.LoadScene("JogoMemoria3v1");
            }
            if (num_gerado == "3" || num_gerado == "4"){
               UserData.cod_memoria = "";
               UserData.cod_memoria = num_gerado;
               SceneManager.LoadScene("JogoMemoria3v2");
            }
            if (num_gerado == "5" || num_gerado == "6"){
               UserData.cod_memoria = "";
               UserData.cod_memoria = num_gerado;
               SceneManager.LoadScene("JogoMemoria3v3");
            }
            if (num_gerado == "7" || num_gerado == "8"){
               UserData.cod_memoria = "";
               UserData.cod_memoria = num_gerado;
               SceneManager.LoadScene("JogoMemoria3v4");
            }
            if (num_gerado == "9" || num_gerado == "10"){
               UserData.cod_memoria = "";
               UserData.cod_memoria = num_gerado;
               SceneManager.LoadScene("JogoMemoria3v5");
            }
        //num = int.Parse(num_gerado);
        /*é_igual = false; 
        if (UserData.JogoMemoriaAtual[1] == num){
            é_igual = true;
        }
        if (UserData.JogoMemoriaAtual[2] == num && é_igual == false){
            é_igual = true;
        }
        if (UserData.JogoMemoriaAtual[3] == num && é_igual == false){
            é_igual = true;
        }
        if (é_igual == true){
            PrepararDesafio();
        }
        else{
            UserData.id_jogo_memoria_atual = num;
            UserData.cont_jogo_memoria =  UserData.cont_jogo_memoria++;
            WWW wwwww = new WWW (url_aleatorio);
            StartCoroutine(IniciarMemoria(wwwww));
        }*/
}

IEnumerator IniciarMemoria(WWW wwwww){
        yield return wwwww;
        num_gerado = wwwww.text.ToString();
        num_gerado = num_gerado.TrimEnd();
        if (num == 1){
            if (num_gerado == "1" || num_gerado == "2"){
            }
            if (num_gerado == "3" || num_gerado == "4"){
            }
            if (num_gerado == "5" || num_gerado == "6"){
            }
            if (num_gerado == "7" || num_gerado == "8"){
            }
            if (num_gerado == "9" || num_gerado == "10"){
            }
        }
        if (num == 2){
            if (num_gerado == "1" || num_gerado == "2"){
            }
            if (num_gerado == "3" || num_gerado == "4"){
            }
            if (num_gerado == "5" || num_gerado == "6"){
            }
            if (num_gerado == "7" || num_gerado == "8"){
            }
            if (num_gerado == "9" || num_gerado == "10"){
            }
        }
        if (num == 3){
            if (num_gerado == "1" || num_gerado == "2"){
            }
            if (num_gerado == "3" || num_gerado == "4"){
            }
            if (num_gerado == "5" || num_gerado == "6"){
            }
            if (num_gerado == "7" || num_gerado == "8"){
            }
            if (num_gerado == "9" || num_gerado == "10"){
            }
            SceneManager.LoadScene("JogoMemoria");
        }        
}


void Carta1(){
    if (liberado == true){
     inicio = false;
     limpou1 = false;
     obj_carta1.SetActive(false);
     obj_figura1.SetActive(true);
     mensagem1.text = "";
     mensagem2.text = "";
     emoji_chorando.SetActive(false);
     emoji_normal.SetActive(true);
     emoji_feliz.SetActive(false);
     emoji_triste.SetActive(false);
     emoji_amei.SetActive(false);
     if (primeira_escolha == 0){
         primeira_escolha = 1;
     }
     else{
        limpou2 = false;
        segunda_escolha = 1;
        VerificarJogada();
     }
    }
}

void Carta2(){
    if (liberado == true){
     limpou1 = false;
     inicio = false;
     obj_carta2.SetActive(false);
     obj_figura2.SetActive(true);
     mensagem1.text = "";
     mensagem2.text = "";
     emoji_chorando.SetActive(false);
     emoji_normal.SetActive(true);
     emoji_feliz.SetActive(false);
     emoji_triste.SetActive(false);
     emoji_amei.SetActive(false);
     if (primeira_escolha == 0){
         primeira_escolha = 2;
     }
     else{
        limpou2 = false;
        segunda_escolha = 2;
        VerificarJogada();
     }
    }
}

void Carta3(){
    if (liberado == true){
     limpou1 = false;
     inicio = false;
     obj_carta3.SetActive(false);
     obj_figura3.SetActive(true);
     mensagem1.text = "";
     mensagem2.text = "";
     emoji_chorando.SetActive(false);
     emoji_normal.SetActive(true);
     emoji_feliz.SetActive(false);
     emoji_triste.SetActive(false);
     emoji_amei.SetActive(false);
     if (primeira_escolha == 0){
         primeira_escolha = 3;
     }
     else{
        limpou2 = false;
        segunda_escolha = 3;
        VerificarJogada();
     }
    }
}

void Carta4(){
    if (liberado == true){
     limpou1 = false;
     inicio = false;
     obj_carta4.SetActive(false);
     obj_figura4.SetActive(true);
     mensagem1.text = "";
     mensagem2.text = "";
     emoji_chorando.SetActive(false);
     emoji_normal.SetActive(true);
     emoji_feliz.SetActive(false);
     emoji_triste.SetActive(false);
     emoji_amei.SetActive(false);
     if (primeira_escolha == 0){
         primeira_escolha = 4;
     }
     else{
        limpou2 = false;
        segunda_escolha = 4;
        VerificarJogada();
     }
    }
}

void Carta5(){
    if (liberado == true){
     limpou1 = false;
     inicio = false;
     obj_carta5.SetActive(false);
     obj_figura5.SetActive(true);
     mensagem1.text = "";
     mensagem2.text = "";
     emoji_chorando.SetActive(false);
     emoji_normal.SetActive(true);
     emoji_feliz.SetActive(false);
     emoji_triste.SetActive(false);
     emoji_amei.SetActive(false);
     if (primeira_escolha == 0){
         primeira_escolha = 5;
     }
     else{
        limpou2 = false;
        segunda_escolha = 5;
        VerificarJogada();
     }
    }
}

void Carta6(){
    if (liberado == true){
     limpou1 = false;
     inicio = false;
     obj_carta6.SetActive(false);
     obj_figura6.SetActive(true);
     mensagem1.text = "";
     mensagem2.text = "";
     emoji_chorando.SetActive(false);
     emoji_normal.SetActive(true);
     emoji_feliz.SetActive(false);
     emoji_triste.SetActive(false);
     emoji_amei.SetActive(false);
     if (primeira_escolha == 0){
         primeira_escolha = 6;
     }
     else{
        limpou2 = false;
        segunda_escolha = 6;
        VerificarJogada();
     }
    }
}

void Carta7(){
    if (liberado == true){
     limpou1 = false;
     inicio = false;
     obj_carta7.SetActive(false);
     obj_figura7.SetActive(true);
     mensagem1.text = "";
     mensagem2.text = "";
     emoji_chorando.SetActive(false);
     emoji_normal.SetActive(true);
     emoji_feliz.SetActive(false);
     emoji_triste.SetActive(false);
     emoji_amei.SetActive(false);
     if (primeira_escolha == 0){
         primeira_escolha = 7;
     }
     else{
        limpou2 = false;
        segunda_escolha = 7;
        VerificarJogada();
     }
    }
}

void Carta8(){
    if (liberado == true){
     limpou1 = false;
     inicio = false;
     obj_carta8.SetActive(false);
     obj_figura8.SetActive(true);
     mensagem1.text = "";
     mensagem2.text = "";
     emoji_chorando.SetActive(false);
     emoji_normal.SetActive(true);
     emoji_feliz.SetActive(false);
     emoji_triste.SetActive(false);
     emoji_amei.SetActive(false);
     if (primeira_escolha == 0){
         primeira_escolha = 8;
     }
     else{
        limpou2 = false;
        segunda_escolha = 8;
        VerificarJogada();
     }
    }
}

void Carta9(){
    if (liberado == true){
     limpou1 = false;
     inicio = false;
     obj_carta9.SetActive(false);
     obj_figura9.SetActive(true);
     mensagem1.text = "";
     mensagem2.text = "";
     emoji_chorando.SetActive(false);
     emoji_normal.SetActive(true);
     emoji_feliz.SetActive(false);
     emoji_triste.SetActive(false);
     emoji_amei.SetActive(false);
     if (primeira_escolha == 0){
         primeira_escolha = 9;
     }
     else{
        limpou2 = false;
        segunda_escolha = 9;
        VerificarJogada();
     }
    }
}

void Carta10(){
    if (liberado == true){
     limpou1 = false;
     inicio = false;
     obj_carta10.SetActive(false);
     obj_figura10.SetActive(true);
     mensagem1.text = "";
     mensagem2.text = "";
     emoji_chorando.SetActive(false);
     emoji_normal.SetActive(true);
     emoji_feliz.SetActive(false);
     emoji_triste.SetActive(false);
     emoji_amei.SetActive(false);
     if (primeira_escolha == 0){
         primeira_escolha = 10;
     }
     else{
        limpou2 = false;
        segunda_escolha = 10;
        VerificarJogada();
     }
    }
}

void Carta11(){
    if (liberado == true){
     limpou1 = false;
     inicio = false;
     obj_carta11.SetActive(false);
     obj_figura11.SetActive(true);
     mensagem1.text = "";
     mensagem2.text = "";
     emoji_chorando.SetActive(false);
     emoji_normal.SetActive(true);
     emoji_feliz.SetActive(false);
     emoji_triste.SetActive(false);
     emoji_amei.SetActive(false);
     if (primeira_escolha == 0){
         primeira_escolha = 11;
     }
     else{
        limpou2 = false;
        segunda_escolha = 11;
        VerificarJogada();
     }
    }
}

void Carta12(){
    if (liberado == true){
     limpou1 = false;
     inicio = false;
     obj_carta12.SetActive(false);
     obj_figura12.SetActive(true);
     mensagem1.text = "";
     mensagem2.text = "";
     emoji_chorando.SetActive(false);
     emoji_normal.SetActive(true);
     emoji_feliz.SetActive(false);
     emoji_triste.SetActive(false);
     emoji_amei.SetActive(false);
     if (primeira_escolha == 0){
         primeira_escolha = 12;
     }
     else{
        limpou2 = false;
        segunda_escolha = 12;
        VerificarJogada();
     }
    }
}

void Carta13(){
    if (liberado == true){
     limpou1 = false;
     inicio = false;
     obj_carta13.SetActive(false);
     obj_figura13.SetActive(true);
     mensagem1.text = "";
     mensagem2.text = "";
     emoji_chorando.SetActive(false);
     emoji_normal.SetActive(true);
     emoji_feliz.SetActive(false);
     emoji_triste.SetActive(false);
     emoji_amei.SetActive(false);
     if (primeira_escolha == 0){
         primeira_escolha = 13;
     }
     else{
        limpou2 = false;
        segunda_escolha = 13;
        VerificarJogada();
     }
    }
}

void Carta14(){
    if (liberado == true){
     limpou1 = false;
     inicio = false;
     obj_carta14.SetActive(false);
     obj_figura14.SetActive(true);
     mensagem1.text = "";
     mensagem2.text = "";
     emoji_chorando.SetActive(false);
     emoji_normal.SetActive(true);
     emoji_feliz.SetActive(false);
     emoji_triste.SetActive(false);
     emoji_amei.SetActive(false);
     if (primeira_escolha == 0){
         primeira_escolha = 14;
     }
     else{
        limpou2 = false;
        segunda_escolha = 14;
        VerificarJogada();
     }
    }
}

void VerificarJogada(){
    if (UserData.cod_memoria == "1" || UserData.cod_memoria == "2"){
    if ((primeira_escolha == 1 && segunda_escolha == 12) || (primeira_escolha == 12 && segunda_escolha == 1)){
        emoji_chorando.SetActive(false);
        emoji_normal.SetActive(false);
        emoji_feliz.SetActive(true);
        emoji_triste.SetActive(false);
        emoji_amei.SetActive(false);
        object_pdca.SetActive(true);
        acertou = true;
        revelou1 = true;
        revelou12 = true;
        contador = contador+1;
        primeira_escolha = 0;
        segunda_escolha = 0; 
        mensagem1.text = "Parabéns, você acertou!";
        mensagem2.text = "O Diagrama de Ishikawa permite estruturar as causas de um problema ou oportunidade de melhoria. Sendo extremamente útil, pois ajuda  a explorar todas as causas potenciais ou reais que resultam em um defeito ou falha. Diante disso, podemos propor as melhores ações para sanar um problema.";
    }
    if ((primeira_escolha == 2 && segunda_escolha == 13) || (primeira_escolha == 13 && segunda_escolha == 2)){
        emoji_chorando.SetActive(false);
        emoji_normal.SetActive(false);
        emoji_feliz.SetActive(true);
        emoji_triste.SetActive(false);
        emoji_amei.SetActive(false);
        acertou = true;
        revelou2 = true;
        revelou13 = true;
        contador = contador+1;
        primeira_escolha = 0;
        segunda_escolha = 0; 
        mensagem1.text = "Parabéns, você acertou!";
        object_kaizen.SetActive(true);
        mensagem2.text = "Um Histograma é a representação gráfica de um conjunto de dados previamente tabulado e dividido em classes uniformes. Ao dispor as informações graficamente, permite a visualização dos valores centrais, a dispersão em torno dos valores centrais e a forma da distribuição."; 
    }
    if ((primeira_escolha == 3 && segunda_escolha == 5) || (primeira_escolha == 5 && segunda_escolha == 3)){
        emoji_chorando.SetActive(false);
        emoji_normal.SetActive(false);
        emoji_feliz.SetActive(true);
        emoji_triste.SetActive(false);
        emoji_amei.SetActive(false);
        acertou = true;
        revelou3 = true;
        revelou5 = true;
        contador = contador+1;
        primeira_escolha = 0;
        segunda_escolha = 0; 
        mensagem1.text = "Parabéns, você acertou!";
        object_gut.SetActive(true);
        mensagem2.text = "O fluxograma é um diagrama que expressa um determinado processo de forma sequencial, gráfica, simples e objetiva. O objetivo é estabelecer uma gestão à vista, de forma a facilitar o entendimento das etapas que compõem um processo";
    }
    if ((primeira_escolha == 4 && segunda_escolha == 8) || (primeira_escolha == 8 && segunda_escolha == 4)){
        emoji_chorando.SetActive(false);
        emoji_normal.SetActive(false);
        emoji_feliz.SetActive(true);
        emoji_triste.SetActive(false);
        emoji_amei.SetActive(false);
        acertou = true;
        revelou4 = true;
        revelou8 = true;
        contador = contador+1;
        primeira_escolha = 0;
        segunda_escolha = 0; 
        mensagem1.text = "Parabéns, você acertou!";
        object_swot.SetActive(true);
        mensagem2.text = "Uma carta de controle é um conjunto de amostras ordenadas, no tempo, que são interpretados em função de linhas horizontais, chamadas de LSC (limite superior de controle) e LIC (limite inferior de controle). A partir da verificação, pode-se agir para corrigir os eventuais problemas no processo, gerando maior eficiência.";
    }
    if ((primeira_escolha == 6 && segunda_escolha == 11) || (primeira_escolha == 11 && segunda_escolha == 6)){
        emoji_chorando.SetActive(false);
        emoji_normal.SetActive(false);
        emoji_feliz.SetActive(true);
        emoji_triste.SetActive(false);
        emoji_amei.SetActive(false);
        acertou = true;
        revelou6 = true;
        revelou11 = true;
        contador = contador+1;
        primeira_escolha = 0;
        segunda_escolha = 0; 
        mensagem1.text = "Parabéns, você acertou!";
        object_sigma.SetActive(true);
        mensagem2.text = "As folhas de verificação são formulários em que os dados coletados são preenchidos de forma rápida, fácil e concisa. Registram dados e itens a serem verificados momentaneamente e também serve para identificar não conformidades no processo.";
    }
    if ((primeira_escolha == 7 && segunda_escolha == 10) || (primeira_escolha == 10 && segunda_escolha == 7)){
        emoji_chorando.SetActive(false);
        emoji_normal.SetActive(false);
        emoji_feliz.SetActive(true);
        emoji_triste.SetActive(false);
        emoji_amei.SetActive(false);
        acertou = true;
        revelou7 = true;
        revelou10 = true;
        contador = contador+1;
        primeira_escolha = 0;
        segunda_escolha = 0; 
        mensagem1.text = "Parabéns, você acertou!";
        object_bcg.SetActive(true);
        mensagem2.text = "Os Diagramas de dispersão são representações de duas ou mais variáveis que são organizadas em um gráfico, uma em função da outra. Ao entender a correlação entre duas variáveis e como uma pode influenciar a outra, podemos determinar o melhor uso delas para melhorar a qualidade e produtividade da  empresa.";
    }
    if ((primeira_escolha == 9 && segunda_escolha == 14) || (primeira_escolha == 14 && segunda_escolha == 9)){
        emoji_chorando.SetActive(false);
        emoji_normal.SetActive(false);
        emoji_feliz.SetActive(true);
        emoji_triste.SetActive(false);
        emoji_amei.SetActive(false);
        acertou = true;
        revelou9 = true;
        revelou14 = true;
        primeira_escolha = 0;
        segunda_escolha = 0; 
        contador = contador+1;
        mensagem1.text = "Parabéns, você acertou!";
        object_5W2H.SetActive(true);
        mensagem2.text = "O Diagrama de Pareto, mais conhecido como regra 20-80, nos diz que 20% das causas principais são responsáveis por 80% dos problemas em uma organização. Ou seja, se solucionarmos essas 20% principais, acabamos com boa parte dos problemas.";

    }
    if (acertou == false){
        mensagem1.text = "Ops, este não é o par correto!";
        errou = true;
        liberado = false;
        emoji_chorando.SetActive(true);
        emoji_normal.SetActive(false);
        emoji_feliz.SetActive(false);
        emoji_triste.SetActive(false);
        emoji_amei.SetActive(false);
    }
    acertou = false;
    }
    if (UserData.cod_memoria == "3" || UserData.cod_memoria == "4"){
    if ((primeira_escolha == 8 && segunda_escolha == 14) || (primeira_escolha == 14 && segunda_escolha == 8)){
        emoji_chorando.SetActive(false);
        emoji_normal.SetActive(false);
        emoji_feliz.SetActive(true);
        emoji_triste.SetActive(false);
        emoji_amei.SetActive(false);
        acertou = true;
        revelou8 = true;
        revelou14 = true;
        contador = contador+1;
        primeira_escolha = 0;
        segunda_escolha = 0; 
        mensagem1.text = "Parabéns, você acertou!";
        object_pdca.SetActive(true);
        mensagem2.text = "O Diagrama de Ishikawa permite estruturar as causas de um problema ou oportunidade de melhoria. Sendo extremamente útil, pois ajuda  a explorar todas as causas potenciais ou reais que resultam em um defeito ou falha. Diante disso, podemos propor as melhores ações para sanar um problema.";
    }
    if ((primeira_escolha == 7 && segunda_escolha == 13) || (primeira_escolha == 13 && segunda_escolha == 7)){
        emoji_chorando.SetActive(false);
        emoji_normal.SetActive(false);
        emoji_feliz.SetActive(true);
        emoji_triste.SetActive(false);
        emoji_amei.SetActive(false);
        acertou = true;
        revelou7 = true;
        revelou13 = true;
        contador = contador+1;
        primeira_escolha = 0;
        segunda_escolha = 0; 
        mensagem1.text = "Parabéns, você acertou!";
        object_kaizen.SetActive(true);
        mensagem2.text = "Um Histograma é a representação gráfica de um conjunto de dados previamente tabulado e dividido em classes uniformes. Ao dispor as informações graficamente, permite a visualização dos valores centrais, a dispersão em torno dos valores centrais e a forma da distribuição."; 
    }
    if ((primeira_escolha == 1 && segunda_escolha == 5) || (primeira_escolha == 5 && segunda_escolha == 1)){
        emoji_chorando.SetActive(false);
        emoji_normal.SetActive(false);
        emoji_feliz.SetActive(true);
        emoji_triste.SetActive(false);
        emoji_amei.SetActive(false);
        acertou = true;
        revelou1 = true;
        revelou5 = true;
        contador = contador+1;
        primeira_escolha = 0;
        segunda_escolha = 0; 
        mensagem1.text = "Parabéns, você acertou!";
        object_gut.SetActive(true);
        mensagem2.text = "O fluxograma é um diagrama que expressa um determinado processo de forma sequencial, gráfica, simples e objetiva. O objetivo é estabelecer uma gestão à vista, de forma a facilitar o entendimento das etapas que compõem um processo";
    }
    if ((primeira_escolha == 4 && segunda_escolha == 6) || (primeira_escolha == 6 && segunda_escolha == 4)){
        emoji_chorando.SetActive(false);
        emoji_normal.SetActive(false);
        emoji_feliz.SetActive(true);
        emoji_triste.SetActive(false);
        emoji_amei.SetActive(false);
        acertou = true;
        revelou4 = true;
        revelou6 = true;
        contador = contador+1;
        primeira_escolha = 0;
        segunda_escolha = 0; 
        mensagem1.text = "Parabéns, você acertou!";
        object_swot.SetActive(true);
        mensagem2.text = "Uma carta de controle é um conjunto de amostras ordenadas, no tempo, que são interpretados em função de linhas horizontais, chamadas de LSC (limite superior de controle) e LIC (limite inferior de controle). A partir da verificação, pode-se agir para corrigir os eventuais problemas no processo, gerando maior eficiência.";
    }
    if ((primeira_escolha == 3 && segunda_escolha == 11) || (primeira_escolha == 11 && segunda_escolha == 3)){
        emoji_chorando.SetActive(false);
        emoji_normal.SetActive(false);
        emoji_feliz.SetActive(true);
        emoji_triste.SetActive(false);
        emoji_amei.SetActive(false);
        acertou = true;
        revelou3 = true;
        revelou11 = true;
        contador = contador+1;
        primeira_escolha = 0;
        segunda_escolha = 0; 
        mensagem1.text = "Parabéns, você acertou!";
        object_sigma.SetActive(true);
        mensagem2.text = "As folhas de verificação são formulários em que os dados coletados são preenchidos de forma rápida, fácil e concisa. Registram dados e itens a serem verificados momentaneamente e também serve para identificar não conformidades no processo.";
    }
    if ((primeira_escolha == 2 && segunda_escolha == 10) || (primeira_escolha == 10 && segunda_escolha == 2)){
        emoji_chorando.SetActive(false);
        emoji_normal.SetActive(false);
        emoji_feliz.SetActive(true);
        emoji_triste.SetActive(false);
        emoji_amei.SetActive(false);
        acertou = true;
        revelou2 = true;
        revelou10 = true;
        contador = contador+1;
        primeira_escolha = 0;
        segunda_escolha = 0; 
        mensagem1.text = "Parabéns, você acertou!";
        object_bcg.SetActive(true);
        mensagem2.text = "Os Diagramas de dispersão são representações de duas ou mais variáveis que são organizadas em um gráfico, uma em função da outra. Ao entender a correlação entre duas variáveis e como uma pode influenciar a outra, podemos determinar o melhor uso delas para melhorar a qualidade e produtividade da  empresa.";
    }
    if ((primeira_escolha == 9 && segunda_escolha == 12) || (primeira_escolha == 12 && segunda_escolha == 9)){
        emoji_chorando.SetActive(false);
        emoji_normal.SetActive(false);
        emoji_feliz.SetActive(true);
        emoji_triste.SetActive(false);
        emoji_amei.SetActive(false);
        acertou = true;
        revelou9 = true;
        revelou12 = true;
        primeira_escolha = 0;
        segunda_escolha = 0; 
        contador = contador+1;
        mensagem1.text = "Parabéns, você acertou!";
        object_5W2H.SetActive(true);
        mensagem2.text = "O Diagrama de Pareto, mais conhecido como regra 20-80, nos diz que 20% das causas principais são responsáveis por 80% dos problemas em uma organização. Ou seja, se solucionarmos essas 20% principais, acabamos com boa parte dos problemas.";

    }
    if (acertou == false){
        mensagem1.text = "Ops, este não é o par correto!";
        errou = true;
        liberado = false;
        emoji_chorando.SetActive(true);
        emoji_normal.SetActive(false);
        emoji_feliz.SetActive(false);
        emoji_triste.SetActive(false);
        emoji_amei.SetActive(false);
    }
    acertou = false;
    }
    if (UserData.cod_memoria == "5" || UserData.cod_memoria == "6"){
    if ((primeira_escolha == 7 && segunda_escolha == 11) || (primeira_escolha == 11 && segunda_escolha == 7)){
        emoji_chorando.SetActive(false);
        emoji_normal.SetActive(false);
        emoji_feliz.SetActive(true);
        emoji_triste.SetActive(false);
        emoji_amei.SetActive(false);
        acertou = true;
        revelou7 = true;
        revelou11 = true;
        contador = contador+1;
        primeira_escolha = 0;
        segunda_escolha = 0; 
        mensagem1.text = "Parabéns, você acertou!";
        object_pdca.SetActive(true);
        mensagem2.text = "O Diagrama de Ishikawa permite estruturar as causas de um problema ou oportunidade de melhoria. Sendo extremamente útil, pois ajuda  a explorar todas as causas potenciais ou reais que resultam em um defeito ou falha. Diante disso, podemos propor as melhores ações para sanar um problema.";
    }
    if ((primeira_escolha == 1 && segunda_escolha == 10) || (primeira_escolha == 10 && segunda_escolha == 1)){
        emoji_chorando.SetActive(false);
        emoji_normal.SetActive(false);
        emoji_feliz.SetActive(true);
        emoji_triste.SetActive(false);
        emoji_amei.SetActive(false);
        acertou = true;
        revelou1 = true;
        revelou10 = true;
        contador = contador+1;
        primeira_escolha = 0;
        segunda_escolha = 0; 
        mensagem1.text = "Parabéns, você acertou!";
        object_kaizen.SetActive(true);
        mensagem2.text = "Um Histograma é a representação gráfica de um conjunto de dados previamente tabulado e dividido em classes uniformes. Ao dispor as informações graficamente, permite a visualização dos valores centrais, a dispersão em torno dos valores centrais e a forma da distribuição."; 
    }
    if ((primeira_escolha == 3 && segunda_escolha == 13) || (primeira_escolha == 13 && segunda_escolha == 3)){
        emoji_chorando.SetActive(false);
        emoji_normal.SetActive(false);
        emoji_feliz.SetActive(true);
        emoji_triste.SetActive(false);
        emoji_amei.SetActive(false);
        acertou = true;
        revelou3 = true;
        revelou13 = true;
        contador = contador+1;
        primeira_escolha = 0;
        segunda_escolha = 0; 
        mensagem1.text = "Parabéns, você acertou!";
        object_gut.SetActive(true);
        mensagem2.text = "O fluxograma é um diagrama que expressa um determinado processo de forma sequencial, gráfica, simples e objetiva. O objetivo é estabelecer uma gestão à vista, de forma a facilitar o entendimento das etapas que compõem um processo";
    }
    if ((primeira_escolha == 2 && segunda_escolha == 12) || (primeira_escolha == 12 && segunda_escolha == 2)){
        emoji_chorando.SetActive(false);
        emoji_normal.SetActive(false);
        emoji_feliz.SetActive(true);
        emoji_triste.SetActive(false);
        emoji_amei.SetActive(false);
        acertou = true;
        revelou2 = true;
        revelou12 = true;
        contador = contador+1;
        primeira_escolha = 0;
        segunda_escolha = 0; 
        mensagem1.text = "Parabéns, você acertou!";
        object_swot.SetActive(true);
        mensagem2.text = "Uma carta de controle é um conjunto de amostras ordenadas, no tempo, que são interpretados em função de linhas horizontais, chamadas de LSC (limite superior de controle) e LIC (limite inferior de controle). A partir da verificação, pode-se agir para corrigir os eventuais problemas no processo, gerando maior eficiência.";
    }
    if ((primeira_escolha == 4 && segunda_escolha == 14) || (primeira_escolha == 14 && segunda_escolha == 4)){
        emoji_chorando.SetActive(false);
        emoji_normal.SetActive(false);
        emoji_feliz.SetActive(true);
        emoji_triste.SetActive(false);
        emoji_amei.SetActive(false);
        acertou = true;
        revelou4 = true;
        revelou14 = true;
        contador = contador+1;
        primeira_escolha = 0;
        segunda_escolha = 0; 
        mensagem1.text = "Parabéns, você acertou!";
        object_sigma.SetActive(true);
        mensagem2.text = "As folhas de verificação são formulários em que os dados coletados são preenchidos de forma rápida, fácil e concisa. Registram dados e itens a serem verificados momentaneamente e também serve para identificar não conformidades no processo.";
    }
    if ((primeira_escolha == 6 && segunda_escolha == 9) || (primeira_escolha == 9 && segunda_escolha == 6)){
        emoji_chorando.SetActive(false);
        emoji_normal.SetActive(false);
        emoji_feliz.SetActive(true);
        emoji_triste.SetActive(false);
        emoji_amei.SetActive(false);
        acertou = true;
        revelou6 = true;
        revelou9 = true;
        contador = contador+1;
        primeira_escolha = 0;
        segunda_escolha = 0; 
        mensagem1.text = "Parabéns, você acertou!";
        object_bcg.SetActive(true);
        mensagem2.text = "Os Diagramas de dispersão são representações de duas ou mais variáveis que são organizadas em um gráfico, uma em função da outra. Ao entender a correlação entre duas variáveis e como uma pode influenciar a outra, podemos determinar o melhor uso delas para melhorar a qualidade e produtividade da  empresa.";
    }
    if ((primeira_escolha == 5 && segunda_escolha == 8) || (primeira_escolha == 8 && segunda_escolha == 5)){
        emoji_chorando.SetActive(false);
        emoji_normal.SetActive(false);
        emoji_feliz.SetActive(true);
        emoji_triste.SetActive(false);
        emoji_amei.SetActive(false);
        acertou = true;
        revelou5 = true;
        revelou8 = true;
        primeira_escolha = 0;
        segunda_escolha = 0; 
        contador = contador+1;
        mensagem1.text = "Parabéns, você acertou!";
        object_5W2H.SetActive(true);
        mensagem2.text = "O Diagrama de Pareto, mais conhecido como regra 20-80, nos diz que 20% das causas principais são responsáveis por 80% dos problemas em uma organização. Ou seja, se solucionarmos essas 20% principais, acabamos com boa parte dos problemas.";

    }
    if (acertou == false){
        mensagem1.text = "Ops, este não é o par correto!";
        errou = true;
        liberado = false;
        emoji_chorando.SetActive(true);
        emoji_normal.SetActive(false);
        emoji_feliz.SetActive(false);
        emoji_triste.SetActive(false);
        emoji_amei.SetActive(false);
    }
    acertou = false;
    }
    if (UserData.cod_memoria == "7" || UserData.cod_memoria == "8"){
    if ((primeira_escolha == 3 && segunda_escolha == 6) || (primeira_escolha == 6 && segunda_escolha == 3)){
        emoji_chorando.SetActive(false);
        emoji_normal.SetActive(false);
        emoji_feliz.SetActive(true);
        emoji_triste.SetActive(false);
        emoji_amei.SetActive(false);
        acertou = true;
        revelou3 = true;
        revelou6 = true;
        contador = contador+1;
        primeira_escolha = 0;
        segunda_escolha = 0; 
        mensagem1.text = "Parabéns, você acertou!";
        object_pdca.SetActive(true);
        mensagem2.text = "O Diagrama de Ishikawa permite estruturar as causas de um problema ou oportunidade de melhoria. Sendo extremamente útil, pois ajuda  a explorar todas as causas potenciais ou reais que resultam em um defeito ou falha. Diante disso, podemos propor as melhores ações para sanar um problema.";
    }
    if ((primeira_escolha == 4 && segunda_escolha == 8) || (primeira_escolha == 8 && segunda_escolha == 4)){
        emoji_chorando.SetActive(false);
        emoji_normal.SetActive(false);
        emoji_feliz.SetActive(true);
        emoji_triste.SetActive(false);
        emoji_amei.SetActive(false);
        acertou = true;
        revelou8 = true;
        revelou4 = true;
        contador = contador+1;
        primeira_escolha = 0;
        segunda_escolha = 0; 
        mensagem1.text = "Parabéns, você acertou!";
        object_kaizen.SetActive(true);
        mensagem2.text = "Um Histograma é a representação gráfica de um conjunto de dados previamente tabulado e dividido em classes uniformes. Ao dispor as informações graficamente, permite a visualização dos valores centrais, a dispersão em torno dos valores centrais e a forma da distribuição."; 
    }
    if ((primeira_escolha == 2 && segunda_escolha == 5) || (primeira_escolha == 5 && segunda_escolha == 2)){
        emoji_chorando.SetActive(false);
        emoji_normal.SetActive(false);
        emoji_feliz.SetActive(true);
        emoji_triste.SetActive(false);
        emoji_amei.SetActive(false);
        acertou = true;
        revelou2 = true;
        revelou5 = true;
        contador = contador+1;
        primeira_escolha = 0;
        segunda_escolha = 0; 
        mensagem1.text = "Parabéns, você acertou!";
        object_gut.SetActive(true);
        mensagem2.text = "O fluxograma é um diagrama que expressa um determinado processo de forma sequencial, gráfica, simples e objetiva. O objetivo é estabelecer uma gestão à vista, de forma a facilitar o entendimento das etapas que compõem um processo";
    }
    if ((primeira_escolha == 7 && segunda_escolha == 10) || (primeira_escolha == 10 && segunda_escolha == 7)){
        emoji_chorando.SetActive(false);
        emoji_normal.SetActive(false);
        emoji_feliz.SetActive(true);
        emoji_triste.SetActive(false);
        emoji_amei.SetActive(false);
        acertou = true;
        revelou7 = true;
        revelou10 = true;
        contador = contador+1;
        primeira_escolha = 0;
        segunda_escolha = 0; 
        mensagem1.text = "Parabéns, você acertou!";
        object_swot.SetActive(true);
        mensagem2.text = "Uma carta de controle é um conjunto de amostras ordenadas, no tempo, que são interpretados em função de linhas horizontais, chamadas de LSC (limite superior de controle) e LIC (limite inferior de controle). A partir da verificação, pode-se agir para corrigir os eventuais problemas no processo, gerando maior eficiência.";
    }
    if ((primeira_escolha == 1 && segunda_escolha == 11) || (primeira_escolha == 11 && segunda_escolha == 1)){
        emoji_chorando.SetActive(false);
        emoji_normal.SetActive(false);
        emoji_feliz.SetActive(true);
        emoji_triste.SetActive(false);
        emoji_amei.SetActive(false);
        acertou = true;
        revelou1 = true;
        revelou11 = true;
        contador = contador+1;
        primeira_escolha = 0;
        segunda_escolha = 0; 
        mensagem1.text = "Parabéns, você acertou!";
        object_sigma.SetActive(true);
        mensagem2.text = "As folhas de verificação são formulários em que os dados coletados são preenchidos de forma rápida, fácil e concisa. Registram dados e itens a serem verificados momentaneamente e também serve para identificar não conformidades no processo.";
    }
    if ((primeira_escolha == 9 && segunda_escolha == 14) || (primeira_escolha == 14 && segunda_escolha == 9)){
        emoji_chorando.SetActive(false);
        emoji_normal.SetActive(false);
        emoji_feliz.SetActive(true);
        emoji_triste.SetActive(false);
        emoji_amei.SetActive(false);
        acertou = true;
        revelou9 = true;
        revelou14 = true;
        contador = contador+1;
        primeira_escolha = 0;
        segunda_escolha = 0; 
        mensagem1.text = "Parabéns, você acertou!";
        object_bcg.SetActive(true);
        mensagem2.text = "Os Diagramas de dispersão são representações de duas ou mais variáveis que são organizadas em um gráfico, uma em função da outra. Ao entender a correlação entre duas variáveis e como uma pode influenciar a outra, podemos determinar o melhor uso delas para melhorar a qualidade e produtividade da  empresa.";
    }
    if ((primeira_escolha == 12 && segunda_escolha == 13) || (primeira_escolha == 13 && segunda_escolha == 12)){
        emoji_chorando.SetActive(false);
        emoji_normal.SetActive(false);
        emoji_feliz.SetActive(true);
        emoji_triste.SetActive(false);
        emoji_amei.SetActive(false);
        acertou = true;
        revelou12 = true;
        revelou13 = true;
        primeira_escolha = 0;
        segunda_escolha = 0; 
        contador = contador+1;
        mensagem1.text = "Parabéns, você acertou!";
        object_5W2H.SetActive(true);
        mensagem2.text = "O Diagrama de Pareto, mais conhecido como regra 20-80, nos diz que 20% das causas principais são responsáveis por 80% dos problemas em uma organização. Ou seja, se solucionarmos essas 20% principais, acabamos com boa parte dos problemas.";

    }
    if (acertou == false){
        mensagem1.text = "Ops, este não é o par correto!";
        errou = true;
        liberado = false;
        emoji_chorando.SetActive(true);
        emoji_normal.SetActive(false);
        emoji_feliz.SetActive(false);
        emoji_triste.SetActive(false);
        emoji_amei.SetActive(false);
    }
    acertou = false;
    }
    if (UserData.cod_memoria == "9" || UserData.cod_memoria == "10"){
    if ((primeira_escolha == 8 && segunda_escolha == 11) || (primeira_escolha == 11 && segunda_escolha == 8)){
        emoji_chorando.SetActive(false);
        emoji_normal.SetActive(false);
        emoji_feliz.SetActive(true);
        emoji_triste.SetActive(false);
        emoji_amei.SetActive(false);
        object_pdca.SetActive(true);
        acertou = true;
        revelou8 = true;
        revelou11 = true;
        contador = contador+1;
        primeira_escolha = 0;
        segunda_escolha = 0; 
        mensagem1.text = "Parabéns, você acertou!";
        object_pdca.SetActive(true);
        mensagem2.text = "O Diagrama de Ishikawa permite estruturar as causas de um problema ou oportunidade de melhoria. Sendo extremamente útil, pois ajuda  a explorar todas as causas potenciais ou reais que resultam em um defeito ou falha. Diante disso, podemos propor as melhores ações para sanar um problema.";
    }
    if ((primeira_escolha == 7 && segunda_escolha == 10) || (primeira_escolha == 10 && segunda_escolha == 7)){
        emoji_chorando.SetActive(false);
        emoji_normal.SetActive(false);
        emoji_feliz.SetActive(true);
        emoji_triste.SetActive(false);
        emoji_amei.SetActive(false);
        acertou = true;
        revelou7 = true;
        revelou10 = true;
        contador = contador+1;
        primeira_escolha = 0;
        segunda_escolha = 0; 
        mensagem1.text = "Parabéns, você acertou!";
        object_kaizen.SetActive(true);
        mensagem2.text = "Um Histograma é a representação gráfica de um conjunto de dados previamente tabulado e dividido em classes uniformes. Ao dispor as informações graficamente, permite a visualização dos valores centrais, a dispersão em torno dos valores centrais e a forma da distribuição."; 
    }
    if ((primeira_escolha == 5 && segunda_escolha == 9) || (primeira_escolha == 9 && segunda_escolha == 5)){
        emoji_chorando.SetActive(false);
        emoji_normal.SetActive(false);
        emoji_feliz.SetActive(true);
        emoji_triste.SetActive(false);
        emoji_amei.SetActive(false);
        acertou = true;
        revelou9 = true;
        revelou5 = true;
        contador = contador+1;
        primeira_escolha = 0;
        segunda_escolha = 0; 
        mensagem1.text = "Parabéns, você acertou!";
        object_gut.SetActive(true);
        mensagem2.text = "O fluxograma é um diagrama que expressa um determinado processo de forma sequencial, gráfica, simples e objetiva. O objetivo é estabelecer uma gestão à vista, de forma a facilitar o entendimento das etapas que compõem um processo";
    }
    if ((primeira_escolha == 3 && segunda_escolha == 14) || (primeira_escolha == 14 && segunda_escolha == 3)){
        emoji_chorando.SetActive(false);
        emoji_normal.SetActive(false);
        emoji_feliz.SetActive(true);
        emoji_triste.SetActive(false);
        emoji_amei.SetActive(false);
        acertou = true;
        revelou3 = true;
        revelou14 = true;
        contador = contador+1;
        primeira_escolha = 0;
        segunda_escolha = 0; 
        mensagem1.text = "Parabéns, você acertou!";
        object_swot.SetActive(true);
        mensagem2.text = "Uma carta de controle é um conjunto de amostras ordenadas, no tempo, que são interpretados em função de linhas horizontais, chamadas de LSC (limite superior de controle) e LIC (limite inferior de controle). A partir da verificação, pode-se agir para corrigir os eventuais problemas no processo, gerando maior eficiência.";
    }
    if ((primeira_escolha == 4 && segunda_escolha == 6) || (primeira_escolha == 6 && segunda_escolha == 4)){
        emoji_chorando.SetActive(false);
        emoji_normal.SetActive(false);
        emoji_feliz.SetActive(true);
        emoji_triste.SetActive(false);
        emoji_amei.SetActive(false);
        acertou = true;
        revelou6 = true;
        revelou4 = true;
        contador = contador+1;
        primeira_escolha = 0;
        segunda_escolha = 0; 
        mensagem1.text = "Parabéns, você acertou!";
        object_sigma.SetActive(true);
        mensagem2.text = "As folhas de verificação são formulários em que os dados coletados são preenchidos de forma rápida, fácil e concisa. Registram dados e itens a serem verificados momentaneamente e também serve para identificar não conformidades no processo.";
    }
    if ((primeira_escolha == 2 && segunda_escolha == 13) || (primeira_escolha == 13 && segunda_escolha == 2)){
        emoji_chorando.SetActive(false);
        emoji_normal.SetActive(false);
        emoji_feliz.SetActive(true);
        emoji_triste.SetActive(false);
        emoji_amei.SetActive(false);
        acertou = true;
        revelou2 = true;
        revelou13 = true;
        contador = contador+1;
        primeira_escolha = 0;
        segunda_escolha = 0; 
        mensagem1.text = "Parabéns, você acertou!";
        object_bcg.SetActive(true);
        mensagem2.text = "Os Diagramas de dispersão são representações de duas ou mais variáveis que são organizadas em um gráfico, uma em função da outra. Ao entender a correlação entre duas variáveis e como uma pode influenciar a outra, podemos determinar o melhor uso delas para melhorar a qualidade e produtividade da  empresa.";
    }
    if ((primeira_escolha == 1 && segunda_escolha == 12) || (primeira_escolha == 12 && segunda_escolha == 1)){
        emoji_chorando.SetActive(false);
        emoji_normal.SetActive(false);
        emoji_feliz.SetActive(true);
        emoji_triste.SetActive(false);
        emoji_amei.SetActive(false);
        acertou = true;
        revelou1 = true;
        revelou12 = true;
        primeira_escolha = 0;
        segunda_escolha = 0; 
        contador = contador+1;
        mensagem1.text = "Parabéns, você acertou!";
        object_5W2H.SetActive(true);
        mensagem2.text = "O Diagrama de Pareto, mais conhecido como regra 20-80, nos diz que 20% das causas principais são responsáveis por 80% dos problemas em uma organização. Ou seja, se solucionarmos essas 20% principais, acabamos com boa parte dos problemas.";

    }
    if (acertou == false){
        mensagem1.text = "Ops, este não é o par correto!";
        errou = true;
        liberado = false;
        emoji_chorando.SetActive(true);
        emoji_normal.SetActive(false);
        emoji_feliz.SetActive(false);
        emoji_triste.SetActive(false);
        emoji_amei.SetActive(false);
    }
    acertou = false;
    }

}

void Parar(){
     UserData.id_jogo_memoria_atual = 0;
     UserData.cont_jogo_memoria = 0;
     UserData.JogoMemoriaAtual[0] = 0;
     UserData.JogoMemoriaAtual[1] = 0;
     UserData.JogoMemoriaAtual[2] = 0;
     UserData.JogoMemoriaAtual[3] = 0;
     SceneManager.LoadScene("TelaJogo");
}
}
