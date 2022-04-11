using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() {
       
        
    }
    
    void Update() { 

        if(Input.GetMouseButtonDown(0)){

            try {
                
                SceneManager.LoadScene("SampleScene");

            } 
            catch {

                Debug.Log("Something went kaput.");

            }
        }  

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}



