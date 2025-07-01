using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class CactusScript : MonoBehaviour
{
    public GameObject cactus;
    public float spawnRate = 3;
    private float timer = 0;
    public float timeOffset = 5;

    // Start is called before the first frame update
    void Start()
    {
        spawnCactus();
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
            spawnCactus();
            timer = 0;
        }
    }

    void spawnCactus()
    {
        float minTime = transform.position.x - timeOffset;
        float maxTime = transform.position.x + timeOffset;

        Instantiate(cactus, new Vector3(Random.Range(minTime, maxTime), 0, transform.position.y), transform.rotation);
    }
}
