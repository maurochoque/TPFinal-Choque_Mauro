/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Ganador : MonoBehaviour
{
    
    public string ganador="Ganaste";
    private bool bandera=false;
    private void Start()
    {
        // Recupera el puntaje almacenado en PlayerPrefs
        int puntaje = PlayerPrefs.GetInt("Puntaje", 0);
        Debug.Log(puntaje);
        if(puntaje==30 && bandera==false){
            puntaje=0;
            if(puntaje==30){
            SceneManager.LoadScene(ganador);
            }
        }
    }
}*///Para mejorar usando Principios de responsabilidada unica

