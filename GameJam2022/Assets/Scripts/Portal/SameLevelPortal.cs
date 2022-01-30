using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SameLevelPortal : MonoBehaviour
{
    //[SerializeField] private Transform blueplayerPos;
    //[SerializeField] private Transform pinkplayerPos;
    [SerializeField] private GameObject destinyPos;
    public string currentLevel;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            collision.gameObject.transform.position = destinyPos.transform.position;
        }
    }
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.R))
        {
            Application.LoadLevel(currentLevel);
        }
    }
}
