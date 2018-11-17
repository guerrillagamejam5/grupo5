using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terminal : MonoBehaviour {

    public GameObject[] gameobjectsToBeInteracted;
    private bool isAvatarInRange = false;

	// Use this for initialization
	void Start ()
    {
		if(gameobjectsToBeInteracted == null)
        {
            //Si la terminal no tiene ninguna interacción asociada, se desactiva
            Debug.Log("There's no associated game objects in the Terminal");
            gameObject.SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(isAvatarInRange)
        {
            interaccionJugador();
        }
	}

    public void avatarInRange(bool b)
    {
        isAvatarInRange = b;
    }

   private void interaccionJugador()
    {
        if(Input.GetKey(KeyCode.E))
        {
            interactWithObjects();
        }
    }

    private void interactWithObjects()
    {
        for(int i = 0; i < gameobjectsToBeInteracted.Length; i++)
        {

            if (gameobjectsToBeInteracted[i].gameObject is DoorObject)
            {
                //Toggle the door object
                DoorObject puerta = gameobjectsToBeInteracted[i].gameObject.GetComponent<DoorObject>();
                puerta.setState(!puerta.getState());
            } else if (gameobjectsToBeInteracted[i].gameObject is MovePlatform)
            {
                //Activate the platform
                MovePlatform plataforma = gameobjectsToBeInteracted[i].gameObject.GetComponent<MovePlatform>();
                if (gameobjectsToBeInteracted[i].gameObject.active)
                    gameobjectsToBeInteracted[i].gameObject.SetActive(false);
                else
                    gameobjectsToBeInteracted[i].gameObject.SetActive(true);
            } else if(gameobjectsToBeInteracted[i].gameObject.gameObject is foco)
            {
                //Switch off/on the spotlight
                foco spotlight = gameobjectsToBeInteracted[i].gameObject.GetComponent<foco>();
                //Logica a seguir para los focos
            }
        }
    }

}
