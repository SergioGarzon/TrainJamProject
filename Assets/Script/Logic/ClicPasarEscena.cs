using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClicPasarEscena: MonoBehaviour
{
    void Update()
    {
        // Verifica si se ha presionado el clic derecho del rat�n
        if (Input.GetMouseButtonDown(1))
        {
            // Llama al m�todo para cambiar de escena
            CambiarEscenaMetodo();
        }
    }

    void CambiarEscenaMetodo()
    {
        // Cambia a la escena con el nombre proporcionado
        SceneManager.LoadScene("UltimaEscena");
    }
}

