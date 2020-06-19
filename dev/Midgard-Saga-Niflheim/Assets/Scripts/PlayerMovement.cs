using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rb;
    public Vector2 movement;

    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        HandleInput();
    }

    private void FixedUpdate()
    {
        MoveCharacter(movement);
    }

    private void HandleInput()
    {
        movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
    }

    private void MoveCharacter(Vector2 direrction)
    {
        rb.MovePosition((Vector2)transform.position + (direrction * speed * Time.deltaTime));
    }
}