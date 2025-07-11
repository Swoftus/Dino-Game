using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BannerScript : MonoBehaviour
{

    public float moveSpeed = 5;
    private float deadZone = -60;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
        
    }
}
