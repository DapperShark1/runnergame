using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour
{
    // Start is called before the first frame update
    public float timeToWait = 1.0f;
    public Vector3 scaleChange;
    private float timeLeft;
    void Start()
    {
        timeLeft = timeToWait;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;

        if(timeLeft <= 0 && transform.localScale.y > 0.05f){
            transform.localScale -= scaleChange;
        } else if(transform.localScale.y < 0.25f){
            transform.localScale += scaleChange;
            timeLeft = timeToWait;
        }
    }
}
