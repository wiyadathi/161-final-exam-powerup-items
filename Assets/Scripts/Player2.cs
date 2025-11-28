using UnityEngine;

public class Player2 : MonoBehaviour
{
    // public Fields
    private float moveSpeed = 5f;
    private float jumpForce = 10f; // ค่ากระโดดพื้นฐาน

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 1. Movement (left-right using A/D/arraw keys)
        float moveInput = Input.GetAxisRaw("Horizontal");
        // move left-right based on MoveSpeed
        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);

        // 2. Jump (No Ground Check Required)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }


}
