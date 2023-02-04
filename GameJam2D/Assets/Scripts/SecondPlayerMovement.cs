using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondPlayerMovement : MonoBehaviour
{
    private float horizontal;
    private float speed = 8f;
    [SerializeField] float fallSpeed = -8f;
    [SerializeField]private float jumpinPower = 10f;
    private bool isFacingRight = true;

    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal2");
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Jump(jumpinPower);
        }
        
        if (Input.GetKeyDown(KeyCode.UpArrow) && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }
        
        if (!isGrounded())
        {
            rb.velocity -= new Vector2(rb.velocity.x, fallSpeed * Time.deltaTime);
        }
    }

    public void Jump(float power)
    {
        rb.velocity = new Vector2(rb.velocity.x, power);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private bool isGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }
    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
