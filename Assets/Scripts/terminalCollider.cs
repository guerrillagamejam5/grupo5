using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terminalCollider : MonoBehaviour {

    terminal associatedTerminal;
    
    void Start()
    {
        associatedTerminal = gameObject.transform.parent.gameObject.GetComponent<terminal>();
    }
    private void OnTriggerEnter(Collider o)
    {
        associatedTerminal.avatarInRange(true);
        Debug.Log("Avatar in range of the terminal!");
    }

    private void OnTriggerExit(Collider o)
    {
        associatedTerminal.avatarInRange(false);
        Debug.Log("Avatar exited the range of the terminal!");
    }
}
