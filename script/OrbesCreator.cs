using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbesCreator : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject[] orbes;
    public GameObject orbe;
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            crearOrbe();


        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void crearOrbe()
    {
        var x = Random.Range(-7, 7);
        var y = Random.Range(-7, 7);
        Instantiate(orbe, new Vector3(x, 4, y), Quaternion.identity);


    }
}
