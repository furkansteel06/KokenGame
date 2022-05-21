using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    Vector2 movement;
    Animator anim;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        Vector3 moveDirec = new Vector3(movement.x, movement.y, 0);
        float magnitude = Mathf.Clamp01(moveDirec.magnitude) * speed;
        moveDirec.Normalize();


        if (moveDirec != Vector3.zero)
        {
            anim.SetBool("Running", true);
        }

        else
        {
            anim.SetBool("Running", false);
        }

        Vector3 playerScale = transform.localScale;
        if (Input.GetAxis("Horizontal") < 0)
        {
            playerScale.x = -2.7f;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            playerScale.x = 2.7f;
        }
        transform.localScale = playerScale;
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.deltaTime);
    }
}
