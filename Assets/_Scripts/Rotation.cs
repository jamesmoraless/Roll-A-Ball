using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
   
    // Update is called once per frame
    void Update()
    {
        //to rotate the transform 
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
        
    }
}
