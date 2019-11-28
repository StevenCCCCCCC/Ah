using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed = 3f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GM.isActive)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player") {//if the box have some interaction with object tagged "Player"
            //Debug.Log("+1");
            GM.score += 1;
            //score+1;
        }
    }
}
