using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollector : MonoBehaviour
{
    private int score = 0;
    public string nivel2 = "EscenaPrincipal2";
    public string ganador="Ganaste";
    //public string nextSceneName = "Perdiste";//
    private bool bandera=false;
    private bool bandera2=false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica si el objeto colisionado tiene la etiqueta "PowerUp"
        if (other.CompareTag("Premio"))
        {
            // Incrementa la puntuación
            score += 10;
            // Destruye el objeto recolectable
            Destroy(other.gameObject);
            if(score==30&&bandera==false){
                SceneManager.LoadScene(nivel2);
                bandera=true;
                PlayerPrefs.SetInt("Puntaje", score);
                
                Debug.Log("si carga");
            }
            /*if (bandera==true){  
                int puntaje = PlayerPrefs.GetInt("Puntaje", 0);
                score=puntaje;
                if(score==60){
                    SceneManager.LoadScene(ganador);
                    Debug.Log("si carga2");
                }
            }*/
            
            
        }
    }
}

