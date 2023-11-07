using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Ganador : MonoBehaviour
{
    //public Text puntajeText;
    public string ganador="Ganaste";

    private void Start()
    {
        // Recupera el puntaje almacenado en PlayerPrefs
        int puntaje = PlayerPrefs.GetInt("Puntaje", 0);
        Debug.Log(puntaje);
        if(puntaje==30){
            puntaje=0;
            if(puntaje==30){
            SceneManager.LoadScene(ganador);
            }
        }
        // Muestra el puntaje en un Text en la escena "EscenaGanador"
        //puntajeText.text = "Puntaje: " + puntaje;
    }
}

