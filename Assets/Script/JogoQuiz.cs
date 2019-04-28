using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JogoQuiz : MonoBehaviour {

public Button button_ajuda;
public Button button_responder;
public Button button_parar;
public GameObject alternativa_a;
public GameObject alternativa_b;
public GameObject alternativa_c;
public GameObject alternativa_d;
public GameObject alternativa_e;
public Text enunciado, letra_a, letra_b, letra_c, letra_d, letra_e, mensagem; 
public string banca, ano, gabarito;
public string url_selectJogoQuiz = "https://qualif.000webhostapp.com/html/selectJogoQuiz.php";
public string url_salvar = "https://qualif.000webhostapp.com/html/salvarJogadorQuiz.php";
public string url_aleatorio = "https://qualif.000webhostapp.com/html/num_aleatorio.php";
public string url_completa, url_completa1, url_completa2, url_completa3, url_completa4, url_completa5, url_completa6, url_completa7, url_completa8, url_completa9, url_completa10, url_completa11;
public bool ok_1 = false;
public bool ok_2 = false;
public bool ok_3 = false; 
public bool ok_4 = false; 
public bool ok_5 = false; 
public bool ok_6 = false;
public bool ok_7 = false; 
public bool ok_8 = false;
public bool ok_9 = false; 
public bool liberado = false;
public bool limpar_mensagem = true;
public bool acertou = false, errou = false, fim_fase = false, é_igual;
public int num_ajuda = 0, num;
public string resposta_escolhida = "", num_gerado, text_enunciado;

void Start(){
        button_ajuda.onClick.AddListener(Ajuda);
        button_responder.onClick.AddListener(Responder);
        button_parar.onClick.AddListener(Parar);
        url_completa1 = url_selectJogoQuiz+"?id="+UserData.id_jogo_quiz_atual+"&opcao=2";
        WWW www1 = new WWW (url_completa1);
        StartCoroutine(Verificar_Enunciado(www1));  
        url_completa2 = url_selectJogoQuiz+"?id="+UserData.id_jogo_quiz_atual+"&opcao=3";
        WWW www2 = new WWW (url_completa2);
        StartCoroutine(Verificar_LetraA(www2));
        url_completa3 = url_selectJogoQuiz+"?id="+UserData.id_jogo_quiz_atual+"&opcao=4";
        WWW www3 = new WWW (url_completa3);
        StartCoroutine(Verificar_LetraB(www3)); 
        url_completa4 = url_selectJogoQuiz+"?id="+UserData.id_jogo_quiz_atual+"&opcao=5";
        WWW www4 = new WWW (url_completa4);
        StartCoroutine(Verificar_LetraC(www4)); 
        url_completa5 = url_selectJogoQuiz+"?id="+UserData.id_jogo_quiz_atual+"&opcao=6";
        WWW www5 = new WWW (url_completa5);
        StartCoroutine(Verificar_LetraD(www5)); 
        url_completa6 = url_selectJogoQuiz+"?id="+UserData.id_jogo_quiz_atual+"&opcao=7"; 
        WWW www6 = new WWW (url_completa6);
        StartCoroutine(Verificar_LetraE(www6)); 
        url_completa7 = url_selectJogoQuiz+"?id="+UserData.id_jogo_quiz_atual+"&opcao=8";
        WWW www7 = new WWW (url_completa7);
        StartCoroutine(Verificar_Banca(www7)); 
        url_completa8 = url_selectJogoQuiz+"?id="+UserData.id_jogo_quiz_atual+"&opcao=9";
        WWW www8 = new WWW (url_completa8);
        StartCoroutine(Verificar_Ano(www8)); 
        url_completa9 = url_selectJogoQuiz+"?id="+UserData.id_jogo_quiz_atual+"&opcao=10";
        WWW www9 = new WWW (url_completa9);
        StartCoroutine(Verificar_Gabarito(www9)); 
        Conferir();
}

void Conferir(){
        if (ok_1 == false){
            url_completa1 = url_selectJogoQuiz+"?id="+UserData.id_jogo_quiz_atual+"&opcao=2";
            WWW www1 = new WWW (url_completa1);
            StartCoroutine(Verificar_Enunciado(www1)); 
        }
        if (ok_2 == false){
            url_completa2 = url_selectJogoQuiz+"?id="+UserData.id_jogo_quiz_atual+"&opcao=3";
            WWW www2 = new WWW (url_completa2);
            StartCoroutine(Verificar_LetraA(www2));
        }
        if (ok_3 == false){
            url_completa3 = url_selectJogoQuiz+"?id="+UserData.id_jogo_quiz_atual+"&opcao=4";
            WWW www3 = new WWW (url_completa3);
            StartCoroutine(Verificar_LetraB(www3)); 
        }
        if (ok_4 == false){
            url_completa4 = url_selectJogoQuiz+"?id="+UserData.id_jogo_quiz_atual+"&opcao=5";
            WWW www4 = new WWW (url_completa4);
            StartCoroutine(Verificar_LetraC(www4)); 
        }
        if (ok_5 == false){
            url_completa5 = url_selectJogoQuiz+"?id="+UserData.id_jogo_quiz_atual+"&opcao=6";
            WWW www5 = new WWW (url_completa5);
            StartCoroutine(Verificar_LetraD(www5));
        }
        if (ok_6 == false){
            url_completa6 = url_selectJogoQuiz+"?id="+UserData.id_jogo_quiz_atual+"&opcao=7"; 
            WWW www6 = new WWW (url_completa6);
            StartCoroutine(Verificar_LetraE(www6));
        }
        if (ok_7 == false){
            url_completa7 = url_selectJogoQuiz+"?id="+UserData.id_jogo_quiz_atual+"&opcao=8";
            WWW www7 = new WWW (url_completa7);
            StartCoroutine(Verificar_Banca(www7)); 
        }
        if (ok_8 == false){
            url_completa8 = url_selectJogoQuiz+"?id="+UserData.id_jogo_quiz_atual+"&opcao=9";
            WWW www8 = new WWW (url_completa8);
            StartCoroutine(Verificar_Ano(www8));
        }
        if (ok_9 == false){
            url_completa9 = url_selectJogoQuiz+"?id="+UserData.id_jogo_quiz_atual+"&opcao=10";
            WWW www9 = new WWW (url_completa9);
            StartCoroutine(Verificar_Gabarito(www9)); 
        }
}

void FixedUpdate(){
    if  (alternativa_a.GetComponent<Toggle>().isOn == true){
         alternativa_b.GetComponent<Toggle>().isOn = false;
         alternativa_c.GetComponent<Toggle>().isOn = false;
         alternativa_d.GetComponent<Toggle>().isOn = false;
         alternativa_e.GetComponent<Toggle>().isOn = false;
         resposta_escolhida = "A";
    }
    if  (alternativa_b.GetComponent<Toggle>().isOn == true){
         alternativa_a.GetComponent<Toggle>().isOn = false;
         alternativa_c.GetComponent<Toggle>().isOn = false;
         alternativa_d.GetComponent<Toggle>().isOn = false;
         alternativa_e.GetComponent<Toggle>().isOn = false;
         resposta_escolhida = "B";
    }
    if  (alternativa_c.GetComponent<Toggle>().isOn == true){
         alternativa_b.GetComponent<Toggle>().isOn = false;
         alternativa_a.GetComponent<Toggle>().isOn = false;
         alternativa_d.GetComponent<Toggle>().isOn = false;
         alternativa_e.GetComponent<Toggle>().isOn = false;
         resposta_escolhida = "C";
    }
    if  (alternativa_d.GetComponent<Toggle>().isOn == true){
         alternativa_b.GetComponent<Toggle>().isOn = false;
         alternativa_c.GetComponent<Toggle>().isOn = false;
         alternativa_a.GetComponent<Toggle>().isOn = false;
         alternativa_e.GetComponent<Toggle>().isOn = false;
         resposta_escolhida = "D";
    }
    if  (alternativa_e.GetComponent<Toggle>().isOn == true){
         alternativa_b.GetComponent<Toggle>().isOn = false;
         alternativa_c.GetComponent<Toggle>().isOn = false;
         alternativa_d.GetComponent<Toggle>().isOn = false;
         alternativa_a.GetComponent<Toggle>().isOn = false;
         resposta_escolhida = "E";
    }
    if  (alternativa_a.GetComponent<Toggle>().isOn == false && resposta_escolhida == "A"){
         resposta_escolhida = "";
    }
    if  (alternativa_b.GetComponent<Toggle>().isOn == false && resposta_escolhida == "B"){
         resposta_escolhida = "";
    }
    if  (alternativa_c.GetComponent<Toggle>().isOn == false && resposta_escolhida == "C"){
         resposta_escolhida = "";
    }
    if  (alternativa_d.GetComponent<Toggle>().isOn == false && resposta_escolhida == "D"){
         resposta_escolhida = "";
    }
    if  (alternativa_e.GetComponent<Toggle>().isOn == false && resposta_escolhida == "E"){
         resposta_escolhida = "";
    }
    if (text_enunciado =="" || letra_a.text  =="" || letra_b.text  =="" || letra_c.text =="" || letra_d.text =="" || letra_e.text =="" || banca == "" || ano =="" || gabarito ==""){
       if (liberado == false){mensagem.text = "Conectando ao Servidor...Aguarde um momento!"; }
    }
    else{
        liberado = true;
        enunciado.text = banca+" ("+ano+") - "+ text_enunciado;
        if (acertou == false && errou == false && limpar_mensagem == true){
                mensagem.text = "";
        }
        /*if (errou == true){
            Debug.Log("Passou Aqui");
            mensagem.text = "Você Errou! A alternativa correta era: "+gabarito+". Aperte ESPAÇO ou clique em SAIR para encerrar a partida";
        }
        else{
            if (acertou == true){
                mensagem.text = "Parabens! Aperte ESPAÇO para jogar o proximo desafio";
            }
            else{
                mensagem.text = "";
            }
        }*/
    }
    if (Input.GetKeyDown(KeyCode.Space)){
        if (acertou == true){
           if (UserData.quiz_alternativo == true){
               if (UserData.cont_jogo_quiz == 2 && UserData.quiz2 == true){
                    UserData.id_jogo_quiz_atual = 2;
                    UserData.cont_jogo_quiz = 2;
                    SceneManager.LoadScene("JogoQuiz");
               }
               else{
                    UserData.id_jogo_quiz_atual = 3;
               }
               if (UserData.cont_jogo_quiz == 3 && UserData.quiz3 == true){
                    UserData.id_jogo_quiz_atual = 3;
                    UserData.cont_jogo_quiz = 3;
                    SceneManager.LoadScene("JogoQuiz");
               }
               else{
                    UserData.id_jogo_quiz_atual = 4;
               }
               if (UserData.cont_jogo_quiz == 4 && UserData.quiz4 == true){
                    UserData.id_jogo_quiz_atual = 4;
                    UserData.cont_jogo_quiz = 4;
                    SceneManager.LoadScene("JogoQuiz");
               }
               else{
                    UserData.id_jogo_quiz_atual = 5;
               }
               if (UserData.cont_jogo_quiz == 5 && UserData.quiz5 == true){
                    UserData.id_jogo_quiz_atual = 5;
                    UserData.cont_jogo_quiz = 5;
                    SceneManager.LoadScene("JogoQuiz");
               }
               else{
                    UserData.id_jogo_quiz_atual = 6;
               }
               if (UserData.cont_jogo_quiz == 6 && UserData.quiz6 == true){
                    UserData.id_jogo_quiz_atual = 6;
                    UserData.cont_jogo_quiz = 6;
                    SceneManager.LoadScene("JogoQuiz");
               }
               else{
                    UserData.id_jogo_quiz_atual = 7;
               }
               if (UserData.cont_jogo_quiz == 7 && UserData.quiz7 == true){
                    UserData.id_jogo_quiz_atual = 7;
                    UserData.cont_jogo_quiz = 7;
                    SceneManager.LoadScene("JogoQuiz");
               }
               else{
                    UserData.id_jogo_quiz_atual = 8;
               }
               if (UserData.cont_jogo_quiz == 8 && UserData.quiz8 == true){
                    UserData.id_jogo_quiz_atual = 8;
                    UserData.cont_jogo_quiz = 8;
                    SceneManager.LoadScene("JogoQuiz");
               }
               else{
                    UserData.id_jogo_quiz_atual = 9;
               }
               if (UserData.cont_jogo_quiz == 9 && UserData.quiz9 == true){
                    UserData.id_jogo_quiz_atual = 9;
                    UserData.cont_jogo_quiz = 9;
                    SceneManager.LoadScene("JogoQuiz");
               }
               else{
                    UserData.id_jogo_quiz_atual = 10;
               }
               if (UserData.cont_jogo_quiz == 10 && UserData.quiz10 == true){
                    UserData.id_jogo_quiz_atual = 10;
                    UserData.cont_jogo_quiz = 10;
                    SceneManager.LoadScene("JogoQuiz");
               }
               else{
                    UserData.quiz1 = false;
                    UserData.quiz2 = false;
                    UserData.quiz3 = false;
                    UserData.quiz4 = false;
                    UserData.quiz5 = false;
                    UserData.quiz6 = false;
                    UserData.quiz7 = false;
                    UserData.quiz8 = false;
                    UserData.quiz9 = false;
                    UserData.quiz10 = false;
                    SceneManager.LoadScene("TelaVitoria");                    
               }
           }
           else{
                if (UserData.cont_jogo_quiz<=9){
                    PrepararDesafio();
                }
                else{
                    UserData.quiz1 = false;
                    UserData.quiz2 = false;
                    UserData.quiz3 = false;
                    UserData.quiz4 = false;
                    UserData.quiz5 = false;
                    UserData.quiz6 = false;
                    UserData.quiz7 = false;
                    UserData.quiz8 = false;
                    UserData.quiz9 = false;
                    UserData.quiz10 = false;
                    SceneManager.LoadScene("TelaVitoria");
                }
           }
        }
        if (errou == true){
           SceneManager.LoadScene("TelaJogo");
            UserData.quiz1 = false;
            UserData.quiz2 = false;
            UserData.quiz3 = false;
            UserData.quiz4 = false;
            UserData.quiz5 = false;
            UserData.quiz6 = false;
            UserData.quiz7 = false;
            UserData.quiz8 = false;
            UserData.quiz9 = false;
            UserData.quiz10 = false;
        }
    }
}

void PrepararDesafio(){ 
    WWW www_gerarnumero = new WWW (url_aleatorio);
    StartCoroutine(Num_aleatorio(www_gerarnumero));
}

IEnumerator Num_aleatorio(WWW www_gerarnumero){
        yield return www_gerarnumero;
        num_gerado = www_gerarnumero.text.ToString();
        num_gerado = num_gerado.TrimEnd();
        num = int.Parse(num_gerado);
        é_igual = false; 
        if (UserData.JogoQuizAtual[1] == num){
            é_igual = true;
        }
        if (UserData.JogoQuizAtual[2] == num && é_igual == false && UserData.cont_jogo_quiz>=2){
            é_igual = true;
        }
        if (UserData.JogoQuizAtual[3] == num && é_igual == false && UserData.cont_jogo_quiz>=3){
            é_igual = true;
        }
        if (UserData.JogoQuizAtual[4] == num && é_igual == false && UserData.cont_jogo_quiz>=4){
            é_igual = true;
        }
        if (UserData.JogoQuizAtual[5] == num && é_igual == false && UserData.cont_jogo_quiz>=5){
            é_igual = true;
        }
        if (UserData.JogoQuizAtual[6] == num && é_igual == false && UserData.cont_jogo_quiz>=6){
            é_igual = true;
        }
        if (UserData.JogoQuizAtual[7] == num && é_igual == false && UserData.cont_jogo_quiz>=7){
            é_igual = true;
        }
        if (UserData.JogoQuizAtual[8] == num && é_igual == false && UserData.cont_jogo_quiz>=8){
            é_igual = true;
        }
        if (UserData.JogoQuizAtual[9] == num && é_igual == false && UserData.cont_jogo_quiz>=9){
            é_igual = true;
        }
        if (UserData.JogoQuizAtual[10] == num && é_igual == false && UserData.cont_jogo_quiz>=10){
            é_igual = true;
        }
        if (é_igual == true){
            PrepararDesafio();
        }
        else{
            UserData.id_jogo_quiz_atual = num;
            //UserData.cont_jogo_quiz =  UserData.cont_jogo_quiz+1;
            SceneManager.LoadScene("JogoQuiz");
        }
}

IEnumerator Verificar_Enunciado(WWW www1){
        yield return www1;
        text_enunciado = www1.text.ToString();
        text_enunciado = text_enunciado.TrimEnd();
        ok_1 = true;
}

IEnumerator Verificar_LetraA(WWW www2){
        yield return www2;
        letra_a.text = www2.text.ToString();
        letra_a.text = letra_a.text.TrimEnd();
        ok_2 = true;
}

IEnumerator Verificar_LetraB(WWW www3){
        yield return www3;
        letra_b.text = www3.text.ToString();
        letra_b.text = letra_b.text.TrimEnd();
        ok_3 = true;
}

IEnumerator Verificar_LetraC(WWW www4){
        yield return www4;
        letra_c.text = www4.text.ToString();
        letra_c.text = letra_c.text.TrimEnd();
        ok_4 = true;
}

IEnumerator Verificar_LetraD(WWW www5){
        yield return www5;
        letra_d.text = www5.text.ToString();
        letra_d.text = letra_d.text.TrimEnd();
        ok_5 = true;
}

IEnumerator Verificar_LetraE(WWW www6){
        yield return www6;
        letra_e.text = www6.text.ToString();
        letra_e.text = letra_e.text.TrimEnd();
        ok_6 = true;
}

IEnumerator Verificar_Banca(WWW www7){
        yield return www7;
        banca = www7.text.ToString();
        banca = banca.TrimEnd();
        ok_7 = true;
}

IEnumerator Verificar_Ano(WWW www8){
        yield return www8;
        ano = www8.text.ToString();
        ano = ano.TrimEnd();
        ok_8 = true;
}

IEnumerator Verificar_Gabarito(WWW www9){
        yield return www9;
        gabarito = www9.text.ToString();
        gabarito = gabarito.TrimEnd();
        ok_9 = true;
}

void Ajuda(){
     if (gabarito != "A" && num_ajuda<2 && liberado == true){
        letra_a.text = "";
        num_ajuda++;
     }
     if (gabarito != "B" && num_ajuda<2 && liberado == true){
        letra_b.text = "";
        num_ajuda++;
     }
     if (gabarito != "C" && num_ajuda<2 && liberado == true){
        letra_c.text = "";
        num_ajuda++;
     }
     if (gabarito != "D" && num_ajuda<2 && liberado == true){
        letra_d.text = "";
        num_ajuda++;
     }
     if (gabarito != "E" && num_ajuda<2 && liberado == true){
        letra_e.text = "";
        num_ajuda++;
     }
     alternativa_a.GetComponent<Toggle>().isOn = false;
     alternativa_b.GetComponent<Toggle>().isOn = false;
     alternativa_c.GetComponent<Toggle>().isOn = false;
     alternativa_d.GetComponent<Toggle>().isOn = false;
     alternativa_e.GetComponent<Toggle>().isOn = false;
}

void Responder(){
    if (liberado == true){
        if (resposta_escolhida != ""){
            if (resposta_escolhida == gabarito && acertou == false){
             Debug.Log("Acertou");
             WWW www_salvar = new WWW (url_salvar+"?id_quiz="+UserData.id_jogo_quiz_atual+"&email="+UserData.email+"&resposta=1");
             StartCoroutine(SalvarJogo(www_salvar));
             UserData.cont_jogo_quiz = UserData.cont_jogo_quiz+1;
             UserData.JogoQuizAtual[UserData.cont_jogo_quiz] = UserData.id_jogo_quiz_atual;
             acertou = true;
             mensagem.text = "Parabéns, você acertou! Aperte ESPAÇO para jogar o próximo desafio";
            }
            if (resposta_escolhida != gabarito && errou == false){
             Debug.Log("Errou");
             WWW www_salvar = new WWW (url_salvar+"?id_quiz="+UserData.id_jogo_quiz_atual+"&email="+UserData.email+"&resposta=0");
             StartCoroutine(SalvarJogo(www_salvar));
             mensagem.text = "Você Errou! A alternativa correta era: "+gabarito+". Aperte ESPAÇO ou clique em SAIR para encerrar a partida";
             errou = true;
            }
        }
        else{
             limpar_mensagem = false;
             mensagem.text = "Você não selecionou nenhuma alternativa!";
        }
    }
}

IEnumerator SalvarJogo(WWW www_salvar){
        yield return www_salvar;   
}

void Parar(){
     UserData.quiz1 = false;
     UserData.quiz2 = false;
     UserData.quiz3 = false;
     UserData.quiz4 = false;
     UserData.quiz5 = false;
     UserData.quiz6 = false;
     UserData.quiz7 = false;
     UserData.quiz8 = false;
     UserData.quiz9 = false;
     UserData.quiz10 = false;
     SceneManager.LoadScene("TelaJogo");
}

}
