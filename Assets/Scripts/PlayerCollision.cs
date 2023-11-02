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
        SceneManager.LoadScene(nextSceneName);//
        Debug.Log("Colisión física con un objeto etiquetado como 'Circle'");
        // Realiza las acciones necesarias.
    }
    if (collision.gameObject.CompareTag("ObstaculosPuas"))
    {
        Destroy(gameObject);
        SceneManager.LoadScene(nextSceneName);//
        Debug.Log("Colisión física con un objeto etiquetado como 'Circle'");
        
        // Realiza las acciones necesarias.
    }
    
}

    //AGREGAR COLISIONES CON OTROS ENEMIGOS, INTERFAZ DE INICIO, PANTALLA DE PERDER/GANAR, SISTEMA DE RECOLECCION
    

    private void OnTriggerEnter2D(Collider2D other) {
         // Maneja colisiones basadas en desencadenadores de los enemigos
        if (other.CompareTag("Enemy2"))
        {
            
            Destroy(gameObject);
            // El enemigo ha colisionado con un proyectil
            // Puedes realizar acciones relacionadas con el proyectil
        }
        
    }
    
}
