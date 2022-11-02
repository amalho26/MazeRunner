using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject pause;
    public bool isPaused = false;
    // Start is called before the first frame update
    public void PauseFunction()
    {
        pause.SetActive(true);
        isPaused = true;
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        pause.SetActive(false);
        isPaused = false;
        Time.timeScale = 1f;
    }

    public void MainMenu()
    {
        Debug.Log("Loading Main Menu");
       Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
        Debug.Log("Main Menu");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            PauseFunction();
        }
    }
}
