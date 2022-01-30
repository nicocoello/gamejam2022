using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerVictory : MonoBehaviour
{
    [SerializeField] AudioSource winAudio;
    [SerializeField] AudioSource levelAudio;
    public string level;    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            levelAudio.Pause();
            winAudio.Play();
            Invoke("ChangeLevel", 1);        
        }
    }
    void ChangeLevel()
    {
        Application.LoadLevel(level);
    }
}

