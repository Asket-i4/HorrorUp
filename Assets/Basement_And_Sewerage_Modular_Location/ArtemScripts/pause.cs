using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    public GameObject pauseMenuUI;
   // public GameObject shootstop;
    public static bool PausedGames = false;
   // public GameObject camera2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PausedGames)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        PausedGames = false;

        GameObject.Find("Main Camera").GetComponent<Faer>().enabled = true;
       // shootstop.SetActive(true);
    }
    public void Button_Work()
    {
        Debug.Log("WORK");
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        PausedGames = true;
        GameObject.Find("Main Camera").GetComponent<Faer>().enabled = false;
      //  shootstop.SetActive(false);
        
    }
}
