using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public bool dead;
    public int currentSceneIndex;
    // Start is called before the first frame update
    void Start()
    {
        dead = false;
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("SavedScene", currentSceneIndex);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (!dead)
        {
            if (collision.GetComponent<Enemy>())
            {
               // Destroy(transform.parent.gameObject);
                Die();
            }

            if (collision.gameObject.tag == "Death")
            {
                SceneManager.LoadScene("Lose");
            }
        }

       

    }

    public void Die()
    {
        dead = true;
        
        SceneManager.LoadScene("Lose");
    }
}
