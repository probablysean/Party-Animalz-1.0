using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float speed = 4f;
    private bool faceright = true;

    public Rigidbody2D rb;
    
    Vector2 movement;
    // Update is called once per frame
    void Update()
    {
       movement.x = Input.GetAxisRaw("Horizontal");
       movement.y = Input.GetAxisRaw("Vertical");

       Flip();
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed *Time.fixedDeltaTime);
    }
    private void Flip()
    {
        if(faceright &&  movement.x < 0f || faceright && movement.x > 0f)
        {
            faceright = !faceright;
            Vector3 localScale = transform.localScale;
            localScale.x *= 1f;
            transform.localScale = localScale;
        }
    }

}
