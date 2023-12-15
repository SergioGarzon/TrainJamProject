using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class empujarObjetos : MonoBehaviour
{
    public float fuerzaEmpuje = 10f;
    public float tiempoFrenado = 1.0f;

    private bool objetoEmpujado = false;
    private float tiempoActual;

    void Update()
    {
        if (objetoEmpujado)
        {
            tiempoActual += Time.deltaTime;

            if (tiempoActual >= tiempoFrenado)
            {
                DetenerEmpuje();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!objetoEmpujado && other.gameObject.tag == "Persona")
        {
            Rigidbody2D rb = other.GetComponent<Rigidbody2D>();

            if (rb != null)
            {
                Vector2 direccionEmpuje = (other.transform.position - transform.position).normalized;
                rb.AddForce(direccionEmpuje * fuerzaEmpuje, ForceMode2D.Impulse);

                objetoEmpujado = true;
                tiempoActual = 0f;
            }
        }
    }

    private void DetenerEmpuje()
    {
        objetoEmpujado = false;

        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = Vector2.zero;
        }
    }

    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
    }
}
