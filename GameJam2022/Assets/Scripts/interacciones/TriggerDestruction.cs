using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDestruction : MonoBehaviour
{

    public GameObject objetoAfectado;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            objetoAfectado.gameObject.GetComponent<Destruir>().afectado = true;
        }
    }
}
