using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Referências : MonoBehaviour {

public Button button_cancelar;

void Start()
    {
        button_cancelar.onClick.AddListener(Cancelar);
}

void Cancelar(){
      SceneManager.LoadScene("TelaJogo");
}
}
