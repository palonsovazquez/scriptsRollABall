using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testtrigger : MonoBehaviour
{
    // Clase creada para ver las diferencias en que un collider sea trigger y no
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("istrigger")) // comprueba si la colision fue con uno de los cubos test tagueados como "istrigger"
        {
            // si lo es colorea la bola de amarillo
            GetComponent<Renderer>().material.color = Color.yellow;
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("istrigger")) // comprueba si la colision fue con uno de los cubos test tagueados como "istrigger"
        {
            other.GetComponent<Renderer>().material.color = Color.green; // lo pinta de verde
        }

    }
    private void OnTriggerExit(Collider other)
    {
        // comprueba si la colision fue con uno de los cubos test tagueados como "istrigger"
        if (other.gameObject.CompareTag("istrigger"))
        {
            other.GetComponent<Renderer>().material.color = Color.black; // lo pinta de negro
        }
    }
}