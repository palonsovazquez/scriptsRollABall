using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerMovement : MonoBehaviour
{
    public int inputType = 0;
    public string horizontalAxis;
    public string verticallAxis;
    // interfaceControles x;
    // velocidad angular de la bola
    public float speed = 10;
    //puntuacion del personaje
    public int puntuacion = 0;

    // objeto vacion para controlar los orbes
    public GameObject controladororbes;
    // texto que muestra la puntuacion
    public Text texto;

    //coordenadas originales
    private float xoriginal, yoriginal, zoriginal;
    void Start()
    {
        // implemento la clase de control


        switch (inputType)
        {
            case 0:
                {
                    // x = new InputControles();

                }

                break;
            case 1:
                {

                }
                break;



        }

        // recojo las coordenadas originales
        xoriginal = transform.position.x;
        yoriginal = transform.position.y;
        zoriginal = transform.position.z;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //si se cae resetea la posicion y la puntuacion
        if (transform.position.y < 0)
        {
            print("caida");
            gameObject.transform.position.Set(xoriginal, yoriginal, zoriginal);
            transform.SetPositionAndRotation(new Vector3(xoriginal, yoriginal, zoriginal), new Quaternion(0, 0, 0, 0));
            puntuacion = 0;
            texto.text = ("Puntuacion: " + puntuacion);
        }

        // bloque de control del movimiento
        gameObject.GetComponent<Rigidbody>().AddTorque(new Vector3(Input.GetAxis(verticallAxis) * speed, 0, -Input.GetAxis(horizontalAxis) * speed));

        // if (gameObject.GetComponent<InputControles>().adelantePulsado)
        // {
        //     gameObject.GetComponent<Rigidbody>().AddTorque(new Vector3(speed, 0, 0));

        // }
        // if (gameObject.GetComponent<InputControles>().atrasPulsado)
        // {
        //     gameObject.GetComponent<Rigidbody>().AddTorque(new Vector3(-speed, 0, 0));

        // }
        // if (gameObject.GetComponent<InputControles>().derechaPulsado)
        // {
        //     gameObject.GetComponent<Rigidbody>().AddTorque(new Vector3(0, 0, -speed));

        // }
        // if (gameObject.GetComponent<InputControles>().izquierdaPulsado)
        // {
        //     gameObject.GetComponent<Rigidbody>().AddTorque(new Vector3(0, 0, speed));

        // }


    }

    void OnTriggerEnter(Collider other)
    {

        // control de la puntuacion al recoger un pickup y genera uno nuevo        
        if (other.gameObject.CompareTag("PickUp"))
        {
            puntuacion += 1;
            print("colision" + " " + other.gameObject.tag + " " + puntuacion);
            texto.text = ("Puntuacion: " + puntuacion);

            Destroy(other.gameObject);
            controladororbes.GetComponent<OrbesCreator>().crearOrbe();



        }


    }
}
