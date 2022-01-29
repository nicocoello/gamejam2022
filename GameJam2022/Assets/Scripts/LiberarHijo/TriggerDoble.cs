using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoble : MonoBehaviour
{
    public GameObject objetoAfectado;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (!objetoAfectado.gameObject.GetComponent<Liberar>().player1)
            {
                objetoAfectado.gameObject.GetComponent<Liberar>().player1 = true;
            }
            else
            {
                objetoAfectado.gameObject.GetComponent<Liberar>().player2 = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            objetoAfectado.gameObject.GetComponent<Liberar>().player1 = false;
        }
    }
}
