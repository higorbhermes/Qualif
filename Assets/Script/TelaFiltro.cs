using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TelaFiltro : MonoBehaviour {

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
public string url_RespondideuOuNaoQuiz = "https://qualif.000webhostapp.com/html/respondeu_ou_nao_jogoquiz.php";
public string url_AcertouOuNaoQuiz = "https://qualif.000webhostapp.com/html/acertou_ou_nao_jogoquiz.php";
public string url_RespondideuOuNaoForca = "https://qualif.000webhostapp.com/html/respondeu_ou_nao_jogoforca.php";
public string url_AcertouOuNaoForca = "https://qualif.000webhostapp.com/html/acertou_ou_nao_jogoforca.php";
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
    if (ok_1 == true){
            if (UserData.escolha == "1"){
                UserData.quiz_alternativo = true;
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
            if (UserData.escolha == "2"){
                UserData.forca_alternativo = true;
                if (UserData.forca1 == true){
                      UserData.id_jogo_forca_atual = 1;
                      UserData.cont_jogo_forca = 1;
                      SceneManager.LoadScene("JogoForca10Letras");
                }
                if (UserData.forca2 == true){
                      UserData.id_jogo_forca_atual = 2;
                      UserData.cont_jogo_forca = 2;
                      SceneManager.LoadScene("JogoForca10Letras");
                }
                if (UserData.forca3 == true){
                      UserData.id_jogo_forca_atual = 3;
                      UserData.cont_jogo_forca = 3;
                      SceneManager.LoadScene("JogoForca10Letras");
                }
                if (UserData.forca4 == true){
                      UserData.id_jogo_forca_atual = 4;
                      UserData.cont_jogo_forca = 4;
                      SceneManager.LoadScene("JogoForca1");
                }
                if (UserData.forca5 == true){
                      UserData.id_jogo_forca_atual = 5;
                      UserData.cont_jogo_forca = 5;
                      SceneManager.LoadScene("JogoForca1");
                }
                if (UserData.forca6 == true){
                      UserData.id_jogo_forca_atual = 6;
                      UserData.cont_jogo_forca = 6; 
                      SceneManager.LoadScene("JogoForca12Letras");
                }
                if (UserData.forca7 == true){
                      UserData.id_jogo_forca_atual = 7;
                      UserData.cont_jogo_forca = 7; 
                      SceneManager.LoadScene("JogoForca12Letras");
                }
                if (UserData.forca8 == true){
                      UserData.id_jogo_forca_atual = 8;
                      UserData.cont_jogo_forca = 8; 
                      SceneManager.LoadScene("JogoForca12Letras");
                }
                if (UserData.forca9 == true){
                      UserData.id_jogo_forca_atual = 9;
                      UserData.cont_jogo_forca = 9; 
                      SceneManager.LoadScene("JogoForca12Letras");
                }
                if (UserData.forca10 == true){
                      UserData.id_jogo_forca_atual = 10;
                      UserData.cont_jogo_forca = 10;
                      SceneManager.LoadScene("JogoForca10Letras");
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
            string url_completa1 = url_RespondideuOuNaoQuiz+"?email="+UserData.email;
            WWW www1 = new WWW (url_completa1);
            StartCoroutine(Verificar_PartidasNaoJogadasQuiz(www1));
        }
        if (UserData.escolha == "2"){
            string url_completa1 = url_RespondideuOuNaoForca+"?email="+UserData.email;
            WWW www1 = new WWW (url_completa1);
            StartCoroutine(Verificar_PartidasNaoJogadasForca(www1));
        }
     }
     if (resposta_escolhida == "C"){
        if (UserData.escolha == "1"){
            string url_completa1 = url_RespondideuOuNaoQuiz+"?email="+UserData.email;
            WWW www1 = new WWW (url_completa1);
            StartCoroutine(Verificar_PartidasJogadasQuiz(www1));
        }
        if (UserData.escolha == "2"){
            string url_completa1 = url_RespondideuOuNaoForca+"?email="+UserData.email;
            WWW www1 = new WWW (url_completa1);
            StartCoroutine(Verificar_PartidasJogadasForca(www1));
        }
     }
     if (resposta_escolhida == "D"){
        if (UserData.escolha == "1"){
            string url_completa1 = url_AcertouOuNaoQuiz+"?email="+UserData.email;
            WWW www1 = new WWW (url_completa1);
            StartCoroutine(Verificar_ErrosQuiz(www1));
        }
        if (UserData.escolha == "2"){
            string url_completa1 = url_AcertouOuNaoForca+"?email="+UserData.email;
            WWW www1 = new WWW (url_completa1);
            StartCoroutine(Verificar_ErrosForca(www1));
        }
     }
     if (resposta_escolhida == "E"){
        if (UserData.escolha == "1"){
            string url_completa1 = url_AcertouOuNaoQuiz+"?email="+UserData.email;
            WWW www1 = new WWW (url_completa1);
            StartCoroutine(Verificar_AcertosQuiz(www1));
        }
        if (UserData.escolha == "2"){
            string url_completa1 = url_AcertouOuNaoForca+"?email="+UserData.email;
            WWW www1 = new WWW (url_completa1);
            StartCoroutine(Verificar_AcertosForca(www1));
        }
     }
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

IEnumerator Verificar_PartidasNaoJogadasQuiz(WWW www1){
     yield return www1;
     string ret = www1.text.ToString();
     ret = ret.TrimEnd();
     if(ret == "1111111111"){
        mensagem.text = "Você já respondeu todos os desafios!";
        acertos.GetComponent<Toggle>().isOn = false;
        ineditas.GetComponent<Toggle>().isOn = false;
        respondidas.GetComponent<Toggle>().isOn = false;
        erros.GetComponent<Toggle>().isOn = false;
        aleatorio.GetComponent<Toggle>().isOn = false;    
     } 
     else{
        mensagem.text = "Carregando...";
        if (ret[0] == '0'){
            UserData.quiz1 = true;
        }
        if (ret[1] == '0'){
            UserData.quiz2 = true;
        }
        if (ret[2] == '0'){
            UserData.quiz3 = true;
        }
        if (ret[3] == '0'){
            UserData.quiz4 = true;
        }
        if (ret[4] == '0'){
            UserData.quiz5 = true;
        }
        if (ret[5] == '0'){
            UserData.quiz6 = true;
        }
        if (ret[6] == '0'){
            UserData.quiz7 = true;
        }
        if (ret[7] == '0'){
            UserData.quiz8 = true;
        }
        if (ret[8] == '0'){
            UserData.quiz9 = true;
        }
        if (ret[9] == '0'){
            UserData.quiz10 = true;
        }
        ok_1 = true;
     }
}

IEnumerator Verificar_PartidasNaoJogadasForca(WWW www1){
     yield return www1;
     string ret = www1.text.ToString();
     ret = ret.TrimEnd();
     if(ret == "1111111111"){
        mensagem.text = "Você já respondeu todos os desafios!";
        acertos.GetComponent<Toggle>().isOn = false;
        ineditas.GetComponent<Toggle>().isOn = false;
        respondidas.GetComponent<Toggle>().isOn = false;
        erros.GetComponent<Toggle>().isOn = false;
        aleatorio.GetComponent<Toggle>().isOn = false;    
     } 
     else{
        mensagem.text = "Carregando...";
        if (ret[0] == '0'){
            UserData.forca1 = true;
        }
        if (ret[1] == '0'){
            UserData.forca2 = true;
        }
        if (ret[2] == '0'){
            UserData.forca3 = true;
        }
        if (ret[3] == '0'){
            UserData.forca4 = true;
        }
        if (ret[4] == '0'){
            UserData.forca5 = true;
        }
        if (ret[5] == '0'){
            UserData.forca6 = true;
        }
        if (ret[6] == '0'){
            UserData.forca7 = true;
        }
        if (ret[7] == '0'){
            UserData.forca8 = true;
        }
        if (ret[8] == '0'){
            UserData.forca9 = true;
        }
        if (ret[9] == '0'){
            UserData.forca10 = true;
        }
        ok_1 = true;
     }
}

IEnumerator Verificar_PartidasJogadasQuiz(WWW www1){
     yield return www1;
     string ret = www1.text.ToString();
     ret = ret.TrimEnd();
     if(ret == "0000000000"){
        mensagem.text = "Você ainda não respondeu nenhum desafio!";
        acertos.GetComponent<Toggle>().isOn = false;
        ineditas.GetComponent<Toggle>().isOn = false;
        respondidas.GetComponent<Toggle>().isOn = false;
        erros.GetComponent<Toggle>().isOn = false;
        aleatorio.GetComponent<Toggle>().isOn = false;    
     } 
     else{
        mensagem.text = "Carregando...";
        if (ret[0] == '1'){
            UserData.quiz1 = true;
        }
        if (ret[1] == '1'){
            UserData.quiz2 = true;
        }
        if (ret[2] == '1'){
            UserData.quiz3 = true;
        }
        if (ret[3] == '1'){
            UserData.quiz4 = true;
        }
        if (ret[4] == '1'){
            UserData.quiz5 = true;
        }
        if (ret[5] == '1'){
            UserData.quiz6 = true;
        }
        if (ret[6] == '1'){
            UserData.quiz7 = true;
        }
        if (ret[7] == '1'){
            UserData.quiz8 = true;
        }
        if (ret[8] == '1'){
            UserData.quiz9 = true;
        }
        if (ret[9] == '1'){
            UserData.quiz10 = true;
        }
        ok_1 = true;
     }
}

IEnumerator Verificar_PartidasJogadasForca(WWW www1){
     yield return www1;
     string ret = www1.text.ToString();
     ret = ret.TrimEnd();
     if(ret == "0000000000"){
        mensagem.text = "Você ainda não respondeu nenhum desafio!";
        acertos.GetComponent<Toggle>().isOn = false;
        ineditas.GetComponent<Toggle>().isOn = false;
        respondidas.GetComponent<Toggle>().isOn = false;
        erros.GetComponent<Toggle>().isOn = false;
        aleatorio.GetComponent<Toggle>().isOn = false;    
     } 
     else{
        mensagem.text = "Carregando...";
        if (ret[0] == '1'){
            UserData.forca1 = true;
        }
        if (ret[1] == '1'){
            UserData.forca2 = true;
        }
        if (ret[2] == '1'){
            UserData.forca3 = true;
        }
        if (ret[3] == '1'){
            UserData.forca4 = true;
        }
        if (ret[4] == '1'){
            UserData.forca5 = true;
        }
        if (ret[5] == '1'){
            UserData.forca6 = true;
        }
        if (ret[6] == '1'){
            UserData.forca7 = true;
        }
        if (ret[7] == '1'){
            UserData.forca8 = true;
        }
        if (ret[8] == '1'){
            UserData.forca9 = true;
        }
        if (ret[9] == '1'){
            UserData.forca10 = true;
        }
        ok_1 = true;
     }
}

IEnumerator Verificar_ErrosQuiz(WWW www1){
     yield return www1;
     string ret = www1.text.ToString();
     ret = ret.TrimEnd();
     Debug.Log(""+ret);
     if(ret == "1111111111"  || ret == "2222222222"){
        mensagem.text = "Você não errou nenhum desafio!";
        acertos.GetComponent<Toggle>().isOn = false;
        ineditas.GetComponent<Toggle>().isOn = false;
        respondidas.GetComponent<Toggle>().isOn = false;
        erros.GetComponent<Toggle>().isOn = false;
        aleatorio.GetComponent<Toggle>().isOn = false;    
     } 
     else{
        mensagem.text = "Carregando...";
        if (ret[0] == '0'){
            UserData.quiz1 = true;
        }
        if (ret[1] == '0'){
            UserData.quiz2 = true;
        }
        if (ret[2] == '0'){
            UserData.quiz3 = true;
        }
        if (ret[3] == '0'){
            UserData.quiz4 = true;
        }
        if (ret[4] == '0'){
            UserData.quiz5 = true;
        }
        if (ret[5] == '0'){
            UserData.quiz6 = true;
        }
        if (ret[6] == '0'){
            UserData.quiz7 = true;
        }
        if (ret[7] == '0'){
            UserData.quiz8 = true;
        }
        if (ret[8] == '0'){
            UserData.quiz9 = true;
        }
        if (ret[9] == '0'){
            UserData.quiz10 = true;
        }
        if (UserData.quiz1 == false && UserData.quiz2 == false  && UserData.quiz3 == false  && UserData.quiz4 == false  && UserData.quiz5 == false  && UserData.quiz6 == false  && UserData.quiz7 == false  && UserData.quiz8 == false  && UserData.quiz9 == false  && UserData.quiz10 == false){
            mensagem.text = "Você não errou nenhum desafio!";
            acertos.GetComponent<Toggle>().isOn = false;
            ineditas.GetComponent<Toggle>().isOn = false;
            respondidas.GetComponent<Toggle>().isOn = false;
            erros.GetComponent<Toggle>().isOn = false;
            aleatorio.GetComponent<Toggle>().isOn = false;  
        }
        else{
            ok_1 = true;
        }
     }
}

IEnumerator Verificar_ErrosForca(WWW www1){
     yield return www1;
     string ret = www1.text.ToString();
     ret = ret.TrimEnd();
     Debug.Log(""+ret);
     if(ret == "1111111111"  || ret == "2222222222"){
        mensagem.text = "Você não errou nenhum desafio!";
        acertos.GetComponent<Toggle>().isOn = false;
        ineditas.GetComponent<Toggle>().isOn = false;
        respondidas.GetComponent<Toggle>().isOn = false;
        erros.GetComponent<Toggle>().isOn = false;
        aleatorio.GetComponent<Toggle>().isOn = false;    
     } 
     else{
        mensagem.text = "Carregando...";
        if (ret[0] == '0'){
            UserData.forca1 = true;
        }
        if (ret[1] == '0'){
            UserData.forca2 = true;
        }
        if (ret[2] == '0'){
            UserData.forca3 = true;
        }
        if (ret[3] == '0'){
            UserData.forca4 = true;
        }
        if (ret[4] == '0'){
            UserData.forca5 = true;
        }
        if (ret[5] == '0'){
            UserData.forca6 = true;
        }
        if (ret[6] == '0'){
            UserData.forca7 = true;
        }
        if (ret[7] == '0'){
            UserData.forca8 = true;
        }
        if (ret[8] == '0'){
            UserData.forca9 = true;
        }
        if (ret[9] == '0'){
            UserData.forca10 = true;
        }
        if (UserData.forca1 == false && UserData.forca2 == false  && UserData.forca3 == false  && UserData.forca4 == false  && UserData.forca5 == false  && UserData.forca6 == false  && UserData.forca7 == false  && UserData.forca8 == false  && UserData.forca9 == false  && UserData.forca10 == false){
            mensagem.text = "Você não errou nenhum desafio!";
            acertos.GetComponent<Toggle>().isOn = false;
            ineditas.GetComponent<Toggle>().isOn = false;
            respondidas.GetComponent<Toggle>().isOn = false;
            erros.GetComponent<Toggle>().isOn = false;
            aleatorio.GetComponent<Toggle>().isOn = false;  
        }
        else{
            ok_1 = true;
        }
     }
}

IEnumerator Verificar_AcertosQuiz(WWW www1){
     yield return www1;
     string ret = www1.text.ToString();
     ret = ret.TrimEnd();
     if(ret == "0000000000" || ret == "2222222222"){
        mensagem.text = "Você ainda não acertou nenhum desafio!";
        acertos.GetComponent<Toggle>().isOn = false;
        ineditas.GetComponent<Toggle>().isOn = false;
        respondidas.GetComponent<Toggle>().isOn = false;
        erros.GetComponent<Toggle>().isOn = false;
        aleatorio.GetComponent<Toggle>().isOn = false;    
     } 
     else{
        mensagem.text = "Carregando...";
        if (ret[0] == '1'){
            UserData.quiz1 = true;
        }
        if (ret[1] == '1'){
            UserData.quiz2 = true;
        }
        if (ret[2] == '1'){
            UserData.quiz3 = true;
        }
        if (ret[3] == '1'){
            UserData.quiz4 = true;
        }
        if (ret[4] == '1'){
            UserData.quiz5 = true;
        }
        if (ret[5] == '1'){
            UserData.quiz6 = true;
        }
        if (ret[6] == '1'){
            UserData.quiz7 = true;
        }
        if (ret[7] == '1'){
            UserData.quiz8 = true;
        }
        if (ret[8] == '1'){
            UserData.quiz9 = true;
        }
        if (ret[9] == '1'){
            UserData.quiz10 = true;
        }
        if (UserData.quiz1 == false && UserData.quiz2 == false  && UserData.quiz3 == false  && UserData.quiz4 == false  && UserData.quiz5 == false  && UserData.quiz6 == false  && UserData.quiz7 == false  && UserData.quiz8 == false  && UserData.quiz9 == false  && UserData.quiz10 == false){
            mensagem.text = "Você não errou nenhum desafio!";
            acertos.GetComponent<Toggle>().isOn = false;
            ineditas.GetComponent<Toggle>().isOn = false;
            respondidas.GetComponent<Toggle>().isOn = false;
            erros.GetComponent<Toggle>().isOn = false;
            aleatorio.GetComponent<Toggle>().isOn = false;  
        }
        else{
            ok_1 = true;
        }
        
     }
}

IEnumerator Verificar_AcertosForca(WWW www1){
     yield return www1;
     string ret = www1.text.ToString();
     ret = ret.TrimEnd();
     if(ret == "0000000000" || ret == "2222222222"){
        mensagem.text = "Você ainda não acertou nenhum desafio!";
        acertos.GetComponent<Toggle>().isOn = false;
        ineditas.GetComponent<Toggle>().isOn = false;
        respondidas.GetComponent<Toggle>().isOn = false;
        erros.GetComponent<Toggle>().isOn = false;
        aleatorio.GetComponent<Toggle>().isOn = false;    
     } 
     else{
        mensagem.text = "Carregando...";
        if (ret[0] == '1'){
            UserData.forca1 = true;
        }
        if (ret[1] == '1'){
            UserData.forca2 = true;
        }
        if (ret[2] == '1'){
            UserData.forca3 = true;
        }
        if (ret[3] == '1'){
            UserData.forca4 = true;
        }
        if (ret[4] == '1'){
            UserData.forca5 = true;
        }
        if (ret[5] == '1'){
            UserData.forca6 = true;
        }
        if (ret[6] == '1'){
            UserData.forca7 = true;
        }
        if (ret[7] == '1'){
            UserData.forca8 = true;
        }
        if (ret[8] == '1'){
            UserData.forca9 = true;
        }
        if (ret[9] == '1'){
            UserData.forca10 = true;
        }
        if (UserData.forca1 == false && UserData.forca2 == false  && UserData.forca3 == false  && UserData.forca4 == false  && UserData.forca5 == false  && UserData.forca6 == false  && UserData.forca7 == false  && UserData.forca8 == false  && UserData.forca9 == false  && UserData.forca10 == false){
            mensagem.text = "Você não errou nenhum desafio!";
            acertos.GetComponent<Toggle>().isOn = false;
            ineditas.GetComponent<Toggle>().isOn = false;
            respondidas.GetComponent<Toggle>().isOn = false;
            erros.GetComponent<Toggle>().isOn = false;
            aleatorio.GetComponent<Toggle>().isOn = false;  
        }
        else{
            ok_1 = true;
        }
        
     }
}

void Parar(){
     SceneManager.LoadScene("TelaJogo");
}

}
