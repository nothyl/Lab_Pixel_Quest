using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEditor;
using UnityEngine;

public class GeoController : MonoBehaviour

{

    private Rigidbody2D rb;
    public int speed = 5;

    // Start is called before the first frame update
    //private void OnTriggerEnter2D(Collider2D collision);
    //{Debug.log("Hit");}
void Start()
    {
        rb= GetComponent <Rigidbody2D>();

    }
    

    // Update is called once per frame
    void Update()
    {
            

        float xinput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2 (xinput * speed, rb.velocity.y);
        if (Input.GetKeyDown(KeyCode.W))
        { 
            transform.position += new Vector3(0, 1, 0); 
        }
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.velocity = new Vector2(-1, -rb.velocity.y);
        }

        if (Input.GetKeyDown(KeyCode.S))
        { 
            transform.position += new Vector3(0, -1, 0); 
        }
        
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity = new Vector2(1, -rb.velocity.y);
        }
        }
        }