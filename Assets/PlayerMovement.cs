using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;

public class NewBehaviourScript : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;

    private Vector2 movement;
    public Vector3 mousePos;



    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
    }

    void FixedUpdate()
    {
        Move();
    }
    void ProcessInputs()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        Vector2 dir = new Vector2(mousePos.x - transform.position.x, mousePos.y - transform.position.y);
        transform.up = dir;

        //mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        

    }

    void Move()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        //Vector2 lookDir = mousePos - rb.position;
        //float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        //rb.rotation = angle;
    }


}
