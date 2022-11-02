using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject myPlayer;

    //private because the value gets set here in the script and not in the editor 
    private Vector3 _offset;

    // Start is called before the first frame update
    void Start()
    {
        //this finds the immediate difference between the ball and the camera (the offset)
        _offset = transform.position - myPlayer.transform.position;
        
    }

    // LateUpdate is called once per frame but it is guaranteed to run after all items are processed (after a player moves)
    void LateUpdate()
    {
        //as we move the player, the camera is moved to a new position alligned with the object 
        transform.position = myPlayer.transform.position + _offset; 
        
    }
}
