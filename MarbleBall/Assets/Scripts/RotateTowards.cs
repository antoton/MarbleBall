using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// To use this script, attach it to the GameObject that you would like to rotate towards another game object.
// After attaching it, go to the inspector and drag the GameObject you would like to rotate towards into the target field.
// Move the target around in the scene view to see the GameObject continuously rotate towards it.
public class RotateTowards : MonoBehaviour
{
    // The target marker.
    public Transform target;


    void Update()
    {
        var newRotation = Quaternion.LookRotation(transform.position - target.position, Vector3.forward);
    newRotation.x = 0.0F;
    newRotation.z = 0.0F;
    transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, Time.deltaTime * 8);
    }
}
