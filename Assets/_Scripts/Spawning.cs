using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public GameObject pickUpPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(pickUpPrefab);

    }

   
}
