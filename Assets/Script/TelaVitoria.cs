using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TelaVitoria : MonoBehaviour {

public Text mensagem;
public double timer = 0.0;

void Start(){
   mensagem.text = "Parabéns, "+UserData.email+"! Você concluiu todos os desafios!"; 
}

void FixedUpdate(){
 timer -= Time.deltaTime;
 if (timer<-5){
     UserData.pontuacao = 100;
     SceneManager.LoadScene("TelaJogo");
 }
}

}
