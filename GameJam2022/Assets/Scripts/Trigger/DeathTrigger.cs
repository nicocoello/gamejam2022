using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour
{
    [SerializeField] private GameObject pinkPlayerPos;
    [SerializeField] private GameObject bluePlayerPos;
    [SerializeField] private GameObject destinyPos;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            pinkPlayerPos.transform.position = destinyPos.transform.position;
            bluePlayerPos.transform.position = destinyPos.transform.position;
        }
    }
}
