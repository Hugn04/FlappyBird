using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpForce = 5f; // Lực nhảy
    private Rigidbody2D rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Kiểm tra nếu nhấn phím nhảy (mặc định là Space)
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    void Jump()
    {
        // Áp dụng lực nhảy lên Rigidbody2D
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

   
}
