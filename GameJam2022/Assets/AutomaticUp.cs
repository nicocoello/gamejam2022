using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nada : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y < -25)
        {
            this.gameObject.GetComponent<MoverObjeto>().arriba = true;
        }
        if(this.transform.position.y > -7.3)
        {
            this.gameObject.GetComponent<MoverObjeto>().arriba = false;
        }
    }
}
