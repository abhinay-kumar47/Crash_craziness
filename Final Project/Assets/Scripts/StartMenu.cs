using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class StartMenu : MonoBehaviour
{
     //Load scene
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //SceneManager.LoadScene("Sample scene");
    }

     //Load Start Menu scene
    public void Start_menu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        //SceneManager.LoadScene("Sample scene");
    }

    //Quit game
    public void Quit()
    {
        Application.Quit();
        Debug.Log("The Player has Exited the Game.");
    }
}
