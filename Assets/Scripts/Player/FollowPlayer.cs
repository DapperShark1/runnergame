using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    // How offset the camera should be from the player
    public Vector3 offset;
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Set camera to the player position plus on offset
        if(player){
            transform.position = player.transform.position + offset;
        }
    }
}
