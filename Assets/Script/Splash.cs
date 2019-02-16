using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Splash : MonoBehaviour {
	

public Button b_play;
public float timer = 1;
public float oldTimer;


 void Start()
    {
         oldTimer = timer;
     }

   
 void Update (){
        timer -= Time.deltaTime;
        if (timer < 0){
              SceneManager.LoadScene("Main");
        }
  }
}
