using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LlaveAgarrada : MonoBehaviour
{
    public GameObject objetoAfectado;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (!objetoAfectado.gameObject.GetComponent<EstadoLlaves>().key1)
            {
                objetoAfectado.gameObject.GetComponent<EstadoLlaves>().key1 = true;
            }
            else
            {
                objetoAfectado.gameObject.GetComponent<EstadoLlaves>().key2 = true;
            }            
        }
    }
}
