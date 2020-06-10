using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartShooting : MonoBehaviour
{
    public GameObject Cannon;
    public bool startShooting = false;
    public void Start( )
    {
    }
    void OnTriggerExit(Collider Other) {
        if (Other.gameObject.tag == "Player") {
            if(Cannon.GetComponent<LaserShoot>() != null)
            {
                if (startShooting == true) {
                Cannon.GetComponent<LaserShoot>().start = true; }
                if (startShooting == false) {
                Cannon.GetComponent<LaserShoot>().start = false; }
            }
            
        }
    }
}
