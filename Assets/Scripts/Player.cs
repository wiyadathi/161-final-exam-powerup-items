using UnityEngine;

public class Player : MonoBehaviour
{
    // Encapsulation: Private Backing Field
    private float _moveSpeed = 5f;
    private bool _isInvulnerable = false;
    private float _jumpForce = 10f; // ค่ากระโดดพื้นฐาน

    private Rigidbody2D rb;

    // Public Properties (Public Getter, Private Setter)
    public float MoveSpeed { get => _moveSpeed; private set => _moveSpeed = value; }
    public bool IsInvulnerable { get => _isInvulnerable; private set => _isInvulnerable = value; }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 1. Movement
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(moveInput * MoveSpeed, rb.linearVelocity.y);

        // 2. Jump (No Ground Check Required)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, _jumpForce);
        }
    }

    // 3. Collection Logic (OnTriggerEnter2D)
    private void OnTriggerEnter2D(Collider2D other)
    {
/*        PowerUpBase item = other.GetComponent<PowerUpBase>();
        if (item != null)
        {
            // Polymorphism: เรียก Apply ผ่าน Abstract Class Reference
            item.Apply(this);

            // ทำลายไอเทม (Requirement C)
            Destroy(other.gameObject);
        }*/
    }

    // 4. Encapsulation Control (Public Setters for Items)
    public void SetMoveSpeed(float newSpeed)
    {
        MoveSpeed = newSpeed;
        Debug.Log($"Speed changed to: {MoveSpeed}");
    }

    public void SetInvulnerability(bool isEnabled)
    {
        IsInvulnerable = isEnabled;
        Debug.Log($"Invulnerability set to: {IsInvulnerable}");
    }
}
