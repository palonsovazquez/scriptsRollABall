using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Esta clase controla la posicion de la camara para que siga al jugador
    public GameObject player;
    private Vector3 offset;
    void Start()
    {
        offset = transform.position - player.transform.position;
    }


    void LateUpdate()
    {
        gameObject.transform.position = player.transform.position + offset;
    }
}
