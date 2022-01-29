using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkPlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    bool grounded;
    private Rigidbody2D body;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

        if (Input.GetKey(KeyCode.UpArrow)&& grounded)
            Jump();

        if(grounded && Mathf.Round(this.transform.rotation.z) != 0)
        {
            Debug.Log("rotado");
            this.transform.SetPositionAndRotation(new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z),new Quaternion(0,0,0,0));
        }
    }

    private void Jump()
    {
        body.velocity = new Vector2(body.velocity.x, speed);
        grounded = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            grounded = true;
    }

}