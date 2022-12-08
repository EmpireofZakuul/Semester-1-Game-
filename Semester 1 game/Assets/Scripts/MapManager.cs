using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapManager : MonoBehaviour
{
    public GameObject level1PopUp;
    public GameObject level2PopUp;
    public GameObject level3PopUp;

    // Start is called before the first frame update
    void Start()
    {
        level1PopUp.SetActive(false);
        level2PopUp.SetActive(false);
        level3PopUp.SetActive(false);
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

    public void PopUpLevel1()
    {
        level1PopUp.SetActive(true);
    }
    public void PopUpLevel2()
    {
        level2PopUp.SetActive(true);
    }
    public void PopUpLevel3()
    {
        level3PopUp.SetActive(true);
    }

    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }
    public void returnToMap()
    {
        level1PopUp.SetActive(false);
        level2PopUp.SetActive(false);
        level3PopUp.SetActive(false);
    }
}
