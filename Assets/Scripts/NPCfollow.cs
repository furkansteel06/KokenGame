using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCfollow : MonoBehaviour
{
    public float speed;
    public float targetPosition;
    public Transform playerTransform;
    Rigidbody2D myrb2D;
    Animator myanime;
    Transform target;

    private void Start()
    {
        myrb2D = GetComponent<Rigidbody2D>();
        myanime = GetComponent<Animator>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    private void FixedUpdate()
    {
        targetFollow();

        Vector3 playerScale = transform.localScale;
        if (Input.GetAxis("Horizontal") < 0)
        {
            playerScale.x = -2.9f;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            playerScale.x = 2.9f;
        }
        transform.localScale = playerScale;
    }

    void targetFollow()
    {
        if (Vector2.Distance(transform.position, target.position) > targetPosition)
        {
            myanime.SetBool("Running", true);
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        else
        {
            myanime.SetBool("Running", false);
        }
    }
}
