using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractuarJugador : MonoBehaviour
{
    public GameObject gameObjectInteractuar;
    private SimonDiceGame juegoSimonCollision;

    private void Start()
    {
        juegoSimonCollision = gameObjectInteractuar.GetComponent<SimonDiceGame>();
    } 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verifica si el objeto con el que colisionamos tiene la etiqueta adecuada
        if (collision.gameObject.tag ==  "objeto1")
        {
            // Informa al juego SimonDice que este objeto ha sido seleccionado por el jugador
            juegoSimonCollision.ObjetoColisionado2D(collision.gameObject.tag);
        }

        if (collision.gameObject.tag == "objeto2")
        {
            // Informa al juego SimonDice que este objeto ha sido seleccionado por el jugador
            juegoSimonCollision.ObjetoColisionado2D(collision.gameObject.tag);
        }

        if (collision.gameObject.tag == "objeto3")
        {
            // Informa al juego SimonDice que este objeto ha sido seleccionado por el jugador
            juegoSimonCollision.ObjetoColisionado2D(collision.gameObject.tag);
        }

        if (collision.gameObject.tag == "objeto4")
        {
            // Informa al juego SimonDice que este objeto ha sido seleccionado por el jugador
            juegoSimonCollision.ObjetoColisionado2D(collision.gameObject.tag);
        }

        if (collision.gameObject.tag == "objeto5")
        {
            // Informa al juego SimonDice que este objeto ha sido seleccionado por el jugador
            juegoSimonCollision.ObjetoColisionado2D(collision.gameObject.tag);
        }
    }
}

