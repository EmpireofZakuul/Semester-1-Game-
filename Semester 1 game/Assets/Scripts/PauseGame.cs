using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public static bool gameIsPaused;
    public GameObject playButton;
    public GameObject pauseButton;
     public GameObject pausePanel;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        playButton.SetActive(false);
        pauseButton.SetActive(true);
         pausePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameIsPaused = !gameIsPaused;
            PauseTheGame();

        }
        */
    }

   public void GamePaused()
    {      
            Time.timeScale = 0f;
            playButton.SetActive(true);
            pauseButton.SetActive(false);  
            pausePanel.SetActive(true);
       
    }
   public void PlayGame()
    {
        Time.timeScale = 1f;
        playButton.SetActive(false);
        pauseButton.SetActive(true);
        pausePanel.SetActive(false);

    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    /*void PauseTheGame()
    {
        if (gameIsPaused)
        {
            Time.timeScale = 0f;
            playButton.SetActive(true);
            pauseButton.SetActive(false);

        }
        else
        {
            Time.timeScale = 1f;
            playButton.SetActive(false);
            pauseButton.SetActive(true);
        }
    }
    */
}
