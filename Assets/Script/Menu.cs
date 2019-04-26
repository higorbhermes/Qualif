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
public int msg = 1, msg1 = 0, msg2 = 0, msg3 = 0;
public Text mensagem;

void Start(){
     button_jogar.onClick.AddListener(Login);
     button_cadastro.onClick.AddListener(Cadastrar);
}

void FixedUpdate(){
    if (msg == 1){
       mensagem.text = "";
    }
    if (msg1 == 1){
       mensagem.text = "Preencha todos os dados!";
    }
    if (msg2 == 1){
       mensagem.text = "Seja bem vindo ao Qualif!";
    }
    if (msg3 == 1){
       mensagem.text = "Não foi possível realizar o seu login!";
    }
    if (Input.GetKeyDown(KeyCode.Escape)){
       Application.Quit();
    }
}

   
void Login(){

  if (field_email.text == "" || field_senha.text == ""){
              //mensagem.text = "Preencha todos os campos";
            //msg = 0;
            //msg1 = 1;
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
            msg = 0;
            msg2 = 1;
            //mensagem.text = "Seja bem Vindo ao Qualif";
            UserData.email = email;
            SceneManager.LoadScene("TelaJogo");
        }
        else{
            msg = 0;
            msg3 = 1;
             //mensagem.text = "Não foi possível realizar o seu login";
        }
        /*if (retorno == "0"){
            Debug.Log("Erro no Login!" Nao foi possivel realizar seu login!);
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
