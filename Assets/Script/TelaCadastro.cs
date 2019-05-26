using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TelaCadastro : MonoBehaviour {

public Button button_salvar;
public Button button_cancelar;
public Button button_politica;
public Text mensagem;
public InputField field_nome;
public InputField field_sobrenome;
public InputField field_email;
public InputField field_senha;
public GameObject aceitacao;
public string nome, sobrenome, email, senha, retorno;
public string url = "https://qualif.000webhostapp.com/html/cadastro.php";
public string url_completa;

 void Start()
    {
        button_salvar.onClick.AddListener(Salvar);
        button_cancelar.onClick.AddListener(Cancelar);
        button_politica.onClick.AddListener(Politica);
        aceitacao.GetComponent<Toggle>().isOn = false;
        UserData.tela_cadastro = true;
        UserData.tela_menu = false;
        UserData.tela_main = false;
        //button_sair.onClick.AddListener(Sair);
        //button_forca.onClick.AddListener(Forca);
        //button_ferramentas.onClick.AddListener(Ferramentas);
     }

   
 void Salvar(){
        mensagem.text = "";
        if (field_nome.text == "" || field_sobrenome.text == "" || field_email.text == "" || field_senha.text == ""){
            mensagem.text = "Preencha todos os campos!";
        }
        else{
             if  (aceitacao.GetComponent<Toggle>().isOn == false){
                 mensagem.text = "Aceite a politica de privacidade!";
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
    }


 IEnumerator ValidaLogin(WWW www){
        yield return www;
        retorno = www.text.ToString();
        Debug.Log(retorno);
        retorno = retorno.TrimEnd();
        if (retorno == "1"){
            mensagem.text = "O seu cadastro foi realizado com sucesso!";
        }
        else{
            mensagem.text = "Houve um erro ao cadastrar, tente novamente!";
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

 void Politica(){
        SceneManager.LoadScene("TelaPoliticaPrivacidade");
    }
}
