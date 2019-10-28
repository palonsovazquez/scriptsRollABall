using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10;
    public int puntuacion = 0;
    public GameObject controladororbes;

    public Text texto;
    private Transform posicionoriginal;
    private float xoriginal, yoriginal, zoriginal;
    void Start()
    {
        xoriginal = transform.position.x;
        yoriginal = transform.position.y;
        zoriginal = transform.position.z;
        // print("caida x= " + posicionoriginal.transform.position.x + " y= " + posicionoriginal.transform.position.y + " z= " + posicionoriginal.transform.position.z);
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (transform.position.y < 0)
        {
            print("caida");
            gameObject.transform.position.Set(xoriginal, yoriginal, zoriginal);
            transform.SetPositionAndRotation(new Vector3(xoriginal, yoriginal, zoriginal), new Quaternion(0, 0, 0, 0));
            puntuacion = 0;
            texto.text = ("Puntuacion: " + puntuacion);
        }

        if (gameObject.GetComponent<InputControles>().adelantePulsado)
        {
            gameObject.GetComponent<Rigidbody>().AddTorque(new Vector3(speed, 0, 0));

        }
        if (gameObject.GetComponent<InputControles>().atrasPulsado)
        {
            gameObject.GetComponent<Rigidbody>().AddTorque(new Vector3(-speed, 0, 0));

        }
        if (gameObject.GetComponent<InputControles>().derechaPulsado)
        {
            gameObject.GetComponent<Rigidbody>().AddTorque(new Vector3(0, 0, -speed));

        }
        if (gameObject.GetComponent<InputControles>().izquierdaPulsado)
        {
            gameObject.GetComponent<Rigidbody>().AddTorque(new Vector3(0, 0, speed));

        }


    }

    void OnTriggerEnter(Collider other)
    {
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
