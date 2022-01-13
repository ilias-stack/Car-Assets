using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    GameObject Planet;
    public GameObject Boom;
    public GameObject Trace;
    void Start()
    {
        int X_scale = Random.Range(100, 220);
        int Y_scale = Random.Range(100, 220);
        int Z_scale = Random.Range(100, 220);
        gameObject.transform.localScale = new Vector3(X_scale, Y_scale, Z_scale);
        Planet = GameObject.Find("Planet");
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().AddForce((Planet.transform.position.normalized - transform.position) * 20 * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "planet" || collision.gameObject.tag == "asteroid")
        {
            Instantiate(Boom, transform.position, Quaternion.identity);
            Instantiate(Trace, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        else if(collision.gameObject.tag == "Trace")
        {
            Instantiate(Boom, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
    
}
