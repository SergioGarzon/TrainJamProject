using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SimonDiceGame : MonoBehaviour
{
    public List<string> tagsObjetos; // Lista de tags de los objetos que pueden ser seleccionados
    private List<string> secuenciaSimon = new List<string>(); // Secuencia generada por Simon
    private List<string> seleccionJugador = new List<string>(); // Selección del jugador

    private bool mostrandoSecuencia; // Flag para evitar colisiones durante la muestra de la secuencia

    void Start()
    {
        // Inicia el juego
        IniciarJuego();
    }

    void IniciarJuego()
    {
        // Genera una nueva secuencia
        GenerarSecuencia();
        // Muestra la secuencia a seguir
        StartCoroutine(MostrarSecuencia());
    }

    void GenerarSecuencia()
    {
        // Genera una secuencia aleatoria de tags
        for (int i = 0; i < 5; i++)
        {
            string tagAleatoria = tagsObjetos[Random.Range(0, tagsObjetos.Count)];
            secuenciaSimon.Add(tagAleatoria);
        }
    }

    IEnumerator MostrarSecuencia()
    {
        mostrandoSecuencia = true;

        // Muestra la secuencia a seguir
        foreach (string tagObjeto in secuenciaSimon)
        {
            // Resalta el objeto de alguna manera (por ejemplo, cambiar su color)
            GameObject[] objetos = GameObject.FindGameObjectsWithTag(tagObjeto);
            foreach (var objeto in objetos)
            {
                objeto.GetComponent<Renderer>().material.color = Color.red;
            }
            yield return new WaitForSeconds(1f); // Ajusta el tiempo de espera según tus necesidades
            // Restaura el color original de los objetos
            foreach (var objeto in objetos)
            {
                objeto.GetComponent<Renderer>().material.color = Color.white;
            }
            yield return new WaitForSeconds(0.5f); // Ajusta el tiempo de espera según tus necesidades
        }

        mostrandoSecuencia = false;
    }

    // Método llamado cuando el jugador colisiona con un objeto 2D
    public void ObjetoColisionado2D(string tagObjeto)
    {
        // Evita colisiones durante la muestra de la secuencia
        if (mostrandoSecuencia)
        {
            return;
        }

        // Agrega el objeto colisionado a la lista del jugador
        seleccionJugador.Add(tagObjeto);

        // Verifica si la selección del jugador coincide con la secuencia de Simon
        if (!VerificarSeleccion())
        {
            // El jugador cometió un error
            Debug.Log("¡Incorrecto! Reiniciando el juego.");
            LimpiarSelecciones();
            IniciarJuego();
        }
        else if (seleccionJugador.Count == secuenciaSimon.Count)
        {
            // El jugador completó la secuencia correctamente
            Debug.Log("¡Correcto! Avanzando al siguiente nivel.");
            LimpiarSelecciones();
            IniciarJuego();
        }
    }

    bool VerificarSeleccion()
    {
        // Verifica si la selección del jugador coincide con la secuencia de Simon
        for (int i = 0; i < seleccionJugador.Count; i++)
        {
            if (seleccionJugador[i] != secuenciaSimon[i])
            {
                return false;
            }
        }
        return true;
    }

    void LimpiarSelecciones()
    {
        // Limpia las listas de selección
        seleccionJugador.Clear();
    }
}
