using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{   
    private int score = 0;
    public TextMeshProUGUI scoreUI;

    // Update is called once per frame
    void Update()
    {
        scoreUI.text = "Score: "+score.ToString();
    }

    void OnTriggerEnter(Collider other)
    {   
        UnityEngine.Debug.Log("Collider is working.");

        if (other.gameObject.tag == "Coin")
        {   
            score +=5;
        }

        if (other.gameObject.tag == "Energy")
        {
            score +=2;
        }

        if (other.gameObject.tag == "Obstacle")
        {
            score -=1;
        }

    }


}
