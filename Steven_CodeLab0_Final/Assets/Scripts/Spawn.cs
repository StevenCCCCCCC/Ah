using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Obstacle;//connect to the obstacle gameobject 
    public float cooldown = 3f;
    float nextSpawn;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + cooldown;

            Vector3 spawnP = transform.position;
            spawnP.y += Random.Range(-1.5f, 3.5f);
            Instantiate(Obstacle, spawnP, transform.rotation);
        }
    }
}
