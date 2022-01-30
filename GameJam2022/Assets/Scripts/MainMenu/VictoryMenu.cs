using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryMenu : MonoBehaviour
{
    [SerializeField] AudioSource buttonAudio;
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void OnClick()
    {
        buttonAudio.Play();
    }
}
