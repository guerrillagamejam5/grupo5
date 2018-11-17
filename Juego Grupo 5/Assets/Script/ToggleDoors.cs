using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleDoors : MonoBehaviour {

	// Event for toggle doors
	public void ToogleDoors () {
        GameObject[] doors = GameObject.FindGameObjectsWithTag("Door");
        foreach (GameObject door in doors) {
            door.GetComponent<DoorObject>().setState(!door.GetComponent<DoorObject>().getState());
            Debug.Log(door.GetComponent<DoorObject>().getState());
        }
	}
}
