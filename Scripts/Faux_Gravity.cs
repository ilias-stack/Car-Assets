using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Faux_Gravity : MonoBehaviour
{
    public float Gravity=-10;
    public void Attract(Transform body)
    {
        Vector3 GravityUp = (body.position - transform.position).normalized;
        body.GetComponent<Rigidbody>().AddForce(GravityUp * Gravity);
        Quaternion targetRotation = Quaternion.FromToRotation(body.up, GravityUp)*body.rotation;
        body.rotation = Quaternion.Slerp(body.rotation, targetRotation, 50 * Time.deltaTime);

    }
}
