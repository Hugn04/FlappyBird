using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 5f;

    void Update()
    {
        Movement();
    }
    void Movement()
    {
        float moveX = Input.GetAxis("Horizontal"); 
        //float moveY = Input.GetAxis("Vertical");  
        if(moveX < 0)
        {
            //Quaternion rotate = transform.rotation.y;
            transform.rotation = Quaternion.Euler(0, -180, 0);
        }
        else if(moveX >0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        transform.position += new Vector3(moveX, 0, 0) * speed * Time.deltaTime;
    }
    
}
