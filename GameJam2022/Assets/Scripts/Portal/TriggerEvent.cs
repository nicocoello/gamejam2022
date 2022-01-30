using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
    [SerializeField] AudioSource tpAudio;
    [SerializeField] AudioSource levelAudio;
    public string level;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            levelAudio.Pause();
            tpAudio.Play();
            Invoke("EnterPortal", 1);
        }
    }
    void EnterPortal()
    {
        Application.LoadLevel(level);
    }
}
