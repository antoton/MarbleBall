using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarCollect : MonoBehaviour
{
    public Image image;
    public AudioClip sound;

    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Player") 
        {
            Destroy(gameObject);
            image.color = Color.yellow;
            AudioSource.PlayClipAtPoint(sound, transform.position);
        }
    }
}
