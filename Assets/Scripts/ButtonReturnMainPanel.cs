using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMainMenu : MonoBehaviour
{
    public string mainMenuSceneName = "MenuInicio"; // Nombre de la escena del menú principal.

    public void ReturnToMain()
    {
        SceneManager.LoadScene(mainMenuSceneName);
    }
}

