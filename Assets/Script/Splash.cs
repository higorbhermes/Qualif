using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Splash : MonoBehaviour {
	

public Button b_play;
public float timer = 0;
public float oldTimer;


 void Start()
    {
        timer -= Time.deltaTime;
     }

   
 void Update (){
        if (timer < -1){
              SceneManager.LoadScene("Main");
        }
  }
}
