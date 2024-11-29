using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rigidbody2d;

    Vector3 mousePositionScreen;
    Vector3 mousePositionWorldSpace;

    Vector2 initPosition;

    private void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        initPosition = transform.position;
    }

    private void Update()
    {
        mousePositionScreen = Input.mousePosition;

        mousePositionWorldSpace = Camera.main.ScreenToWorldPoint(mousePositionScreen);
    }

    private void FixedUpdate()
    {
        Vector2 newPlayerPosition = new Vector2(mousePositionWorldSpace.x, mousePositionWorldSpace.y);
        rigidbody2d.MovePosition(newPlayerPosition);
    }



private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Alien")
        {
            transform.position = initPosition;
        }
        else if (collision.transform.tag == "Fin")
        {

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
    }
}
