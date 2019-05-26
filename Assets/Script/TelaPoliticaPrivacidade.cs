using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TelaPoliticaPrivacidade : MonoBehaviour {

public Button button_cancelar;

void Start()
    {
        button_cancelar.onClick.AddListener(Cancelar);
}

 void Cancelar(){
        if (UserData.tela_cadastro == true){
            SceneManager.LoadScene("TelaCadastro");
        }
        if (UserData.tela_menu == true){
            SceneManager.LoadScene("TelaJogo");
        }
        if (UserData.tela_main == true){
            SceneManager.LoadScene("Main");
        }
    }
}
