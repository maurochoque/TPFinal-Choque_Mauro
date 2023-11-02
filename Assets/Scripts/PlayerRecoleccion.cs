using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollector : MonoBehaviour
{
    //private int score = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica si el objeto colisionado tiene la etiqueta "PowerUp"
        if (other.CompareTag("Premio"))
        {
            // Incrementa la puntuación
            //score += 10;

            // Destruye el objeto recolectible
            Destroy(other.gameObject);

            // Realiza otras acciones relacionadas con el power-up si es necesario
        }
    }
}

