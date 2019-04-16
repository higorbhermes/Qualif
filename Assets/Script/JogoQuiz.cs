using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JogoQuiz : MonoBehaviour {

public Button button_ajuda;
public Button button_responder;
public Button button_parar;
public GameObject alternativa_a;
public GameObject alternativa_b;
public GameObject alternativa_c;
public GameObject alternativa_d;
public GameObject alternativa_e;

void Start(){
        button_ajuda.onClick.AddListener(Ajuda);
        button_responder.onClick.AddListener(Responder);
        button_parar.onClick.AddListener(Parar);
}

void FixedUpdate(){
    if  (alternativa_a.GetComponent<Toggle>().isOn == true){
         alternativa_b.GetComponent<Toggle>().isOn = false;
         alternativa_c.GetComponent<Toggle>().isOn = false;
         alternativa_d.GetComponent<Toggle>().isOn = false;
         alternativa_e.GetComponent<Toggle>().isOn = false;
    }
    if  (alternativa_b.GetComponent<Toggle>().isOn == true){
         alternativa_a.GetComponent<Toggle>().isOn = false;
         alternativa_c.GetComponent<Toggle>().isOn = false;
         alternativa_d.GetComponent<Toggle>().isOn = false;
         alternativa_e.GetComponent<Toggle>().isOn = false;
    }
    if  (alternativa_c.GetComponent<Toggle>().isOn == true){
         alternativa_b.GetComponent<Toggle>().isOn = false;
         alternativa_a.GetComponent<Toggle>().isOn = false;
         alternativa_d.GetComponent<Toggle>().isOn = false;
         alternativa_e.GetComponent<Toggle>().isOn = false;
    }
    if  (alternativa_d.GetComponent<Toggle>().isOn == true){
         alternativa_b.GetComponent<Toggle>().isOn = false;
         alternativa_c.GetComponent<Toggle>().isOn = false;
         alternativa_a.GetComponent<Toggle>().isOn = false;
         alternativa_e.GetComponent<Toggle>().isOn = false;
    }
    if  (alternativa_e.GetComponent<Toggle>().isOn == true){
         alternativa_b.GetComponent<Toggle>().isOn = false;
         alternativa_c.GetComponent<Toggle>().isOn = false;
         alternativa_d.GetComponent<Toggle>().isOn = false;
         alternativa_a.GetComponent<Toggle>().isOn = false;
    }    
}

void Ajuda(){
}

void Responder(){
}

void Parar(){
     SceneManager.LoadScene("TelaJogo");
}

}
