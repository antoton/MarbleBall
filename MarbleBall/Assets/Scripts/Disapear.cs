using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.UI;

public class Disapear : MonoBehaviour
{
    public Text txt;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Player") 
        {
            Destroy(gameObject);
            int currentscore = int.Parse(txt.text);
            currentscore++;
            txt.text = currentscore.ToString();
        }
    }
}
