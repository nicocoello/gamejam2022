using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoLlaves : MonoBehaviour
{
    public static EstadoLlaves estado;
    public bool key1 = false;
    public bool key2 = false;

    void Awake()
    {
        if(estado == null)
        {
            estado = this;
            DontDestroyOnLoad(gameObject);
        }else if (estado != this)
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
