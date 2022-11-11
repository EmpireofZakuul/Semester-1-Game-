using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public bool dead;
    // Start is called before the first frame update
    void Start()
    {
        dead = false;
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
                Destroy(transform.parent.gameObject);
                Die();
            }
        }

    }

    public void Die()
    {
        dead = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
