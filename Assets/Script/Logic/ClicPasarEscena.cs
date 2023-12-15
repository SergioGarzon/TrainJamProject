using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClicPasarEscena: MonoBehaviour
{
    void Update()
    {
        // Verifica si se ha presionado el clic derecho del ratón
        if (Input.GetMouseButtonDown(1))
        {
            // Llama al método para cambiar de escena
            CambiarEscenaMetodo();
        }
    }

    void CambiarEscenaMetodo()
    {
        // Cambia a la escena con el nombre proporcionado
        SceneManager.LoadScene("UltimaEscena");
    }
}

