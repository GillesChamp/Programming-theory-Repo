using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class GameManager : TheGame // INHERITANCE
{
    public TextMeshProUGUI userName;
    public static string persistentUserName;

    void Start()
    {
        Multiplier =  30f; // will generate an error in debug console
        Multiplier = 200f; // this is ok
    }

    public void Awake()
    {    
        DontDestroyOnLoad(this.gameObject);
    }

    public void setUserName()
    {
        // it is called by the username in UI once the username will be inserted
        persistentUserName = userName.text;
        print("The user name is: " + persistentUserName);
        SceneManager.LoadScene(1);
    }

    void OnGUI() // doesn't work in webGL try
    {
        if (persistentUserName != null)
        {
            GUI.Label(new Rect(10, 10, 110, 110), "User: " + persistentUserName);
        }

        /*
        if (GUI.Button(new Rect(0, 25, 100, 30), "I am a button"))
        {
            print("Pushed");
        }
        GUI.Label(new Rect(0, 55, 100, 50), "Hello");
        */
    }
}
