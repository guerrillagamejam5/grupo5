using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour {

    public GameObject platform;
    public GameObject[] waypoints;
    public float speed = 0;
    public bool active = false;

    private int actualWP = 0;
    private int next = 1;
	
	// Update is called once per frame
	void Update () {
        // Cuando la ciudad activa el movimiento de las plataformas...
        Debug.Log("INIT INFO:\tactualWP: " + actualWP + "\tnext: " + next);
        if (active)
        {
            // Mover la plataforma del punto n a n+1 (o n-1)
            Transform pointA = waypoints[actualWP].transform;
            Transform pointB = waypoints[actualWP + next].transform;
            transform.Translate(new Vector2(pointB.position.x - pointA.position.x, pointB.position.y - pointA.position.y) * Time.deltaTime * speed);
            Debug.Log("Distance" + Vector2.Distance(platform.transform.position, pointB.transform.position));
            if (Vector2.Distance(platform.transform.position, pointB.transform.position) < 0.2)
            {
                actualWP += next;
                if (next > 0 && actualWP >= (waypoints.Length - 1))
                    next = -1;
                else if (next < 0 && actualWP <= 0)
                    next = 1;
                active = false;
                Debug.Log("PARA!\nINFO:\tactualWP: " + actualWP + "\tnext: " + next);
            }
        }
	}
}
