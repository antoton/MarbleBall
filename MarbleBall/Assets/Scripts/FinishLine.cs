using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public GameObject GameManager;


    void OnTriggerExit(Collider Other) {
        if (Other.gameObject.tag == "Player") {
            GameManager.GetComponent<MyGameManager>().gameState = MyGameManager.GameStates.Completed;
        }
    }

}
