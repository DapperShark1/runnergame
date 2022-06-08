using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour
{
    // Start is called before the first frame update
    // The time between the end of one blink and the start of the next
    public float timeToWait = 1.0f;
    // The amount at which the shape changes per frame
    public Vector3 scaleChange;
    // The time left in the current blink
    private float timeLeft;
    void Start()
    {
        timeLeft = timeToWait;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;

        if(timeLeft <= 0 && transform.localScale.y > 0.05f){ // Change the eye objects size once there's no time left
            transform.localScale -= scaleChange;
        } else if(transform.localScale.y < 0.25f){ // Reset timeLeft and scale the eye back to its original size
            transform.localScale += scaleChange;
            timeLeft = timeToWait;
        }
    }
}
