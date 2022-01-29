using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkPlayerMovement : MonoBehaviour
{
     
    [SerializeField] private float speed;    
    bool grounded;
    private Rigidbody2D body;
    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();        
    }    

    private void Update()
    {
        //Movimiento
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);
        //Rotacion
        Vector3 characterScale = transform.localScale;
        if (Input.GetAxis("Horizontal") < 0)
        {
            characterScale.x = -1;
        }
        if(Input.GetAxis("Horizontal") > 0)
        {
            characterScale.x = 1;
        }
        transform.localScale = characterScale;
        //Animacion
        if (horizontalInput == 0)
        {
            anim.SetBool("IsWalking", false);
        }
        else
        {
            anim.SetBool("IsWalking", true);
        }

        if (Input.GetKey(KeyCode.UpArrow)&& grounded)
            Jump();

        if(grounded && Mathf.Round(this.transform.rotation.z) != 0)
        {
            this.transform.SetPositionAndRotation(new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z),new Quaternion(0,0,0,0));
        }
        
    }

    private void Jump()
    {
        body.velocity = new Vector2(body.velocity.x, speed);        
        grounded = false;
        anim.SetBool("IsJumping", true);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            grounded = true;
        anim.SetBool("IsJumping", false);
    }

}