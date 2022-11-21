using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
        Debug.Log("Created By Tunzira Abrar");
    }
     public void OpenAuthor()
    {
        SceneManager.LoadScene("Credit Scene");
        Debug.Log("Created By Tunzira Abrar");
    }

    //Test Back Button ingame
    public void BackButton()
    {
        SceneManager.LoadScene("Main Menu");
        Debug.Log("You Back to Main Menu");
    }

    //Test Back Button in credit scene
    public void ComeBackButton()
    {
        SceneManager.LoadScene("Main Menu");
        Debug.Log("You Back to Main Menu");
    }
}