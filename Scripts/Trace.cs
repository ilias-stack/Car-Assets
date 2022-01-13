using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trace : MonoBehaviour
{
    public Faux_Gravity attractor;
    void Start()
    {
        int X_scale = Random.Range(100, 220);
        gameObject.transform.localScale = new Vector3(X_scale, transform.localScale.y, X_scale);
        gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        gameObject.GetComponent<Rigidbody>().useGravity = false;


    }

    // Update is called once per frame
    void Update()
    {
        attractor.Attract(transform);

    }
}
