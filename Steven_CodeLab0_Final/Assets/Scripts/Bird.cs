using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float volume;//the volume varaible
    Rigidbody2D rb;
    float tempTime = 0;//set the temp time
    public float jumpForce = 500;//set the force of the jump
    public float coolDown = 0.2f;//set the cool down time of the jump
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();//get the rigidbody2D of the bird
    }

    // Update is called once per frame
    void Update()
    {
        volume = AudioInput.volume;//get the volume amount from AudioInput script

        if (volume > 0 && GM.isActive) {
            if (Time.time - tempTime > coolDown)
            {
                Jump();
                tempTime = Time.time;
            }
            //Only if the input frequency is bigger than the cool time, the Jump functio would be activated
        }
    }

    void Jump()
    {
        rb.AddForce(Vector2.up * jumpForce * volume);//add a force to the bird's rigid body
    }
}
