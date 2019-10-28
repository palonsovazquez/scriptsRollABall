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
    // Update is called once per frame
    void Update()
    {

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
            print("sin peligro");

        }
        else
        {
            print("peligro");
            jugador.GetComponent<Animator>().SetInteger("estado", 0);


        }



    }
}