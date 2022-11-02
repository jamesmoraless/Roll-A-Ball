using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlMyPlayer : MonoBehaviour
{
    //hold a reference to the UI text component on the UI game object 
    public Text countText;
    public Text winText;

    //this variable will allow me to edit the speed of the ball (my rigid body) in the unity editor  rather than hardcoding it 
    public float speed;

    //creates a rigid body referen ce to access thre Rigidbody methods 
    private Rigidbody _rb;

    //hold our count 
    private int _count;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _count = 0;
        SetCountText();
        winText.text = "";
    }


    void FixedUpdate()
    {
        //horizontal and vertical movement
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        //creating a Vector3 object named movement that is instantiated with a horizontal and vertical movement only
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        //add 3 dimensional forces to my rigid body component (horizontal, 0 in the z component and vertical
        _rb.AddForce(movement * speed);

    }

    //Called whenever the player collides with one of our objects (when it enters a trigger)
    void OnTriggerEnter(Collider other)
    {
        //if the gameTag is named Pick up... 
        if (other.gameObject.CompareTag("Pick Up"))//in th prefab folder, my Pick up prefeab has to be taged with "Pick Up"
        {
            //deactivetes the game object 
            other.gameObject.SetActive(false);
            _count = _count + 1;//increases the value of count 
            SetCountText();
        }
        //if the gameTag is named Pick up2... 
        else if (other.gameObject.CompareTag("Pick Up2"))//in th prefab folder, my Pick up prefeab has to be taged with "Pick Up"
        {
            //deactivetes the game object 
            other.gameObject.SetActive(false);
            _count = _count + 2;//increases the value of count 
            SetCountText();
        }
        //if the gameTag is named Pick up3... 
        else if (other.gameObject.CompareTag("Pick Up3"))//in th prefab folder, my Pick up prefeab has to be taged with "Pick Up"
        {
            //deactivetes the game object 
            other.gameObject.SetActive(false);
            _count = _count + 3;//increases the value of count 
            SetCountText();
        }
    }

    void SetCountText() //this sets the count text once its called 
    {
        countText.text = "Count: " + _count.ToString();
        if (_count >= 18) //if th emax number of points are reached 
        {
            winText.text = "YOU WIN!";
            Invoke("RestartTheScene", 4);//this will happen after 2 seconds

        }
    }

    void RestartTheScene()
    {
        SceneManager.LoadScene("MyFirstGame");
    }
}

  