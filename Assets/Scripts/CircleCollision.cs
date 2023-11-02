using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other){
        if(other.collider.CompareTag("Jugador1")){
            Debug.Log("chococo");
            Destroy(gameObject);
        }
    }
}
