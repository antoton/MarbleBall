using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject Camera;
    public float Distance;
    public float Height;
    public void Start( )
    {
    }
    void OnTriggerExit(Collider Other) {
        if (Other.gameObject.tag == "Player") {
            if(Camera.GetComponent<SmoothFollow>() != null)
            {
                Camera.GetComponent<SmoothFollow>().ChangeZoom(Height, Distance);
            }
            
        }
    }
}
