using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class seguirjugador : MonoBehaviour
{
    public Transform jugador;
    UnityEngine.AI.NavMeshAgent enemigo;
    private bool dentro = false;
    private float distancia = 5f;
    public Text texto;

    // Use this for initialization
    void Start()
    {
        enemigo = GetComponent<UnityEngine.AI.NavMeshAgent>();

    }

    void OnTriggerEnter(Collider other)
    {

        //deteccion de que el enemigo te pilla, resetea la puntuacion
        if (other.tag == "Player")
        {
            dentro = true;
            jugador.GetComponent<PlayerMovement>().puntuacion = 0;
            texto.text = "Puntuacion: " + 0;

        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            dentro = false;
        }
    }

    void Update()
    {
        // control del enemigo mediante el navmesh y la animacion
        if (!dentro)
        {
            enemigo.destination = jugador.position;
        }
        if (dentro)
        {
            enemigo.destination = this.transform.position;
        }
        if (enemigo.remainingDistance < distancia)
        {
            jugador.GetComponent<Animator>().SetInteger("estado", 1);
            if (debugprofile.estadodebug)
                print("sin peligro");

        }
        else
        {
            if (debugprofile.estadodebug)
                print("peligro");
            jugador.GetComponent<Animator>().SetInteger("estado", 0);


        }



    }
}