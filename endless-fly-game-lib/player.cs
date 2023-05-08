using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed;
     Vector3 movement;
    // Update is called once per frame

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         float moveHorizontal = Input.GetAxisRaw("Horizontal");
    
 
         movement = new Vector3(moveHorizontal, 0f );
 
         movement = movement * speed * Time.deltaTime;
 
         transform.position += movement;


         transform.position += Vector3.up*Time.deltaTime;
    }
}
