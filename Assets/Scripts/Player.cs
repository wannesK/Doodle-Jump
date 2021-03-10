using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    public float movementSpeed = 10f;

    private float movement = 0f;
    private Rigidbody2D rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement = Input.GetAxis("Horizontal") * movementSpeed;

    }
    private void FixedUpdate()
    {
        Vector2 velocity = rigid.velocity;
        velocity.x = movement;
        rigid.velocity = velocity;
    }
}
