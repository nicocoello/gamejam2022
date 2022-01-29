using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalBlue : MonoBehaviour
{
    public GameObject BluePortal;
    public GameObject PinkPortal;
    public GameObject BluePlayer;
    


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(transport());
        }
    }

    IEnumerator transport()
    {
        yield return new WaitForSeconds(0.05f);
        BluePlayer.transform.position = new Vector2(PinkPortal.transform.position.x, PinkPortal.transform.position.y);
    }

}
