using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TelaVitoria : MonoBehaviour {

public Text mensagem;

void Start(){
   mensagem.text = "Parabéns, "+UserData.email+"! Você concluiu todos os desafios!"; 
}

void FixedUpdate(){
 if (Input.GetKeyDown(KeyCode.Space)){
     UserData.pontuacao = 100;
     SceneManager.LoadScene("TelaJogo");
 }
}

}
