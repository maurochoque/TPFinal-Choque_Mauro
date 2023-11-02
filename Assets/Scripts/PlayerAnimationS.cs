using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetAxis("Horizontal") != 0){
        animator.SetBool("isRunning", true);
       } 
       else{
        animator.SetBool("isRunning", false);
       }
    }
    private void OnCollisionEnter2D(Collision2D collision){
        animator.SetBool("isJumping", false);
    }

    private void OnCollisionExit2D(Collision2D collision){
        animator.SetBool("isJumping", true);
    }
}
