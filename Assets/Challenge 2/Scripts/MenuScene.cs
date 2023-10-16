using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // You need to import the SceneManager namespace

public class MenuScene : MonoBehaviour
{
    // This method could be called when a button is clicked or some other event occurs
    public void LoadChallengeScene()
    {
        SceneManager.LoadScene("Challenge 2");
    }
     public void LoadMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }
    public void ExitScene()
    {
        Application.OpenURL("https://github.com/NicolaeCasian/Challenge2");
    }
}
