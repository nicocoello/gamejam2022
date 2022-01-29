using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverObjeto : MonoBehaviour
{

    public bool arriba = false;
    public bool abajo = false;
    public bool izquierda = false;
    public bool derecha = false;
    public float velocidad = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (arriba)
        {
            this.transform.Translate(0,velocidad,0);
        }
        else
        {
            this.transform.Translate(0, 0, 0);

        }
        if (abajo)
        {
            this.transform.Translate(0, -velocidad, 0);
        }
        else
        {
            this.transform.Translate(0, 0, 0);

        }
        if (izquierda)
        {
            this.transform.Translate(-velocidad, 0, 0);
        }
        else
        {
            this.transform.Translate(0, 0, 0);

        }
        if (derecha)
        {
            this.transform.Translate(velocidad, 0, 0);
        }
        else
        {
            this.transform.Translate(0, 0, 0);

        }
    }
}
