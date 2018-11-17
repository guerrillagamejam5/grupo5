using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorObject : MonoBehaviour {

    private bool open = false;

    // Default constructor
    public DoorObject ()
    {
        open = false;
    }

    public DoorObject (bool state)
    {
        open = state;
    }

    public void setState(bool state)
    {
        open = state;
    }

    public bool getState()
    {
        return open;
    }
}
