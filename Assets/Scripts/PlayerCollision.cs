using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//
public class PlayerCollision : MonoBehaviour
{
  
    public string nextSceneName = "Perdiste";//

    //Funcion para colision con elementos fisicos  
    private void OnCollisionEnter2D(Collision2D collision)
{
    // Maneja colisiones físicas segun Tag (etiqueta) del GameObject
    if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("ObstaculosPuas") )
    {
        Destroy(gameObject);
        SceneManager.LoadScene(nextSceneName);
    }
    
}
    // Funcion para colisiones con Trigger
    private void OnTriggerEnter2D(Collider2D other) {

        if (other.CompareTag("Enemy2") || other.CompareTag("Enemy3"))// ||alt 124
        {
            
            Destroy(gameObject);
            SceneManager.LoadScene(nextSceneName);//
           
        } 
    }
    
}
