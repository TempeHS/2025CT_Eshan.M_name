using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    private float speed = 8f;
    private float jumoingPower = 16f;
    private bool isfaceingRight = true;


    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    // Update is called once per frame
    void Update()
    {
    horizontal = Input.GetAxisRaw("Horizontal");
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed,rb.velocity.y);
    }

    private void Flip()

    {
    if (isFacingRight && horizontal < 0f || !isfaceingRight && horizontal > 0f)
        {
            isFaceingRight = !isFaceingRight;
            Vector3
        }

    }
}
