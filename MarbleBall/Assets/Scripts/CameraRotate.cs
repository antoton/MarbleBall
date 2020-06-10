using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    public float xAngle, yAngle, zAngle;
    public GameObject Camera;

    void OnTriggerExit(Collider Other) {
        if (Other.gameObject.tag == "Player") {
            Camera.transform.rotation = Quaternion.Euler(xAngle,yAngle,zAngle);
        }
    }

}
