using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapManager : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Lv1()
    {
        SceneManager.LoadScene("Level 1");
    }

      public void Lv2()
    {
        SceneManager.LoadScene("Level 2");
    }

       public void Lv3()
    {
        SceneManager.LoadScene("Level 3");
    }
}
