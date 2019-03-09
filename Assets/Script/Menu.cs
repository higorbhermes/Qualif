using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour {
	

public Button button_jogar;
public Button button_cadastro;
public InputField field_email;
public InputField field_senha;
public string email, senha, retorno;
public int teste;
public string url = "https://qualif.000webhostapp.com/html/selectLogin.php";
public string url_completa;

void Start(){
        button_jogar.onClick.AddListener(Login);
        button_cadastro.onClick.AddListener(Cadastrar);
        //button_sair.onClick.AddListener(Sair);
}

   
 void Login(){

   if (field_email.text == "" || field_senha.text == ""){
               // FeedBackError("Preencha todos os campos");
        }
   else{
             email = field_email.text;
             senha = field_senha.text;
             url_completa = url+"?email="+email+"&senha="+senha;
             Debug.Log(url_completa);
             WWW www = new WWW (url_completa);
             StartCoroutine(ValidaLogin(www));
        }
 }

 IEnumerator ValidaLogin(WWW www){
        yield return www;
        retorno = www.text.ToString();
        retorno = retorno.TrimEnd();
        string resultado_verdadeiro = "1";
        bool resultado = resultado_verdadeiro.Equals(retorno);
        if (resultado == true ){
            Debug.Log("Seja Bem Vindo ao Qualif");
        }
        else{
             Debug.Log("Por favor, tente novamente");
        }
        /*if (retorno == "0"){
            Debug.Log("Erro no Login!");
        }
        else{
             Debug.Log("Funcionou");
        }*/

}


 void Cadastrar(){

        SceneManager.LoadScene("TelaCadastro");
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
