using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TelaCadastro : MonoBehaviour {
	

public Button button_jogar;
public Button button_cancelar;
public InputField field_nome;
public InputField field_sobrenome;
public InputField field_email;
public InputField field_senha;
public string nome, sobrenome, email, senha;
public string url = "https://qualif.000webhostapp.com/html/selectLogin.php";

 void Start()
    {
        button_jogar.onClick.AddListener(Jogar);
        button_cancelar.onClick.AddListener(Cancelar);
        //button_sair.onClick.AddListener(Sair);
        //button_forca.onClick.AddListener(Forca);
        //button_ferramentas.onClick.AddListener(Ferramentas);

     }

   
 void Jogar(){

        nome = field_nome.text;
        sobrenome = field_sobrenome.text;
        email = field_email.text;
        senha = field_senha.text;
        Debug.Log("Hello: " + nome);
        Debug.Log("Hello: " + sobrenome);
        Debug.Log("Hello: " + email);
        Debug.Log("Hello: " + senha);
        //SceneManager.LoadScene("TelaJogo");
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
