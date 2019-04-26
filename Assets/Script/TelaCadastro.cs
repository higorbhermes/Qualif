using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TelaCadastro : MonoBehaviour {

public Button button_salvar;
public Button button_cancelar;
public Text mensagem;
public InputField field_nome;
public InputField field_sobrenome;
public InputField field_email;
public InputField field_senha;
public string nome, sobrenome, email, senha, retorno;
public string url = "https://qualif.000webhostapp.com/html/cadastro.php";
public string url_completa;

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
               //mensagem.text = "Preencha todos os campos!";
        }
        else{
             nome = field_nome.text;
             sobrenome = field_sobrenome.text;
             email = field_email.text;
             senha = field_senha.text;
             url_completa = url+"?nome="+nome+"&sobrenome="+sobrenome+"&email="+email+"&senha="+senha;
             Debug.Log(url_completa);
             WWW www = new WWW (url_completa);
             StartCoroutine(ValidaLogin(www));
        }
    }


 IEnumerator ValidaLogin(WWW www){
        yield return www;
        retorno = www.text.ToString();
        Debug.Log(retorno);
        retorno = retorno.TrimEnd();
        if (retorno == "1"){
               //mensagem.text = "Seus dados foram salvos com sucesso!";
        }
        else{
               //mensagem.text = "Houve um erro no seu cadastro";
        }

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
