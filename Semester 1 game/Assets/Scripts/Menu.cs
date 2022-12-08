using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
   public GameObject panelSettings;
   private GameMusic music;
   public GameObject musicObjectDelete;
    

    void Start()
   {
       // music = GameObject.FindWithTag("MusicManager");
        musicObjectDelete = GameObject.FindWithTag("MusicManager");
        music = musicObjectDelete.GetComponent<GameMusic>();
        panelSettings.SetActive(false);
   }

    public void Gamelevel()
    {
        SceneManager.LoadScene("MapScene");
    }

    public void ControlsMenu()
    {
        SceneManager.LoadScene("Controls");
    }
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    
    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void QuitTheGame()
    {
       music.MusicVolumeReset();

        #if UNITY_STANDALONE
        Application.Quit();
        #endif

        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }

     public void SettingsOn()
    {
         panelSettings.SetActive(true);
    }

     public void SettingsOff()
    {
         panelSettings.SetActive(false);
    }



    
   
   
}
