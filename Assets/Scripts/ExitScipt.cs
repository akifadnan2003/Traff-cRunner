using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void QuitGame()
    {
    Debug.Log("Oyun kapatıldı!"); 
    Application.Quit(); 
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
