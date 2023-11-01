using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField]private float jumpForce=800;
    private bool isGrounded;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(isGrounded && Input.GetButtonDown("Jump")){
            Jump();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        isGrounded=true;
    }
    private void OnCollisionExit2D(Collision2D other) {
        isGrounded=false;
    }
    public void Jump(){
        rb.AddForce(Vector2.up * jumpForce);
        //rb.velocity=new Vector2(rb.velocity.x, jumpForce*Time.deltaTime);
    }
}
