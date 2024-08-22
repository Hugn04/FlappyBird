using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabPipe : MonoBehaviour
{
    public Rigidbody2D rb;
    private Vector2 vt;
    public float speed = 0.1f;
    
    void Start()
    {
      
    }
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        transform.position = new Vector2(transform.position.x-speed*Time.fixedDeltaTime, transform.position.y);
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log("thua");
        };
    }
}
