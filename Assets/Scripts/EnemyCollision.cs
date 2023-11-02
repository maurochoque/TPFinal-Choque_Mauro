using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Maneja colisiones físicas de los enemigos
        if (collision.gameObject.CompareTag("Jugador1"))
        {
            Destroy(gameObject);
        }
    }
}
