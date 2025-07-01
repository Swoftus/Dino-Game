using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public LogicScript logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.velocity = Vector2.up * 9;
        }
    }

    void FixedUpdate()
    {
        //if (!isGrounded && transform.position.y <= startingY)
        //{
        //    // Only correct the Y once
        //    transform.position = new Vector3(transform.position.x, startingY, transform.position.z);

        //    // Stop any downward movement
        //    myRigidbody.velocity = Vector2.zero;

        //    isGrounded = true;
        //}
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Cactus"))
        {
            logic.gameOver();
            Time.timeScale = 0;
        }
        
    }
}
