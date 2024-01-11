using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Global declarations
    private float currentSpeed = 0f;
    private float turnSpeed = 10.0f; 
    private float horizontalInput; 
    private float forwardInput; 
    private float speedIncreasePerSecond = 5f;
    public float maxSpeed = 100f;
    public float decelerationRate = 2f;
    // public AudioSource crashPlayer;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //We will move the car forward
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput    = Input.GetAxis("Vertical");
        currentSpeed += speedIncreasePerSecond * Time.deltaTime;

        if (Input.GetAxis("Vertical") == 0f || IsTurning()) 
        {
            currentSpeed = Mathf.Lerp(currentSpeed, 0f, Time.deltaTime * decelerationRate);
        }
        else 
        {
            currentSpeed = Mathf.Lerp(currentSpeed, maxSpeed, Time.deltaTime);
        }

        transform.Translate(Vector3.forward * Time.deltaTime * currentSpeed * forwardInput);
        transform.Rotate(Vector3.up,turnSpeed * horizontalInput * Time.deltaTime);
        
    }

    bool IsTurning() 
    {
        // Implement logic to determine if the vehicle is turning
        return false;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player"){
            //crashPlayer.Play();
            //Destroy.Log(gameObject);
        }
    }

    
}
