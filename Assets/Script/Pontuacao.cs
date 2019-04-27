using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour {



public Button button_voltar;
public Button button_zerar_quiz;
public Button button_zerar_forca;
public string url = "https://qualif.000webhostapp.com/html/pontuacao.php";
public Text quiz_partidas, quiz_acertos, quiz_erros, forca_partidas, forca_acertos, forca_erros, quiz_aproveitamento, forca_aproveitamento;
public bool ok_1 = false, ok_2 = false, ok_3 = false, ok_4 = false, ok_5 = false, ok_6 = false; 

void Start(){
        button_voltar.onClick.AddListener(Voltar);
        button_zerar_quiz.onClick.AddListener(ZerarQuiz);
        button_zerar_forca.onClick.AddListener(ZerarForca);
        string url_completa1 = url+"?email="+UserData.email+"&opcao=1";
        WWW www1 = new WWW (url_completa1);
        StartCoroutine(Verificar_PartidasQuiz(www1));
        string url_completa2 = url+"?email="+UserData.email+"&opcao=2";
        WWW www2 = new WWW (url_completa2);
        StartCoroutine(Verificar_AcertosQuiz(www2)); 
        string url_completa3 = url+"?email="+UserData.email+"&opcao=3";
        WWW www3 = new WWW (url_completa3);
        StartCoroutine(Verificar_ErrosQuiz(www3));  
        string url_completa4 = url+"?email="+UserData.email+"&opcao=4";
        WWW www4 = new WWW (url_completa4);
        StartCoroutine(Verificar_PartidasForca(www4));
        string url_completa5 = url+"?email="+UserData.email+"&opcao=5";
        WWW www5 = new WWW (url_completa5);
        StartCoroutine(Verificar_AcertosForca(www5));
        string url_completa6 = url+"?email="+UserData.email+"&opcao=6";
        WWW www6 = new WWW (url_completa6);
        StartCoroutine(Verificar_ErrosForca(www6)); 
        Conferir();
}

void Conferir(){
    if (ok_1 == false){
        string url_completa1 = url+"?email="+UserData.email+"&opcao=1";
        WWW www1 = new WWW (url_completa1);
        StartCoroutine(Verificar_PartidasQuiz(www1));
    }
    if (ok_2 == false){
        string url_completa2 = url+"?email="+UserData.email+"&opcao=2";
        WWW www2 = new WWW (url_completa2);
        StartCoroutine(Verificar_AcertosQuiz(www2));  
    }
    if (ok_3 == false){
        string url_completa3 = url+"?email="+UserData.email+"&opcao=3";
        WWW www3 = new WWW (url_completa3);
        StartCoroutine(Verificar_ErrosQuiz(www3)); 
    }
    if (ok_4 == false){
        string url_completa4 = url+"?email="+UserData.email+"&opcao=4";
        WWW www4 = new WWW (url_completa4);
        StartCoroutine(Verificar_PartidasForca(www4));
    }
    if (ok_5 == false){
        string url_completa5 = url+"?email="+UserData.email+"&opcao=5";
        WWW www5 = new WWW (url_completa5);
        StartCoroutine(Verificar_AcertosForca(www5));
    }
    if (ok_6 == false){
        string url_completa6 = url+"?email="+UserData.email+"&opcao=6";
        WWW www6 = new WWW (url_completa6);
        StartCoroutine(Verificar_ErrosForca(www6));
    }
}

void Voltar(){
     SceneManager.LoadScene("TelaJogo");
}

void ZerarQuiz(){
    string url_completa = url+"?email="+UserData.email+"&opcao=7";
    WWW www = new WWW (url_completa);
    StartCoroutine(ZerarJogoQuiz(www));  
}

void ZerarForca(){
    string url_completa = url+"?email="+UserData.email+"&opcao=8";
    forca_partidas.text = ""; 
    forca_partidas.text = "Nº de partidas: 0"; 
    forca_acertos.text = ""; 
    forca_acertos.text = "Nº de acertos: 0";
    forca_erros.text = ""; 
    forca_erros.text = "Nº de erros: 0"; 
    WWW www = new WWW (url_completa);
    StartCoroutine(ZerarJogoQuiz(www));  
}

IEnumerator ZerarJogoQuiz(WWW www){
     yield return www;
     quiz_partidas.text = ""; 
     quiz_partidas.text = "Nº de partidas: 0";
     quiz_acertos.text = "";  
     quiz_acertos.text = "Nº de acertos: 0"; 
     quiz_erros.text = ""; 
     quiz_erros.text = "Nº de erros: 0"; 
     //quiz_aproveitamento.text = "Aproveitamento: 0%";
}

IEnumerator ZerarJogoForca(WWW www){
     yield return www;
     //forca_aproveitamento.text = "Aproveitamento: 0%";
}

IEnumerator Verificar_PartidasQuiz(WWW www1){
        yield return www1;
        quiz_partidas.text = www1.text.ToString();
        quiz_partidas.text = "Nº de partidas: "+(quiz_partidas.text).TrimEnd();
        ok_1 = true;
}

IEnumerator Verificar_AcertosQuiz(WWW www2){
        yield return www2;
        quiz_acertos.text = www2.text.ToString();
        quiz_acertos.text = "Nº de acertos: "+(quiz_acertos.text).TrimEnd();
        ok_2 = true;
}

IEnumerator Verificar_ErrosQuiz(WWW www3){
        yield return www3;
        quiz_erros.text = www3.text.ToString();
        quiz_erros.text = "Nº de erros: "+(quiz_erros.text).TrimEnd();
        ok_3 = true;
}

IEnumerator Verificar_PartidasForca(WWW www4){
        yield return www4;
        forca_partidas.text = www4.text.ToString();
        forca_partidas.text = "Nº de partidas: "+(forca_partidas.text).TrimEnd();
        ok_4 = true;
}

IEnumerator Verificar_AcertosForca(WWW www5){
        yield return www5;
        forca_acertos.text = www5.text.ToString();
        forca_acertos.text = "Nº de acertos: "+(forca_acertos.text).TrimEnd();
        ok_5 = true;
}

IEnumerator Verificar_ErrosForca(WWW www6){
        yield return www6;
        forca_erros.text = www6.text.ToString();
        forca_erros.text = "Nº de erros: "+(forca_erros.text).TrimEnd();
        ok_6 = true;
}

/*public Button button_salvar;
public Button button_voltar;
public string nome, sobrenome, email, senha, retorno;
public string url = "https://qualif.000webhostapp.com/html/pontuacao.php";
public string url_atualizar = "https://qualif.000webhostapp.com/html/atualizar_dados.php";
public string url_completa, url_completa1, url_completa2, url_completa3, url_completa4;
public bool ok_1 = false,  ok_2 = false, ok_3 = false;



public void Conferir(){
    if (ok_1 == false){
        url_completa1 = url+"?email="+UserData.email+"&opcao=1";
        WWW www1 = new WWW (url_completa1);
        StartCoroutine(Verificar_Nome(www1));  
    }
    if (ok_2 == false){
        url_completa2 = url+"?email="+UserData.email+"&opcao=2";
        WWW www2 = new WWW (url_completa2);
        StartCoroutine(Verificar_Sobrenome(www2));
    }
    if (ok_3 == false){
        url_completa3 = url+"?email="+UserData.email+"&opcao=4";
        WWW www3 = new WWW (url_completa3);
        StartCoroutine(Verificar_Senha(www3));
    }
}

IEnumerator Verificar_Nome(WWW www1){
        yield return www1;
        field_nome.text = www1.text.ToString();
        field_nome.text = (field_nome.text).TrimEnd();
        ok_1 = true;
}

IEnumerator Verificar_Sobrenome(WWW www2){
        yield return www2;
        field_sobrenome.text = www2.text.ToString();
        field_sobrenome.text = (field_sobrenome.text).TrimEnd();
        ok_2 = true;
}

IEnumerator Verificar_Senha(WWW www3){
        yield return www3;
        field_senha.text = www3.text.ToString();
        field_senha.text = (field_senha.text).TrimEnd();
        ok_3 = true;
}

IEnumerator ValidaLogin(WWW www){
        yield return www;
        retorno = www.text.ToString();
        Debug.Log(retorno);
        retorno = retorno.TrimEnd();
        if (retorno == "111"){
               mensagem.text = "Seus dados foram atualizados!";
        }
        else{
               mensagem.text = "Houve um erro ao atualizar seus dados!";
        }

}



*/
}
