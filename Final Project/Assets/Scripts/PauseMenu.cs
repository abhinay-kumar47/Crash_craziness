using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PauseMenu : MonoBehaviour
{
    private bool isPaused = false;
    public Button pauseButton; // Reference to the pause button in the UI

    void Start()
    {
        pauseButton.onClick.AddListener(TogglePlayPause);
    }

    public void TogglePlayPause()
    {
        if (isPaused)
        {
            // Resume game
            Time.timeScale = 1f;
            isPaused = false;
            //Debug.Log("Game Resumed");
        }

        else
        {
            // Pause game
            Time.timeScale = 0f;
            isPaused = true;
            ///Debug.Log("Game Paused");
        }
    }

    void Update()
    {
        // Check for input to toggle between play and pause
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TogglePlayPause();
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("GamePlay");
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("The Player has Exited the Game.");
    }

    public void StartMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
