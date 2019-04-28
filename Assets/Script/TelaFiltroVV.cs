using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TelaFiltroVV : MonoBehaviour {

public Button button_jogar;
public Button button_parar;
public GameObject aleatorio;
public GameObject erros;
public GameObject acertos;
public GameObject respondidas;
public GameObject ineditas;
public Text text_aleatorio, text_ineditas, text_respondidas, text_erros, text_acertos, mensagem;
public string url_selectJogoQuiz = "https://qualif.000webhostapp.com/html/selectJogoQuiz.php";
public string url_salvar = "https://qualif.000webhostapp.com/html/salvarJogadorQuiz.php";
public string url_aleatorio = "https://qualif.000webhostapp.com/html/num_aleatorio.php";
public string url_selectJogoForca = "https://qualif.000webhostapp.com/html/selectJogoForca.php";
public string url_verificartotal = "https://qualif.000webhostapp.com/html/pontuacao.php";
public string url_verificarNaoRespondidasOuRespondidasQuiz = "https://qualif.000webhostapp.com/html/respondeu_ou_nao_quiz.php";
public string url_verificarNaoRespondidasOuRespondidasForca = "https://qualif.000webhostapp.com/html/respondeu_ou_nao_forca.php";
public string url_verificarAcertouOuNaoQuiz = "https://qualif.000webhostapp.com/html/acertou_ou_nao_quiz.php";
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
public bool limpar_mensagem = true;
public bool acertou = false, errou = false, fim_fase = false, é_igual;
public int num_ajuda = 0, num;
public string resposta_escolhida = "", num_gerado, num_letras;
public int controle;

void Start(){
        button_jogar.onClick.AddListener(Jogar);
        text_aleatorio.text = "Aleatório";
        text_ineditas.text = "Somente desafios que não respondi";
        text_respondidas.text = "Somente desafios que respondi";
        text_erros.text = "Somente desafios que errei";
        text_acertos.text = "Somente desafios que acertei";
        button_parar.onClick.AddListener(Parar);
        /*url_completa1 = url_selectJogoQuiz+"?id="+UserData.id_jogo_quiz_atual+"&opcao=2";
        WWW www1 = new WWW (url_completa1);
        StartCoroutine(Verificar_Enunciado(www1)); */ 
        //Conferir();
}

void FixedUpdate(){
    if  (aleatorio.GetComponent<Toggle>().isOn == true){
         ineditas.GetComponent<Toggle>().isOn = false;
         respondidas.GetComponent<Toggle>().isOn = false;
         erros.GetComponent<Toggle>().isOn = false;
         acertos.GetComponent<Toggle>().isOn = false;
         resposta_escolhida = "A";
    }
    if  (ineditas.GetComponent<Toggle>().isOn == true){
         aleatorio.GetComponent<Toggle>().isOn = false;
         respondidas.GetComponent<Toggle>().isOn = false;
         erros.GetComponent<Toggle>().isOn = false;
         acertos.GetComponent<Toggle>().isOn = false;
         resposta_escolhida = "B";
    }
    if  (respondidas.GetComponent<Toggle>().isOn == true){
         ineditas.GetComponent<Toggle>().isOn = false;
         aleatorio.GetComponent<Toggle>().isOn = false;
         erros.GetComponent<Toggle>().isOn = false;
         acertos.GetComponent<Toggle>().isOn = false;
         resposta_escolhida = "C";
    }
    if  (erros.GetComponent<Toggle>().isOn == true){
         ineditas.GetComponent<Toggle>().isOn = false;
         respondidas.GetComponent<Toggle>().isOn = false;
         aleatorio.GetComponent<Toggle>().isOn = false;
         acertos.GetComponent<Toggle>().isOn = false;
         resposta_escolhida = "D";
    }
    if  (acertos.GetComponent<Toggle>().isOn == true){
         ineditas.GetComponent<Toggle>().isOn = false;
         respondidas.GetComponent<Toggle>().isOn = false;
         erros.GetComponent<Toggle>().isOn = false;
         aleatorio.GetComponent<Toggle>().isOn = false;
         resposta_escolhida = "E";
    }
    if  (aleatorio.GetComponent<Toggle>().isOn == false && resposta_escolhida == "A"){
         resposta_escolhida = "";
    }
    if  (ineditas.GetComponent<Toggle>().isOn == false && resposta_escolhida == "B"){
         resposta_escolhida = "";
    }
    if  (respondidas.GetComponent<Toggle>().isOn == false && resposta_escolhida == "C"){
         resposta_escolhida = "";
    }
    if  (erros.GetComponent<Toggle>().isOn == false && resposta_escolhida == "D"){
         resposta_escolhida = "";
    }
    if  (acertos.GetComponent<Toggle>().isOn == false && resposta_escolhida == "E"){
         resposta_escolhida = "";
    }
    if (ok_1 == true && ok_2 == true && ok_3 == true && ok_4 == true && ok_5 == true && ok_6 == true && ok_7 == true && ok_8 == true && ok_9 == true && ok_10 == true){
        if (resposta_escolhida == "B"){
            if (UserData.escolha == "1"){
                Debug.Log("PassouAquiTambém");
                if (UserData.quiz1 == true){
                      UserData.id_jogo_quiz_atual = 1;
                      UserData.cont_jogo_quiz = 1;
                      SceneManager.LoadScene("JogoQuiz");
                }
                if (UserData.quiz2 == true){
                      UserData.id_jogo_quiz_atual = 2;
                      UserData.cont_jogo_quiz = 2;
                      SceneManager.LoadScene("JogoQuiz");
                }
                if (UserData.quiz3 == true){
                      UserData.id_jogo_quiz_atual = 3;
                      UserData.cont_jogo_quiz = 3;
                      SceneManager.LoadScene("JogoQuiz");
                }
                if (UserData.quiz4 == true){
                      UserData.id_jogo_quiz_atual = 4;
                      UserData.cont_jogo_quiz = 4;
                      SceneManager.LoadScene("JogoQuiz");
                }
                if (UserData.quiz5 == true){
                      UserData.id_jogo_quiz_atual = 5;
                      UserData.cont_jogo_quiz = 5;
                      SceneManager.LoadScene("JogoQuiz");
                }
                if (UserData.quiz6 == true){
                      UserData.id_jogo_quiz_atual = 6;
                      UserData.cont_jogo_quiz = 6;
                      SceneManager.LoadScene("JogoQuiz");
                }
                if (UserData.quiz7 == true){
                      UserData.id_jogo_quiz_atual = 7;
                      UserData.cont_jogo_quiz = 7;
                      SceneManager.LoadScene("JogoQuiz");
                }
                if (UserData.quiz8 == true){
                      UserData.id_jogo_quiz_atual = 8;
                      UserData.cont_jogo_quiz = 8;
                      SceneManager.LoadScene("JogoQuiz");
                }
                if (UserData.quiz9 == true){
                      UserData.id_jogo_quiz_atual = 9;
                      UserData.cont_jogo_quiz = 9;
                      SceneManager.LoadScene("JogoQuiz");
                }
                if (UserData.quiz10 == true){
                      UserData.id_jogo_quiz_atual = 10;
                      UserData.cont_jogo_quiz = 10;
                      SceneManager.LoadScene("JogoQuiz");
                }
            }
        }
        if (resposta_escolhida == "C"){
            if (UserData.escolha == "1"){
                Debug.Log("PassouAquiTambém");
                if (UserData.quiz1 == false){
                      UserData.id_jogo_quiz_atual = 1;
                      UserData.cont_jogo_quiz = 1;
                      SceneManager.LoadScene("JogoQuiz");
                }
                if (UserData.quiz2 == false){
                      UserData.id_jogo_quiz_atual = 2;
                      UserData.cont_jogo_quiz = 2;
                      SceneManager.LoadScene("JogoQuiz");
                }
                if (UserData.quiz3 == false){
                      UserData.id_jogo_quiz_atual = 3;
                      UserData.cont_jogo_quiz = 3;
                      SceneManager.LoadScene("JogoQuiz");
                }
                if (UserData.quiz4 == false){
                      UserData.id_jogo_quiz_atual = 4;
                      UserData.cont_jogo_quiz = 4;
                      SceneManager.LoadScene("JogoQuiz");
                }
                if (UserData.quiz5 == false){
                      UserData.id_jogo_quiz_atual = 5;
                      UserData.cont_jogo_quiz = 5;
                      SceneManager.LoadScene("JogoQuiz");
                }
                if (UserData.quiz6 == false){
                      UserData.id_jogo_quiz_atual = 6;
                      UserData.cont_jogo_quiz = 6;
                      SceneManager.LoadScene("JogoQuiz");
                }
                if (UserData.quiz7 == false){
                      UserData.id_jogo_quiz_atual = 7;
                      UserData.cont_jogo_quiz = 7;
                      SceneManager.LoadScene("JogoQuiz");
                }
                if (UserData.quiz8 == false){
                      UserData.id_jogo_quiz_atual = 8;
                      UserData.cont_jogo_quiz = 8;
                      SceneManager.LoadScene("JogoQuiz");
                }
                if (UserData.quiz9 == false){
                      UserData.id_jogo_quiz_atual = 9;
                      UserData.cont_jogo_quiz = 9;
                      SceneManager.LoadScene("JogoQuiz");
                }
                if (UserData.quiz10 == false){
                      UserData.id_jogo_quiz_atual = 10;
                      UserData.cont_jogo_quiz = 10;
                      SceneManager.LoadScene("JogoQuiz");
                }
            }
        }
        if (resposta_escolhida == "D"){
            if (UserData.escolha == "1"){
                Debug.Log("PassouAquiTambém");
                if (UserData.quiz1 == false){
                      UserData.id_jogo_quiz_atual = 1;
                      UserData.cont_jogo_quiz = 1;
                      SceneManager.LoadScene("JogoQuiz");
                }
                if (UserData.quiz2 == false){
                      UserData.id_jogo_quiz_atual = 2;
                      UserData.cont_jogo_quiz = 2;
                      SceneManager.LoadScene("JogoQuiz");
                }
                if (UserData.quiz3 == false){
                      UserData.id_jogo_quiz_atual = 3;
                      UserData.cont_jogo_quiz = 3;
                      SceneManager.LoadScene("JogoQuiz");
                }
                if (UserData.quiz4 == false){
                      UserData.id_jogo_quiz_atual = 4;
                      UserData.cont_jogo_quiz = 4;
                      SceneManager.LoadScene("JogoQuiz");
                }
                if (UserData.quiz5 == false){
                      UserData.id_jogo_quiz_atual = 5;
                      UserData.cont_jogo_quiz = 5;
                      SceneManager.LoadScene("JogoQuiz");
                }
                if (UserData.quiz6 == false){
                      UserData.id_jogo_quiz_atual = 6;
                      UserData.cont_jogo_quiz = 6;
                      SceneManager.LoadScene("JogoQuiz");
                }
                if (UserData.quiz7 == false){
                      UserData.id_jogo_quiz_atual = 7;
                      UserData.cont_jogo_quiz = 7;
                      SceneManager.LoadScene("JogoQuiz");
                }
                if (UserData.quiz8 == false){
                      UserData.id_jogo_quiz_atual = 8;
                      UserData.cont_jogo_quiz = 8;
                      SceneManager.LoadScene("JogoQuiz");
                }
                if (UserData.quiz9 == false){
                      UserData.id_jogo_quiz_atual = 9;
                      UserData.cont_jogo_quiz = 9;
                      SceneManager.LoadScene("JogoQuiz");
                }
                if (UserData.quiz10 == false){
                      UserData.id_jogo_quiz_atual = 10;
                      UserData.cont_jogo_quiz = 10;
                      SceneManager.LoadScene("JogoQuiz");
                }
            }
        }
    }
}


void Jogar(){
     if (resposta_escolhida == "A"){
        WWW www = new WWW (url_aleatorio);
        StartCoroutine(Num_aleatorio(www));
     }
     if (resposta_escolhida == "B"){
        if (UserData.escolha == "1"){
            string url_completa1 = url_verificartotal+"?email="+UserData.email+"&opcao=1";
            WWW www1 = new WWW (url_completa1);
            StartCoroutine(Verificar_PartidasQuiz(www1));
        }
        if (UserData.escolha == "2"){
            string url_completa2 = url_verificartotal+"?email="+UserData.email+"&opcao=4";
            WWW www2 = new WWW (url_completa2);
            StartCoroutine(Verificar_PartidasForca(www2));
        }
     }
     if (resposta_escolhida == "C"){
        if (UserData.escolha == "1"){
            string url_completa1 = url_verificartotal+"?email="+UserData.email+"&opcao=1";
            WWW www1 = new WWW (url_completa1);
            StartCoroutine(Verificar_PartidasJogadasQuiz(www1));
        }
        /*if (UserData.escolha == "2"){
            string url_completa2 = url_verificartotal+"?email="+UserData.email+"&opcao=4";
            WWW www2 = new WWW (url_completa2);
            StartCoroutine(Verificar_PartidasJogadasForca(www2));
        }*/
     }
     if (resposta_escolhida == "D"){
        if (UserData.escolha == "1"){
            string url_completa1 = url_verificartotal+"?email="+UserData.email+"&opcao=1";
            WWW www1 = new WWW (url_completa1);
            StartCoroutine(Verificar_AcertosErrosQuiz(www1));
        }
        /*if (UserData.escolha == "2"){
            string url_completa2 = url_verificartotal+"?email="+UserData.email+"&opcao=4";
            WWW www2 = new WWW (url_completa2);
            StartCoroutine(Verificar_PartidasJogadasForca(www2));
        }*/
     }
}

IEnumerator Verificar_PartidasQuiz(WWW www1){
     yield return www1;
     string ret = www1.text.ToString();
     ret = ret.TrimEnd();
     if(ret == "10"){
        mensagem.text = "Você já respondeu todos os desafios!";
        acertos.GetComponent<Toggle>().isOn = false;
        ineditas.GetComponent<Toggle>().isOn = false;
        respondidas.GetComponent<Toggle>().isOn = false;
        erros.GetComponent<Toggle>().isOn = false;
        aleatorio.GetComponent<Toggle>().isOn = false;    
     } 
     else{
        if(ret == "0"){
            WWW www = new WWW (url_aleatorio);
            StartCoroutine(Num_aleatorio(www));
        }
        else{
            mensagem.text = "Você já respondeu todos os desafios!";
            string url_completa11 = url_verificarNaoRespondidasOuRespondidasQuiz+"?email="+UserData.email+"&opcao=1";
            WWW www11 = new WWW (url_completa11);
            Debug.Log(url_completa11);
            StartCoroutine(Verificar_NaoRespondida1(www11));
            string url_completa12 = url_verificarNaoRespondidasOuRespondidasQuiz+"?email="+UserData.email+"&opcao=2";
            WWW www12 = new WWW (url_completa12);
            StartCoroutine(Verificar_NaoRespondida2(www12));
            string url_completa13 = url_verificarNaoRespondidasOuRespondidasQuiz+"?email="+UserData.email+"&opcao=3";
            WWW www13 = new WWW (url_completa13);
            StartCoroutine(Verificar_NaoRespondida3(www13));
            string url_completa14 = url_verificarNaoRespondidasOuRespondidasQuiz+"?email="+UserData.email+"&opcao=4";
            WWW www14 = new WWW (url_completa14);
            StartCoroutine(Verificar_NaoRespondida4(www14));
            string url_completa15 = url_verificarNaoRespondidasOuRespondidasQuiz+"?email="+UserData.email+"&opcao=5";
            WWW www15 = new WWW (url_completa15);
            StartCoroutine(Verificar_NaoRespondida5(www15));
            string url_completa16 = url_verificarNaoRespondidasOuRespondidasQuiz+"?email="+UserData.email+"&opcao=6";
            WWW www16 = new WWW (url_completa16);
            StartCoroutine(Verificar_NaoRespondida6(www16));
            string url_completa17 = url_verificarNaoRespondidasOuRespondidasQuiz+"?email="+UserData.email+"&opcao=7";
            WWW www17 = new WWW (url_completa17);
            StartCoroutine(Verificar_NaoRespondida7(www17));
            string url_completa18 = url_verificarNaoRespondidasOuRespondidasQuiz+"?email="+UserData.email+"&opcao=8";
            WWW www18 = new WWW (url_completa18);
            StartCoroutine(Verificar_NaoRespondida8(www18));
            string url_completa19 = url_verificarNaoRespondidasOuRespondidasQuiz+"?email="+UserData.email+"&opcao=9";
            WWW www19 = new WWW (url_completa19);
            StartCoroutine(Verificar_NaoRespondida9(www19));
            string url_completa20 = url_verificarNaoRespondidasOuRespondidasQuiz+"?email="+UserData.email+"&opcao=10";
            WWW www20 = new WWW (url_completa20);
            StartCoroutine(Verificar_NaoRespondida10(www20));
            Conferir();
        }  
     }
}

IEnumerator Verificar_PartidasJogadasQuiz(WWW www1){
     yield return www1;
     string ret = www1.text.ToString();
     ret = ret.TrimEnd();
     if(ret == "0"){
        mensagem.text = "Você ainda não jogou nenhum desafio!";
        acertos.GetComponent<Toggle>().isOn = false;
        ineditas.GetComponent<Toggle>().isOn = false;
        respondidas.GetComponent<Toggle>().isOn = false;
        erros.GetComponent<Toggle>().isOn = false;
        aleatorio.GetComponent<Toggle>().isOn = false;    
     } 
     else{
        if(ret == "10"){
            WWW www = new WWW (url_aleatorio);
            StartCoroutine(Num_aleatorio(www));
        }
        else{
            Debug.Log("Passou aqui");
            mensagem.text = "Carregando...";
            string url_completa11 = url_verificarNaoRespondidasOuRespondidasQuiz+"?email="+UserData.email+"&opcao=1";
            WWW www11 = new WWW (url_completa11);
            Debug.Log(url_completa11);
            StartCoroutine(Verificar_NaoRespondida1(www11));
            string url_completa12 = url_verificarNaoRespondidasOuRespondidasQuiz+"?email="+UserData.email+"&opcao=2";
            WWW www12 = new WWW (url_completa12);
            StartCoroutine(Verificar_NaoRespondida2(www12));
            string url_completa13 = url_verificarNaoRespondidasOuRespondidasQuiz+"?email="+UserData.email+"&opcao=3";
            WWW www13 = new WWW (url_completa13);
            StartCoroutine(Verificar_NaoRespondida3(www13));
            string url_completa14 = url_verificarNaoRespondidasOuRespondidasQuiz+"?email="+UserData.email+"&opcao=4";
            WWW www14 = new WWW (url_completa14);
            StartCoroutine(Verificar_NaoRespondida4(www14));
            string url_completa15 = url_verificarNaoRespondidasOuRespondidasQuiz+"?email="+UserData.email+"&opcao=5";
            WWW www15 = new WWW (url_completa15);
            StartCoroutine(Verificar_NaoRespondida5(www15));
            string url_completa16 = url_verificarNaoRespondidasOuRespondidasQuiz+"?email="+UserData.email+"&opcao=6";
            WWW www16 = new WWW (url_completa16);
            StartCoroutine(Verificar_NaoRespondida6(www16));
            string url_completa17 = url_verificarNaoRespondidasOuRespondidasQuiz+"?email="+UserData.email+"&opcao=7";
            WWW www17 = new WWW (url_completa17);
            StartCoroutine(Verificar_NaoRespondida7(www17));
            string url_completa18 = url_verificarNaoRespondidasOuRespondidasQuiz+"?email="+UserData.email+"&opcao=8";
            WWW www18 = new WWW (url_completa18);
            StartCoroutine(Verificar_NaoRespondida8(www18));
            string url_completa19 = url_verificarNaoRespondidasOuRespondidasQuiz+"?email="+UserData.email+"&opcao=9";
            WWW www19 = new WWW (url_completa19);
            StartCoroutine(Verificar_NaoRespondida9(www19));
            string url_completa20 = url_verificarNaoRespondidasOuRespondidasQuiz+"?email="+UserData.email+"&opcao=10";
            WWW www20 = new WWW (url_completa20);
            StartCoroutine(Verificar_NaoRespondida10(www20));
            Conferir();
        }  
     }
}

IEnumerator Verificar_AcertosErrosQuiz(WWW www1){
     yield return www1;
     string ret = www1.text.ToString();
     ret = ret.TrimEnd();
     if(ret == "0"){
        mensagem.text = "Você ainda não errou nenhum desafio!";
        acertos.GetComponent<Toggle>().isOn = false;
        ineditas.GetComponent<Toggle>().isOn = false;
        respondidas.GetComponent<Toggle>().isOn = false;
        erros.GetComponent<Toggle>().isOn = false;
        aleatorio.GetComponent<Toggle>().isOn = false;    
     } 
     else{
            Debug.Log("Passou aqui");
            string url_completa11 = url_verificarAcertouOuNaoQuiz+"?email="+UserData.email+"&opcao=1";
            WWW www11 = new WWW (url_completa11);
            Debug.Log(url_completa11);
            StartCoroutine(Verificar_NaoRespondida1(www11));
            string url_completa12 = url_verificarAcertouOuNaoQuiz+"?email="+UserData.email+"&opcao=2";
            WWW www12 = new WWW (url_completa12);
            StartCoroutine(Verificar_NaoRespondida2(www12));
            string url_completa13 = url_verificarAcertouOuNaoQuiz+"?email="+UserData.email+"&opcao=3";
            WWW www13 = new WWW (url_completa13);
            StartCoroutine(Verificar_NaoRespondida3(www13));
            string url_completa14 = url_verificarAcertouOuNaoQuiz+"?email="+UserData.email+"&opcao=4";
            WWW www14 = new WWW (url_completa14);
            StartCoroutine(Verificar_NaoRespondida4(www14));
            string url_completa15 = url_verificarAcertouOuNaoQuiz+"?email="+UserData.email+"&opcao=5";
            WWW www15 = new WWW (url_completa15);
            StartCoroutine(Verificar_NaoRespondida5(www15));
            string url_completa16 = url_verificarAcertouOuNaoQuiz+"?email="+UserData.email+"&opcao=6";
            WWW www16 = new WWW (url_completa16);
            StartCoroutine(Verificar_NaoRespondida6(www16));
            string url_completa17 = url_verificarAcertouOuNaoQuiz+"?email="+UserData.email+"&opcao=7";
            WWW www17 = new WWW (url_completa17);
            StartCoroutine(Verificar_NaoRespondida7(www17));
            string url_completa18 = url_verificarAcertouOuNaoQuiz+"?email="+UserData.email+"&opcao=8";
            WWW www18 = new WWW (url_completa18);
            StartCoroutine(Verificar_NaoRespondida8(www18));
            string url_completa19 = url_verificarAcertouOuNaoQuiz+"?email="+UserData.email+"&opcao=9";
            WWW www19 = new WWW (url_completa19);
            StartCoroutine(Verificar_NaoRespondida9(www19));
            string url_completa20 = url_verificarAcertouOuNaoQuiz+"?email="+UserData.email+"&opcao=10";
            WWW www20 = new WWW (url_completa20);
            StartCoroutine(Verificar_NaoRespondida10(www20));
            Conferir2(); 
     }
}


void Conferir(){
    if (ok_1 == false){
            string url_completa11 = url_verificarNaoRespondidasOuRespondidasQuiz+"?email="+UserData.email+"&opcao=1";
            WWW www11 = new WWW (url_completa11);
            StartCoroutine(Verificar_NaoRespondida1(www11));
    }
    if (ok_2 == false){
            string url_completa12 = url_verificarNaoRespondidasOuRespondidasQuiz+"?email="+UserData.email+"&opcao=2";
            WWW www12 = new WWW (url_completa12);
            StartCoroutine(Verificar_NaoRespondida2(www12));
    }
    if (ok_3 == false){
            string url_completa13 = url_verificarNaoRespondidasOuRespondidasQuiz+"?email="+UserData.email+"&opcao=3";
            WWW www13 = new WWW (url_completa13);
            StartCoroutine(Verificar_NaoRespondida3(www13));
    }
    if (ok_4 == false){
            string url_completa14 = url_verificarNaoRespondidasOuRespondidasQuiz+"?email="+UserData.email+"&opcao=4";
            WWW www14 = new WWW (url_completa14);
            StartCoroutine(Verificar_NaoRespondida4(www14));
    }
    if (ok_5 == false){
            string url_completa15 = url_verificarNaoRespondidasOuRespondidasQuiz+"?email="+UserData.email+"&opcao=5";
            WWW www15 = new WWW (url_completa15);
            StartCoroutine(Verificar_NaoRespondida5(www15));
    }
    if (ok_6 == false){
            string url_completa16 = url_verificarNaoRespondidasOuRespondidasQuiz+"?email="+UserData.email+"&opcao=6";
            WWW www16 = new WWW (url_completa16);
            StartCoroutine(Verificar_NaoRespondida6(www16));
    }
    if (ok_7 == false){
            string url_completa17 = url_verificarNaoRespondidasOuRespondidasQuiz+"?email="+UserData.email+"&opcao=7";
            WWW www17 = new WWW (url_completa17);
            StartCoroutine(Verificar_NaoRespondida7(www17));
    }
    if (ok_8 == false){
            string url_completa18 = url_verificarNaoRespondidasOuRespondidasQuiz+"?email="+UserData.email+"&opcao=8";
            WWW www18 = new WWW (url_completa18);
            StartCoroutine(Verificar_NaoRespondida8(www18));
    }
    if (ok_9 == false){
            string url_completa19 = url_verificarNaoRespondidasOuRespondidasQuiz+"?email="+UserData.email+"&opcao=9";
            WWW www19 = new WWW (url_completa19);
            StartCoroutine(Verificar_NaoRespondida9(www19));
    }
    if (ok_10 == false){
            string url_completa20 = url_verificarNaoRespondidasOuRespondidasQuiz+"?email="+UserData.email+"&opcao=10";
            WWW www20 = new WWW (url_completa20);
            StartCoroutine(Verificar_NaoRespondida10(www20));
    }
}

void Conferir2(){
    if (ok_2 == false){
            string url_completa11 = url_verificarAcertouOuNaoQuiz+"?email="+UserData.email+"&opcao=1";
            WWW www11 = new WWW (url_completa11);
            StartCoroutine(Verificar_NaoRespondida1(www11));
    }
    if (ok_2 == false){
            string url_completa12 = url_verificarAcertouOuNaoQuiz+"?email="+UserData.email+"&opcao=2";
            WWW www12 = new WWW (url_completa12);
            StartCoroutine(Verificar_NaoRespondida2(www12));
    }
    if (ok_3 == false){
            string url_completa13 = url_verificarAcertouOuNaoQuiz+"?email="+UserData.email+"&opcao=3";
            WWW www13 = new WWW (url_completa13);
            StartCoroutine(Verificar_NaoRespondida3(www13));
    }
    if (ok_4 == false){
            string url_completa14 = url_verificarAcertouOuNaoQuiz+"?email="+UserData.email+"&opcao=4";
            WWW www14 = new WWW (url_completa14);
            StartCoroutine(Verificar_NaoRespondida4(www14));
    }
    if (ok_5 == false){
            string url_completa15 = url_verificarAcertouOuNaoQuiz+"?email="+UserData.email+"&opcao=5";
            WWW www15 = new WWW (url_completa15);
            StartCoroutine(Verificar_NaoRespondida5(www15));
    }
    if (ok_6 == false){
            string url_completa16 = url_verificarAcertouOuNaoQuiz+"?email="+UserData.email+"&opcao=6";
            WWW www16 = new WWW (url_completa16);
            StartCoroutine(Verificar_NaoRespondida6(www16));
    }
    if (ok_7 == false){
            string url_completa17 = url_verificarAcertouOuNaoQuiz+"?email="+UserData.email+"&opcao=7";
            WWW www17 = new WWW (url_completa17);
            StartCoroutine(Verificar_NaoRespondida7(www17));
    }
    if (ok_8 == false){
            string url_completa18 = url_verificarAcertouOuNaoQuiz+"?email="+UserData.email+"&opcao=8";
            WWW www18 = new WWW (url_completa18);
            StartCoroutine(Verificar_NaoRespondida8(www18));
    }
    if (ok_9 == false){
            string url_completa19 = url_verificarAcertouOuNaoQuiz+"?email="+UserData.email+"&opcao=9";
            WWW www19 = new WWW (url_completa19);
            StartCoroutine(Verificar_NaoRespondida9(www19));
    }
    if (ok_10 == false){
            string url_completa20 = url_verificarAcertouOuNaoQuiz+"?email="+UserData.email+"&opcao=10";
            WWW www20 = new WWW (url_completa20);
            StartCoroutine(Verificar_NaoRespondida10(www20));
    }
}

IEnumerator Verificar_PartidasForca(WWW www2){
     yield return www2;
     string ret = www2.text.ToString();
     ret = ret.TrimEnd();
     if(ret == "10"){
        mensagem.text = "Você já respondeu todos os desafios!";
     } 
     else{
        if(ret == "0"){
            WWW www = new WWW (url_aleatorio);
            StartCoroutine(Num_aleatorio(www));
        }
        else{
            string url_completa11 = url_verificarNaoRespondidasOuRespondidasForca+"?email="+UserData.email+"&opcao=1";
            WWW www11 = new WWW (url_completa11);
            StartCoroutine(Verificar_NaoRespondida1(www11));
            string url_completa12 = url_verificarNaoRespondidasOuRespondidasForca+"?email="+UserData.email+"&opcao=2";
            WWW www12 = new WWW (url_completa12);
            StartCoroutine(Verificar_NaoRespondida2(www12));
            string url_completa13 = url_verificarNaoRespondidasOuRespondidasForca+"?email="+UserData.email+"&opcao=3";
            WWW www13 = new WWW (url_completa13);
            StartCoroutine(Verificar_NaoRespondida3(www13));
            string url_completa14 = url_verificarNaoRespondidasOuRespondidasForca+"?email="+UserData.email+"&opcao=4";
            WWW www14 = new WWW (url_completa14);
            StartCoroutine(Verificar_NaoRespondida4(www14));
            string url_completa15 = url_verificarNaoRespondidasOuRespondidasForca+"?email="+UserData.email+"&opcao=5";
            WWW www15 = new WWW (url_completa15);
            StartCoroutine(Verificar_NaoRespondida5(www15));
            string url_completa16 = url_verificarNaoRespondidasOuRespondidasForca+"?email="+UserData.email+"&opcao=6";
            WWW www16 = new WWW (url_completa16);
            StartCoroutine(Verificar_NaoRespondida6(www16));
            string url_completa17 = url_verificarNaoRespondidasOuRespondidasForca+"?email="+UserData.email+"&opcao=7";
            WWW www17 = new WWW (url_completa17);
            StartCoroutine(Verificar_NaoRespondida7(www17));
            string url_completa18 = url_verificarNaoRespondidasOuRespondidasForca+"?email="+UserData.email+"&opcao=8";
            WWW www18 = new WWW (url_completa18);
            StartCoroutine(Verificar_NaoRespondida8(www18));
            string url_completa19 = url_verificarNaoRespondidasOuRespondidasForca+"?email="+UserData.email+"&opcao=9";
            WWW www19 = new WWW (url_completa19);
            StartCoroutine(Verificar_NaoRespondida9(www19));
            string url_completa20 = url_verificarNaoRespondidasOuRespondidasForca+"?email="+UserData.email+"&opcao=10";
            WWW www20 = new WWW (url_completa20);
            StartCoroutine(Verificar_NaoRespondida10(www20));
        }  
     }
}

IEnumerator Verificar_NaoRespondida1(WWW www11){
     yield return www11;
     string ret = www11.text.ToString();
     ret = ret.TrimEnd();  
     if(ret == "0"){
        if (UserData.escolha == "1"){
            UserData.quiz1 = true;
        }
        if (UserData.escolha == "2"){
            UserData.forca1 = true;
        }
     }
     ok_1 = true;
}

IEnumerator Verificar_NaoRespondida2(WWW www12){
     yield return www12;
     string ret = www12.text.ToString();
     ret = ret.TrimEnd();  
     if(ret == "0"){
        if (UserData.escolha == "1"){
            UserData.quiz2 = true;
        }
        if (UserData.escolha == "2"){
            UserData.forca2 = true;
        }
     }
     ok_2 = true;
}

IEnumerator Verificar_NaoRespondida3(WWW www13){
     yield return www13;
     string ret = www13.text.ToString();
     ret = ret.TrimEnd();  
     if(ret == "0"){
        if (UserData.escolha == "1"){
            UserData.quiz3 = true;
        }
        if (UserData.escolha == "2"){
            UserData.forca3 = true;
        }
     }
     ok_3 = true;
}

IEnumerator Verificar_NaoRespondida4(WWW www14){
     yield return www14;
     string ret = www14.text.ToString();
     ret = ret.TrimEnd();  
     if(ret == "0"){
        if (UserData.escolha == "1"){
            UserData.quiz4 = true;
        }
        if (UserData.escolha == "2"){
            UserData.forca4 = true;
        }
     }
     ok_4 = true;
}

IEnumerator Verificar_NaoRespondida5(WWW www15){
     yield return www15;
     string ret = www15.text.ToString();
     ret = ret.TrimEnd();  
     if(ret == "0"){
        if (UserData.escolha == "1"){
            UserData.quiz5 = true;
        }
        if (UserData.escolha == "2"){
            UserData.forca5 = true;
        }
     }
     ok_5 = true;
}

IEnumerator Verificar_NaoRespondida6(WWW www16){
     yield return www16;
     string ret = www16.text.ToString();
     ret = ret.TrimEnd();  
     if(ret == "0"){
        if (UserData.escolha == "1"){
            UserData.quiz6 = true;
        }
        if (UserData.escolha == "2"){
            UserData.forca6 = true;
        }
     }
     ok_6 = true;
}

IEnumerator Verificar_NaoRespondida7(WWW www17){
     yield return www17;
     string ret = www17.text.ToString();
     ret = ret.TrimEnd();  
     if(ret == "0"){
        if (UserData.escolha == "1"){
            UserData.quiz7 = true;
        }
        if (UserData.escolha == "2"){
            UserData.forca7 = true;
        }
     }
     ok_7 = true;
}

IEnumerator Verificar_NaoRespondida8(WWW www18){
     yield return www18;
     string ret = www18.text.ToString();
     ret = ret.TrimEnd();  
     if(ret == "0"){
        if (UserData.escolha == "1"){
            UserData.quiz8 = true;
        }
        if (UserData.escolha == "2"){
            UserData.forca8 = true;
        }
     }
     ok_8 = true;
}

IEnumerator Verificar_NaoRespondida9(WWW www19){
     yield return www19;
     string ret = www19.text.ToString();
     ret = ret.TrimEnd();  
     if(ret == "0"){
        if (UserData.escolha == "1"){
            UserData.quiz9 = true;
        }
        if (UserData.escolha == "2"){
            UserData.forca9 = true;
        }
     }
     ok_9 = true;
}

IEnumerator Verificar_NaoRespondida10(WWW www20){
     yield return www20;
     string ret = www20.text.ToString();
     ret = ret.TrimEnd();  
     if(ret == "0"){
        if (UserData.escolha == "1"){
            UserData.quiz10 = true;
        }
        if (UserData.escolha == "2"){
            UserData.forca10 = true;
        }
     }
     ok_10 = true;
}



IEnumerator Num_aleatorio(WWW www){
        yield return www;
        num_gerado = www.text.ToString();
        num_gerado = num_gerado.TrimEnd();
        Debug.Log(num_gerado);
        if (UserData.escolha == "1"){
            num = int.Parse(num_gerado);
            UserData.id_jogo_quiz_atual = num;
            UserData.cont_jogo_quiz = 0;
            SceneManager.LoadScene("JogoQuiz");
        }
        if (UserData.escolha == "2"){
            WWW wwww = new WWW (url_selectJogoForca+"?id="+num_gerado+"&opcao=2");
            StartCoroutine(IniciarForca(wwww)); 
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


/*void Conferir(){
        if (ok_1 == false){
        }
        if (ok_2 == false){
        }
        if (ok_3 == false){
        }
        if (ok_4 == false){
        }
        if (ok_5 == false){
        }
        if (ok_6 == false){
        }
        if (ok_7 == false){
        }
        if (ok_8 == false){
        }
        if (ok_9 == false){ 
        }
}
*/



/*

void PrepararDesafio(){ 
    WWW www_gerarnumero = new WWW (url_aleatorio);
    StartCoroutine(Num_aleatorio(www_gerarnumero));
}

IEnumerator Verificar_Enunciado(WWW www1){
        yield return www1;
        enunciado.text = www1.text.ToString();
        enunciado.text = enunciado.text.TrimEnd();
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
}*/


void Parar(){
     SceneManager.LoadScene("TelaJogo");
}

}
