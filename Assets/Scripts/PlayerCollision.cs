using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//
public class PlayerCollision : MonoBehaviour
{
  
    public string nextSceneName = "Perdiste";//
    private void OnCollisionEnter2D(Collision2D collision)
{
    // Maneja colisiones físicas
    if (collision.gameObject.CompareTag("Enemy"))
    {
        Destroy(gameObject);
        SceneManager.LoadScene(nextSceneName);
        

    }
    if (collision.gameObject.CompareTag("ObstaculosPuas"))
    {
        Destroy(gameObject);
        SceneManager.LoadScene(nextSceneName);

    }
    
}

    private void OnTriggerEnter2D(Collider2D other) {
         // Maneja colisiones basadas en desencadenadores de los enemigos
        if (other.CompareTag("Enemy2"))
        {
            
            Destroy(gameObject);
            SceneManager.LoadScene(nextSceneName);//
            // El enemigo ha colisionado con un proyectil
            // Puedes realizar acciones relacionadas con el proyectil
        }

        if (other.CompareTag("Enemy3"))
        {
            
            Destroy(gameObject);
            SceneManager.LoadScene(nextSceneName);//
            // El enemigo ha colisionado con un proyectil
            // Puedes realizar acciones relacionadas con el proyectil
        }
        
    }
    
}
