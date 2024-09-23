using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFly : MonoBehaviour
{

    private Vector2 direction = Vector2.right;
    public float moveSpeed = 5f;
    public void Init(float value = 5f)
    {
        moveSpeed = value;
    }
    private void Start()
    {
        Debug.Log(moveSpeed.ToString());
    }
    void Update()
    {
        
        transform.Translate(this.direction * moveSpeed * Time.deltaTime);
    }
    
    
}
