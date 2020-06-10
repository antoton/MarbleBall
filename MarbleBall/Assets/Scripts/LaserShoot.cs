using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserShoot : MonoBehaviour
{
    public float ProjectileSpeed = 5;
    public float ShootRate = 1;
    float timer = 10f;
    public bool start = false;
    public GameObject LaserProjectile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (start) {
            timer += Time.deltaTime;
            if (timer > ShootRate) {
                GameObject newProjectile = Instantiate(LaserProjectile, transform.position+transform.up/3, transform.rotation);
                newProjectile.GetComponent<Rigidbody>().AddForce(transform.up*ProjectileSpeed, ForceMode.VelocityChange);
                timer = 0f;
           }
       }
    }
}
