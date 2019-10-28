using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testtrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("istrigger"))
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (true)
        {
            if (other.gameObject.CompareTag("istrigger"))
            {
                other.GetComponent<Renderer>().material.color = Color.green;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("istrigger"))
        {
            other.GetComponent<Renderer>().material.color = Color.black;
        }
    }
}