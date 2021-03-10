using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float jumpForce = 11f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rigidbody2D = collision.collider.GetComponent<Rigidbody2D>();

            if (rigidbody2D != null)
            {
                Vector2 velocity = rigidbody2D.velocity;
                velocity.y = jumpForce;
                rigidbody2D.velocity = velocity;
            }
        }        
    }
}
