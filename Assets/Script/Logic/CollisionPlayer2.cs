using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionPlayer2 : MonoBehaviour
{
    public GameObject person;
    public STOcontador contador;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Jaula")
        {
            Destroy(person);

            contador.contador++;

            if (contador.contador == 10)
            {
                SceneManager.LoadScene("FinalAnimalitos");
            }
        }
    }


}
