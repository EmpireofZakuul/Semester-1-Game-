using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public int currentSceneIndex;
    public AudioSource win;
    // Start is called before the first frame update
    void Start()
    {
        win = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        
            if (collision.gameObject.tag == "Player")
            {
                win.Play();
                currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
                PlayerPrefs.SetInt("SavedScene", currentSceneIndex);
                SceneManager.LoadScene("Win");
            }
    }
}
