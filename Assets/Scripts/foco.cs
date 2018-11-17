using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foco : MonoBehaviour {

    public float alphaLevel;


	// Use this for initialization
	void Start () {
        alphaLevel = 0.30f;
	}
	
	// Update is called once per frame
	void Update () {
          
        transform.GetComponentInChildren<SpriteRenderer>().color = new Color(1f, 1f, 1f, alphaLevel);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        
        Debug.Log("Has perdido");
    }

}
