using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollector : MonoBehaviour
{
    public string nivel2 = "EscenaPrincipal2";
    public string ganador="Ganaste";
   
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica si el objeto colisionado tiene la etiqueta "PowerUp"
        if (other.CompareTag("Premio"))
        {   
            // Destruye el objeto recolectable
            Destroy(other.gameObject);
            SceneManager.LoadScene(nivel2);
            
        }

        if (other.CompareTag("PremioFinal"))
        {
            SceneManager.LoadScene(ganador);
            // Destruye el objeto recolectable
            Destroy(other.gameObject);
            
        }
    }
}

