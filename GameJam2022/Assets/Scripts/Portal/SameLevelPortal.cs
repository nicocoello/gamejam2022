using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SameLevelPortal : MonoBehaviour
{
    [SerializeField] private Transform blueplayerPos;
    [SerializeField] private Transform pinkplayerPos;
    [SerializeField] private Transform destinyPos;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            pinkplayerPos.transform.position = destinyPos.transform.position;
            blueplayerPos.transform.position = destinyPos.transform.position;
        }
    }
}
