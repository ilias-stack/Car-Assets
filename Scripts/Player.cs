using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int Speed = 30;
    Vector3 direction;
    public float Todem=3;
    public GameObject l1;
    public GameObject l2;
    public GameObject B_car;
    public Text Score;
    public static float sc;
    public AudioSource vroom;
    float scr;

    private void Start()
    {
        Invoke("LightsOn", Todem);
        Invoke("Grrrm", Todem);
    }
    // Update is called once per frame
    void Update()
    {
        scr += Time.deltaTime;
        Score.text = $"{(int)scr}";
        sc += Time.deltaTime;
        direction = new Vector3(0, 0, 1).normalized;
    }
    private void FixedUpdate()
    {
        Todem -= Time.deltaTime;
        if (Todem <= 0)
        {
            GetComponent<Rigidbody>().MovePosition(transform.position + transform.TransformDirection(direction)* Speed * Time.deltaTime);
            
                if (Input.GetKey("a"))
                {
                    gameObject.transform.Rotate(0, -1.8f, 0);
                }
                if (Input.GetKey("d"))
                {
                    gameObject.transform.Rotate(0, 1.8f, 0);
                }
        }

    }
    void LightsOn()
    {
        l1.SetActive(true);
        l2.SetActive(true);
    }
    void Die()
    {
        Instantiate(B_car,transform.position,transform.rotation);
        Destroy(gameObject);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "asteroid" || collision.gameObject.tag == "Trace")
        {
            Die();
        }
    }
    void Grrrm()
    {
        vroom.Play();
    }
}
