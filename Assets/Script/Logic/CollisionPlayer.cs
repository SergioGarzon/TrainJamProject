using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionPlayer : MonoBehaviour
{
    private int control;
    public GameObject panel;
    public Text txtData;
    public GameObject panel2;
    public Text txtData2;

    private MovementPlayer movPlayer;

    public GameObject objectPanel;
    private ChangeScene changeScene;


    private void Start()
    {
        control = 0;

        changeScene = objectPanel.GetComponent<ChangeScene>();

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Loro")
        {
            if(control != 0)
            {

                panel2.gameObject.SetActive(true);               

                txtData2.text = "¡Ay! Con que suspender la función... Mmm,¿, esto puede intersarle al resto,¿. ¡Me voy! Tengo mensaje que entregar.";

                StartCoroutine(dialogo2());
            }
        }

        if (other.gameObject.tag == "Animal1")
        {
            control = 1;

            panel.gameObject.SetActive(true);
            txtData.text = "¡¿Te volviste loco?! ¿De que encierro hablas?";

            StartCoroutine(dialogo3());
        }

        if (other.gameObject.tag == "Animal2")
        {
            control = 2;

            panel.gameObject.SetActive(true);
            txtData.text = "¿Cómo te quejas cuando nos dan techo y comida?";

            StartCoroutine(dialogo4());            
        }

        if (other.gameObject.tag == "Animal3")
        {
            control = 2;

            panel.gameObject.SetActive(true);
            txtData.text = "¿Libres? ¿De que?";

            StartCoroutine(dialogo5());
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Loro")
        {
            panel.gameObject.SetActive(false);
            panel2.gameObject.SetActive(false);
        }

        if (other.gameObject.tag == "Animal1")
        {
            panel.gameObject.SetActive(false);
            panel2.gameObject.SetActive(false);
        }

        if (other.gameObject.tag == "Animal2")
        {
            panel.gameObject.SetActive(false);
            panel2.gameObject.SetActive(false);
        }

        if (other.gameObject.tag == "Animal3")
        {
            panel.gameObject.SetActive(false);
            panel2.gameObject.SetActive(false);
        }

    }

    IEnumerator dialogo()
    {
        yield return new WaitForSeconds(0.5f);
    }

    IEnumerator dialogo3()
    {
        yield return new WaitForSeconds(0.5f);

        panel2.gameObject.SetActive(true);
        txtData2.text = "¿Acaso los seres humanos tolerarian que hagamos lo mismo con ellos?";

    }

    IEnumerator dialogo4()
    {
        yield return new WaitForSeconds(0.5f);

        panel2.gameObject.SetActive(true);
        txtData2.text = "¿No te das cuenta? \n Naciste en cautiverio, desplazado de tu tierra y tu familia. Solo conoces el circo y no la dicha de la alegre libertad";

    }

    IEnumerator dialogo5()
    {
        yield return new WaitForSeconds(0.5f);

        panel2.gameObject.SetActive(true);
        txtData2.text = "¿Crees que somos libres entre tus ordenes y barrotes? Libertad es poder elegir donde y cómo vivir.";


    }

    IEnumerator dialogo2()
    {
        yield return new WaitForSeconds(5f);

        changeScene.OpenScene("scene4");
    }
}
