using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonOption : MonoBehaviour {

    public GameObject pauseMenuCanvas;

    public void playGame()
    {
        SceneManager.LoadScene(1);
    }
    
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void quitGame()
    {
        // if (Input.GetKey("escape"))
        Application.Quit();
        
    }

    public void tuning()
    {
        SceneManager.LoadScene(2);
    }
    public void track01()
    {
        SceneManager.LoadScene(1);
    }

    public void Pause1()
    {

        pauseMenuCanvas.SetActive(true);
        Time.timeScale = 0f;

    }

    public void Resume()
    {
        pauseMenuCanvas.SetActive(false);
        Time.timeScale = 1f;
    }

}
