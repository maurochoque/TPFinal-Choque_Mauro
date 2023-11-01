using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    [SerializeField] private float movementSpeed=10;
    
    private bool isFacingRight=true;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float movementX= Input.GetAxis("Horizontal");
        Move(movementX*movementSpeed);
        if(movementX<0 && isFacingRight){
            Flip();
        }
        else if(movementX>0 && !isFacingRight){
            Flip();
        }
       
    }

    public void Move(float velocity){
        //rb.velocity= new Vector2(velocity*Time.deltaTime, rb.velocity.y);
        transform.Translate(Vector3.right*velocity*Time.deltaTime);
        
        Debug.Log("sisisi");
        
    }
    public void Flip(){
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        isFacingRight = !isFacingRight;
        /*rb.velocity = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        isFacingRight= !isFacingRight;*/
    }
}
