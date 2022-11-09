using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseScreen : MonoBehaviour {
    
    public static bool gamePaused = false;

    public GameObject pauseMenu;
    public GameObject playerView;
    
    void Update() {
        if (Input.GetKeyDown(KeyCode.P)) {
            if (gamePaused) {
                Resume();
            } else {
                Pause();
            }
        } 
    }

    void Pause() {
        pauseMenu.SetActive(true);
        playerView.SetActive(false);
        Time.timeScale = 0.1f;
        gamePaused = true;
    }

    void Resume() {
        pauseMenu.SetActive(false);
        playerView.SetActive(true);
        Time.timeScale = 1.0f;
        gamePaused = false;
    }

    public void Restart() {
        Time.timeScale = 1.0f;
        gamePaused = false;
        SceneManager.LoadScene("kitchentest");
        Debug.Log("Restart Game");
    }

    public void Quit() {
        Time.timeScale = 1.0f;
        gamePaused = false;
        Application.Quit();
        Debug.Log("Exit Game");
    }
}
