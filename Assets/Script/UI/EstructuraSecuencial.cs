using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class EstructuraSecuencial : MonoBehaviour
{
    public Text textoUI;
    private string textoCompleto;
    public float velocidadEscritura = 0.1f;

    private void Start()
    {
        textoCompleto = "'Que un elefante ocupa mucho espacio lo sabemos todos. Pero un elefante de circo se decidio una vez a pensar 'en elefante', esto es a tener una idea tan enorme como su cuerpo... Ah, eso algunos lo sabe.'";

        // Inicia la escritura secuencial cuando se carga el script
        StartCoroutine(EscribirTextoSecuencial());
    }

    IEnumerator EscribirTextoSecuencial()
    {
        // Asegúrate de que el Texto no sea nulo
        if (textoUI == null)
        {
            Debug.LogError("TextoUI no asignado en el Inspector.");
            yield break;
        }

        // Asegúrate de que el TextoCompleto no sea nulo o vacío
        if (string.IsNullOrEmpty(textoCompleto))
        {
            Debug.LogError("TextoCompleto no especificado.");
            yield break;
        }

        // Limpia el Texto antes de empezar a escribir
        textoUI.text = "";

        // Itera a través de cada letra en el texto completo
        for (int i = 0; i < textoCompleto.Length; i++)
        {
            // Agrega la letra actual al texto del UI
            textoUI.text += textoCompleto[i];

            // Espera un tiempo antes de agregar la siguiente letra
            yield return new WaitForSeconds(velocidadEscritura);
        }
    }
}

