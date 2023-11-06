using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_run : MonoBehaviour 
{
    public float moveSpeed;
    public float speed;
    public float jumpForce;

    public bool isGrounded;
    public bool isJumping;

    public Transform groundCheckLeft;
    public Transform groundCheckRight;


    public Rigidbody2D rb;
    private Vector3 velocity = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position + new Vector3(speed * Time.deltaTime, 0, 0);
        transform.position = newPosition;

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            isJumping = true;
        }
    }

    void FixedUpdate()
    {

        isGrounded = Physics2D.OverlapArea(groundCheckLeft.position, groundCheckRight.position);


        float horizontalMovement = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;

        //if (Input.GetButtonDown("Jump") && isGrounded){
        //    isJumping = true;
        //}

        MovePlayer(horizontalMovement);

    }

    void MovePlayer(float _horizontalMovement)
    {

        Vector3 targetVelocity = new Vector2(_horizontalMovement, rb.velocity.y);
        rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, .05f);

        if (isJumping == true)
        {
            rb.AddForce(new Vector2(0f, jumpForce));
            isJumping = false;
        }
    }
}
