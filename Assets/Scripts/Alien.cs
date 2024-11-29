using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien : MonoBehaviour
{
    public bool moveLeft=false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {        
        if (transform.position.x >= 10 ) 
        {
            moveLeft = true;
        }
        else if (transform.position.y >= 10 ) 
        { 
            moveLeft = false; 
        }
        
        if (moveLeft )
        {
            transform.position = new Vector2(transform.position.x - 0.01f, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x + 0.01f, transform.position.y);
        }
    }
}
