using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    

    public void Gamelevel()
    {
        SceneManager.LoadScene("Marcus");
    }

    public void ControlsMenu()
    {
        SceneManager.LoadScene("Controls");
    }
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    

    public void QuitTheGame()
    {

        #if UNITY_STANDALONE
        Application.Quit();
        #endif

        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }


    
   
   
}
