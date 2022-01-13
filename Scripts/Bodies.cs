using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bodies : MonoBehaviour
{

    public Faux_Gravity attractor;
    void Start()
    {
        gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        gameObject.GetComponent<Rigidbody>().useGravity = false;


    }

    // Update is called once per frame
    void Update()
    {
        attractor.Attract(transform);

    }
}
