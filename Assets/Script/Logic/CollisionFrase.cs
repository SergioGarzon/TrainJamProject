using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class CollisionFrase : MonoBehaviour
{
    public Text txtFraseLeon;
    public Text txtFraseOso;
    public Text txtFraseTigre;
    public Text txtFrasePajaro;
    public Text txtFraseCanguro;

    private string dato;

    void Start()
    {
        dato = "";
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "objeto1")
        {
            txtFraseLeon.gameObject.SetActive(true);

            if (dato.CompareTo("1, 2, 3, 4") == 0)
            {
                dato = "1, 2, 3, 4, 5";

                StartCoroutine(dialogo3());                
            }
        }

        if (collision.gameObject.tag == "objeto2")
        {
            txtFraseCanguro.gameObject.SetActive(true);

            if (dato.CompareTo("1, 2") == 0)
            {
                dato = "1, 2, 3";

            }
        }

        if (collision.gameObject.tag == "objeto3")
        {
            txtFrasePajaro.gameObject.SetActive(true);

            if (dato.CompareTo("1, 2, 3") == 0)
            {
                dato = "1, 2, 3, 4";
            }
        }

        if (collision.gameObject.tag == "objeto4")
        {
            txtFraseTigre.gameObject.SetActive(true);

            dato = "1";
           
        }

        if (collision.gameObject.tag == "objeto5")
        {
            txtFraseOso.gameObject.SetActive(true);

            if (dato.CompareTo("1") == 0)
            {
                dato = "1, 2";

            }

            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "objeto1")
        {
            txtFraseLeon.gameObject.SetActive(false);
        }

        if (collision.gameObject.tag == "objeto2")
        {
            txtFraseCanguro.gameObject.SetActive(false);
        }

        if (collision.gameObject.tag == "objeto3")
        {
            txtFrasePajaro.gameObject.SetActive(false);
        }

        if (collision.gameObject.tag == "objeto4")
        {
            txtFraseTigre.gameObject.SetActive(false);
        }

        if (collision.gameObject.tag == "objeto5")
        {
            txtFraseOso.gameObject.SetActive(false);
        }
    }

    IEnumerator dialogo3()
    {
        yield return new WaitForSeconds(0.5f);

        SceneManager.LoadScene("UltimaEscena");

    }

}
