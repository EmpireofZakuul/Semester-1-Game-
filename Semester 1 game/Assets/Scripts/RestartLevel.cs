using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    private int restartLevelScene;
   /* public int currentSceneIndex;
    void Awake()
    {
        GameObject[] levelRestart = GameObject.FindGameObjectsWithTag("SceneManager");

        if (levelRestart.Length > 1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }

    }
   */
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Restart()
    {
        // currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        // PlayerPrefs.SetInt("SavedScene", currentSceneIndex);

        restartLevelScene = PlayerPrefs.GetInt("SavedScene");

        if(restartLevelScene != 0)
        {
            SceneManager.LoadScene(restartLevelScene);
        }
        else
        {
            return;
        }
    }
    
}
