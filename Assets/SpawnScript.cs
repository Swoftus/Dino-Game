using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject banner;
    public float spawnRate = 7;
    private float timer = 0; 

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
           
    }

    void spawnPipe()
    {
        Instantiate(banner, transform.position, transform.rotation);
    }
}
