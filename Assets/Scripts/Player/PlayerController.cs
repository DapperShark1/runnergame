using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5.0f;
    public float jumpPower;
    public float gravityModifier;
    public bool grounded = true;
    public float horizontalInput;

    private Rigidbody player_rigidbody;
    void Start()
    {
        player_rigidbody = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        // Move player horizontally based on horizontal Input
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        //Jump if spacebar or W is pressed 
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W) && grounded){
            player_rigidbody.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }
    }

    // Check for collision on ground so we can jump again
    private void OnCollisionEnter(Collision other) {
        grounded = true;
    }
}
