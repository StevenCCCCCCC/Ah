using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Obstacle;//connect to the obstacle gameobject 
    public float cooldown = 3f;
    float nextSpawn;
    public float minY = -2.2f;//the mininum position of the obstacle
    public float maxY = 3.7f;//the maxinum position of the obstacle


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if it reaches the cool down time, spawn a new obstacle
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + cooldown;

            Vector3 spawnP = transform.position;
            spawnP.y += Random.Range(minY, maxY);//set the random y position of the obstacle
            Instantiate(Obstacle, spawnP, transform.rotation);//spawn the object with its position set in the scene
        }
    }
}
