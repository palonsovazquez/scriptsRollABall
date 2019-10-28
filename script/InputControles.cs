using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControles : MonoBehaviour
{
    // Prototipo para convertir a interface el control del jugador

    private KeyCode adelante = KeyCode.W;
    private KeyCode atras = KeyCode.S;
    private KeyCode derecha = KeyCode.D;
    private KeyCode izquierda = KeyCode.A;
    public bool adelantePulsado = false;
    public bool atrasPulsado = false;
    public bool derechaPulsado = false;
    public bool izquierdaPulsado = false;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(adelante))
        {
            adelantePulsado = true;
            print(adelantePulsado);
        }
        else
        {
            adelantePulsado = false;
        }
        // atras
        if (Input.GetKey(atras))
        {
            atrasPulsado = true;
        }
        else
        {
            atrasPulsado = false;
        }

        if (Input.GetKey(derecha))
        {
            derechaPulsado = true;
        }
        else
        {
            derechaPulsado = false;
        }
        if (Input.GetKey(izquierda))
        {
            izquierdaPulsado = true;
        }
        else
        {
            izquierdaPulsado = false;
        }
    }
}
