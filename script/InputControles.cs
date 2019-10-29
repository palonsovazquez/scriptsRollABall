using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControles : interfaceControles
{
    // Prototipo para convertir a interface el control del jugador
    private float xAxis = 0f;
    private float yAxis = 0f;

    private bool jump = false;
    private KeyCode adelante = KeyCode.W;
    private KeyCode atras = KeyCode.S;
    private KeyCode derecha = KeyCode.D;
    private KeyCode izquierda = KeyCode.A;
    public bool adelantePulsado = false;
    public bool atrasPulsado = false;
    public bool derechaPulsado = false;
    public bool izquierdaPulsado = false;

    public float getxAxis()
    {
        float xAxis = 0f;

        return xAxis;
    }

    public bool getJump()
    {

        return false;
    }
    public float getYAxis()
    {


        return this.yAxis;
    }
    public bool getjump()
    {


        return this.jump;
    }



    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetKey(adelante))
        {
            adelantePulsado = true;
            //print("adelante" + adelantePulsado);
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

        if (adelantePulsado || atrasPulsado)
        {
            if (adelantePulsado && atrasPulsado)
            {
                xAxis = 0;

            }
            else
            {
                if (adelantePulsado)
                {
                    xAxis = 1;
                }
                else
                {
                    xAxis = -1;
                }



            }



        }
        else
        {
            xAxis = 0;

        }
        if (izquierdaPulsado || derechaPulsado)
        {
            if (izquierdaPulsado && derechaPulsado)
            {
                yAxis = 0;

            }
            else
            {
                if (adelantePulsado)
                {
                    yAxis = 1;
                }
                else
                {
                    yAxis = -1;
                }



            }



        }
        else
        {
            yAxis = 0;

        }

    }
}
