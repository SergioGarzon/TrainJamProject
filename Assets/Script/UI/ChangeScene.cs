using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    
    public void OpenScene(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
