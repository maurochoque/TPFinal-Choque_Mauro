using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    [SerializeField] private float movementSpeed=9.5f;
    //Variable si esta mirando a la derecha es true
    private bool isFacingRight=true;
    //Se instancia un Objeto de la clase Rigidbody2D en rb
    private Rigidbody2D rb;
    void Start()
    {
        //El componente Rigidbody2D se guarda en rb y podemos usar sus propiedades 
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
    //Funcion que recibe como parametro un float
    public void Move(float velocity){
        
        transform.Translate(Vector3.right*velocity*Time.deltaTime);
        
    }
    
    public void Flip(){
        
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        isFacingRight = !isFacingRight;
    }
}
