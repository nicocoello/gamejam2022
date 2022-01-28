using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * https://youtu.be/Q5TMGOGT0tg?t=598
 * 
 * Esto va puesto en un objeto
 * Dentro del objeto se crea: 
 * GameObject vacio, dentro del cual
 *      UI->Canvas con render mode "world space", dentro del cual
 *              UI->Image, presionando shift en el anclaje (en cuadro de lineas rojas) seleccionamos el de la esquina inferior derecha, y ponemos todas sus propiedades en 0
 *                  UI->TextMeshPro, y repetimos lo de la imagen, tamaño de la fuente en .1, y colocamos "presiona E"
 * 
 */


public class interacciones : MonoBehaviour
{

    public GameObject Interactuar;
    public GameObject objetoAfectado;
    public bool infoHabilitada;
    public bool mostrarInfoHabilitada;
    public LayerMask personaje;
    // Start is called before the first frame update
    void Start()
    {
        Interactuar.gameObject.SetActive(false);
        objetoAfectado.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        infoHabilitada = Physics2D.OverlapCircle(this.transform.position, 1f, personaje);
        if (infoHabilitada)
        {
            Interactuar.gameObject.SetActive(true);
        }
        if (!infoHabilitada)
        {
            Interactuar.gameObject.SetActive(false);

        }

        mostrarInfoHabilitada = Physics2D.OverlapCircle(this.transform.position, 1f, personaje);

        if(mostrarInfoHabilitada && Input.GetKeyDown(KeyCode.E))
        {
            objetoAfectado.gameObject.GetComponent<Destruir>().afectado = true;
            //objetoAfectado.gameObject.SetActive(true);
        }
        //if (!mostrarInfoHabilitada)
        //{
        //    objetoAfectado.gameObject.SetActive(false);
        //}
    }
}
