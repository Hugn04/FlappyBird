using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bulletPrefab;  
    public float maxCharge = 20f;      
    public float chargeRate = 5f;    
    public float currentCharge = 0f;  
    public Transform bulletPos;
    void Update()
    {
        // Kiểm tra nếu người chơi đang giữ phím Space
        if (Input.GetKey(KeyCode.Space))
        {
            ChargeBullet();
        }

        // Kiểm tra nếu người chơi nhả phím Space
        if (Input.GetKeyUp(KeyCode.Space))
        {
            ShootBullet();
        }
    }
    
    void ChargeBullet()
    {
        currentCharge += chargeRate * Time.deltaTime;
        currentCharge = Mathf.Clamp(currentCharge, 0f, maxCharge); 
        //Debug.Log("Lực hiện tại: " + currentCharge);
    }

    void ShootBullet()
    {
        
        GameObject bullet = Instantiate(bulletPrefab, bulletPos.position, transform.rotation);
        bullet.gameObject.SetActive(true);
        BulletFly bulletFly = bullet.AddComponent<BulletFly>();
        bulletFly.moveSpeed = currentCharge;
        currentCharge = 0f;
    }
    

}

