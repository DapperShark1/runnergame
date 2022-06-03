using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5.0f;

    public float horizontalInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move player horizontally based on horizontal Input
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
    }
}
