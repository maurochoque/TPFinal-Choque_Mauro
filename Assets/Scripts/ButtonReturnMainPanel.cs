using UnityEngine;
using UnityEngine.SceneManagement;


//Script para el boton que reinicia el juego cuando perdemos o ganamos
public class ReturnToMainMenu : MonoBehaviour
{
    // Nombre de la escena del menu principal.
    public string mainMenuSceneName = "MenuInicio"; 
    //Funcion que carga la escena MenuInicial
    public void ReturnToMain()
    {
        SceneManager.LoadScene(mainMenuSceneName);
    }
}

