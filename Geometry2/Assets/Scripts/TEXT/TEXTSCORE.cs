using System.Collections;                                           
using System.Collections.Generic;                                    
using UnityEngine;                                                     
using UnityEngine.UI;                                                  
using System;                                                           

public class TEXTSCORE : MonoBehaviour                                 
{
    int santimeters = 0;                                                

    void Start()                                                     
    {
        santimeters = 0;                                              
        GetComponent<Text>().text = "You flew: " + santimeters;        
        PlayerPrefs.SetInt("Score", 0);                                 
        LoadChet();
    }
    void Update()                                                     
    {
        GetComponent<Text>().text = "You flew: " + santimeters;         
        PlayerPrefs.SetInt("Score", santimeters);                       
            if (GameObject.FindGameObjectsWithTag("Player").Length == 0)
            {
                if (PlayerPrefs.GetInt("MaxScore") < santimeters)       
                PlayerPrefs.SetInt("MaxScore", santimeters);           
            }
    }
    void LoadChet()                                                     
                                                                       
    {
        StartCoroutine(Chet());                               
    }

    IEnumerator Chet()                                          
    {
        while (true)
       {
            yield return new WaitForSeconds(0.025f);                  
            santimeters = santimeters + 1;                            
        }
    }
}
