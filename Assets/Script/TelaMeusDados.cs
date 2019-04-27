using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TelaMeusDados : MonoBehaviour {

public Button button_salvar;
public Button button_cancelar;
public Text mensagem;
public InputField field_nome;
public InputField field_sobrenome;
public InputField field_email;
public InputField field_senha;
public string nome, sobrenome, email, senha, retorno;
public string url = "https://qualif.000webhostapp.com/html/selectUsuario.php";
public string url_atualizar = "https://qualif.000webhostapp.com/html/atualizar_dados.php";
public string url_completa, url_completa1, url_completa2, url_completa3, url_completa4;
public bool ok_1 = false,  ok_2 = false, ok_3 = false;

void Start()
    {
        button_salvar.onClick.AddListener(Salvar);
        button_cancelar.onClick.AddListener(Cancelar);
        url_completa1 = url+"?email="+UserData.email+"&opcao=1";
        WWW www1 = new WWW (url_completa1);
        StartCoroutine(Verificar_Nome(www1));  
        url_completa2 = url+"?email="+UserData.email+"&opcao=2";
        WWW www2 = new WWW (url_completa2);
        StartCoroutine(Verificar_Sobrenome(www2));
        url_completa3 = url+"?email="+UserData.email+"&opcao=4";
        WWW www3 = new WWW (url_completa3);
        StartCoroutine(Verificar_Senha(www3));
        field_email.text = UserData.email;
        Conferir();
        //button_sair.onClick.AddListener(Sair);
        //button_forca.onClick.AddListener(Forca);
        //button_ferramentas.onClick.AddListener(Ferramentas);
 }

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

   
 void Salvar(){
        if (field_nome.text == "" || field_sobrenome.text == "" || field_email.text == "" || field_senha.text == ""){
             mensagem.text = "Preencha todos os campos!";
        }
        else{
             nome = field_nome.text;
             sobrenome = field_sobrenome.text;
             email = field_email.text;
             senha = field_senha.text;
             url_completa = url_atualizar+"?email_antigo="+UserData.email+"&nome="+nome+"&sobrenome="+sobrenome+"&email_novo="+email+"&senha="+senha;
             Debug.Log(url_completa);
             WWW www = new WWW (url_completa);
             StartCoroutine(ValidaLogin(www));
             UserData.email = email;
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


 void Cancelar(){

        SceneManager.LoadScene("TelaJogo");
    }


 //void Sair(){
        //Application.Quit();
    //}

 void Forca(){
        SceneManager.LoadScene("JogoForca1");
    }

 void Ferramentas(){
        SceneManager.LoadScene("Cena1");
    }
}
