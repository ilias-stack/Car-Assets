using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour
{
    public GameObject Meteor;
    void Start()
    {
        InvokeRepeating("SpawnMeteor", 3, 0.2f);
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
        }
    }

    void SpawnMeteor()
    {
        Vector3 Pos = Random.onUnitSphere * 100;
        Instantiate(Meteor,Pos,Quaternion.identity);
    }
}
