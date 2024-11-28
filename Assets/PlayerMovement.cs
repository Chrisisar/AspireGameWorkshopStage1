using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody2D RigidBody;
    public float movementSpeed;
    public float jumpForce;
    public GameObject groundCheck;
    public LayerMask groundMask;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movement = Input.GetAxis("Horizontal");

        RigidBody.linearVelocity = new Vector2(movement * movementSpeed, RigidBody.linearVelocity.y);

        //RigidBody.position = new Vector2(RigidBody.position.x + movementSpeed * movement * Time.deltaTime, RigidBody.position.y);

        bool isTouchingGround = Physics2D.OverlapCircle(groundCheck.transform.position, 0.1f, groundMask);

        if (Input.GetButtonDown("Jump") && isTouchingGround)
        {
            RigidBody.linearVelocity = new Vector2(RigidBody.linearVelocity.x, jumpForce);
        }
    }
}
