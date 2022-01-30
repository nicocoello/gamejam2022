using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Liberar : MonoBehaviour
{
    public bool player1 = false;
    public bool player2 = false;
    public bool key1 = false;
    public bool key2 = false;
    public GameObject keyState=null;

    // Start is called before the first frame update
    void Start()
    {
        if (keyState)
        {
            key1 = keyState.gameObject.GetComponent<EstadoLlaves>().key1;
            key2 = keyState.gameObject.GetComponent<EstadoLlaves>().key2;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if ((player1 && player2)&&(key1 && key2))
        {
            Destroy(gameObject, .5f);
        }
    }
}
