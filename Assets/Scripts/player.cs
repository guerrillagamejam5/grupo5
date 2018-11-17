using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    public bool encendido;
    public GameObject[] focos;
    public int velocidad;




    // Use this for initialization
    void Start()
    {
        velocidad = 5;
        encendido = true;
        focos = GameObject.FindGameObjectsWithTag("Foco");

    }

    // Update is called once per frame
    void Update()
    {
        //si activo luces
        if (Input.GetKeyDown(KeyCode.E))
        {
            cambioOnOff();
        }

        movimientoJugador();

        comprueboFocos();



    }

    void cambioOnOff()
    {
        if (encendido)
        {
            encendido = false;
            Debug.Log("Luces apagadas");
        }
        else
        {
            encendido = true;
            Debug.Log("Luces encendidas");

        }
    }


    void comprueboFocos()
    {
        foreach (var foco in focos)
        {


            if (encendido)
            {
                foco.GetComponent<BoxCollider2D>().enabled = true;
                foco.SetActive(true);
                foco.transform.GetChild(0).gameObject.SetActive(true);
            }

            else
            {
                foco.GetComponent<BoxCollider2D>().enabled = false;
                foco.SetActive(false);
                foco.transform.GetChild(0).gameObject.SetActive(false);

            }
        }
    }

    void movimientoJugador()
    {
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(velocidad, GetComponent<Rigidbody2D>().velocity.y);
        }

        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-velocidad, GetComponent<Rigidbody2D>().velocity.y);
        }
    }
}
