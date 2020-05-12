using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rgb2d;
    private Vector3 change;

    // Start is called before the first frame update
    private void Start()
    {
        rgb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
        if (change != Vector3.zero)
        {
            MoveCharacter();
        }
    }

    private void MoveCharacter()
    {
        rgb2d.MovePosition(transform.position + change * speed * Time.fixedDeltaTime);
    }
}