using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TelaCadastro : MonoBehaviour {

public Button button_salvar;
public Button button_cancelar;
public InputField field_nome;
public InputField field_sobrenome;
public InputField field_email;
public InputField field_senha;
public string nome, sobrenome, email, senha, retorno;
public string url = "https://qualif.000webhostapp.com/html/cadastro.php";

 void Start()
    {
        button_salvar.onClick.AddListener(Salvar);
        button_cancelar.onClick.AddListener(Cancelar);
        //button_sair.onClick.AddListener(Sair);
        //button_forca.onClick.AddListener(Forca);
        //button_ferramentas.onClick.AddListener(Ferramentas);
        Debug.Log("Tela Jogo");

     }

   
 void Salvar(){

        if (field_nome.text == "" || field_sobrenome.text == "" || field_email.text == "" || field_senha.text == ""){
               // FeedBackError("Preencha todos os campos");
        }
        else{
             nome = field_nome.text;
             sobrenome = field_sobrenome.text;
             email = field_email.text;
             senha = field_senha.text;
             url = url+"?nome="+nome+"&sobrenome="+sobrenome+"&email="+email+"&senha="+senha;
             Debug.Log(url);
             WWW www = new WWW (url);
             StartCoroutine(ValidaLogin(www));
        }
      
        //SceneManager.LoadScene("TelaJogo");
    }


 IEnumerator ValidaLogin(WWW www){
        yield return www;
       // if (www.error == null){
         //   Debug.Log("Cadastro Realizado com Sucesso!");
        
        retorno = www.text.ToString();
        //Debug.Log(retorno);
        /*if (retorno == "1"){
            Debug.Log("Funcionou");
        }
        else{
             Debug.Log("Erro ao Cadastrar!");
        }*/

}


 void Cancelar(){

        SceneManager.LoadScene("Main");
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
