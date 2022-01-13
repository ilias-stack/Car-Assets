using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Broken_Car : MonoBehaviour
{
    bool Alum = false;
    public GameObject Lighti;
    public GameObject G_over;
    void Start()
    {
        InvokeRepeating("Lightsi", 1, 1);
        Invoke("gameover", 4);
    }

    void Lightsi()
    {
        if (Alum)
        {
            Alum = false;
            Lighti.SetActive(false);
        }
        else
        {
            Alum = true;
            Lighti.SetActive(true);
        }
    }
    void gameover()
    {
        Instantiate(G_over);
    }
}
