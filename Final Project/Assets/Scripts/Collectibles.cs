using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{   
    // public AudioSource BackgroundMusic;
    public AudioSource coinCollect;
    public AudioSource obstacleHIT;
    public AudioSource energyCollect;


    // private void Update()
    // {
    //     BackgroundMusic.Play();
    //     if (isPaused==true)
    //     {
    //         BackgroundMusic.Pause();
    //     }
    // }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coinCollect.Play();
        }

        if (other.CompareTag("Energy"))
        {
            Destroy(other.gameObject);
            energyCollect.Play();
        }

        if (other.CompareTag("Obstacle"))
        {
            obstacleHIT.Play();
        }
        
    }

    
}

