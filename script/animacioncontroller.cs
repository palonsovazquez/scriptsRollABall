using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animacioncontroller : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemigo;
    void Start()

    {

    }

    // Update is called once per frame
    void Update()
    {
        var dis = gameObject.transform.position - enemigo.transform.position;
        print(dis.magnitude);
    }
}
