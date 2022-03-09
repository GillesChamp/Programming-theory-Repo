using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class GameManager : TheGame
{
    public TextMeshProUGUI userName;
    public static string persistentUserName;

    void Start()
    {
        TheGame.Multiplier = 200f;
    }


    public void setUserName()
    {
        // it is called by the username gui once the username will be inserted
        persistentUserName = userName.text;
        print("The user name is: " + persistentUserName);
        SceneManager.LoadScene(1);
    }

    
}
