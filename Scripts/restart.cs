using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class restart : MonoBehaviour
{
    public Text Scr;

    private void Start()
    {
        int p = (int)Player.sc;
        Scr.text = p.ToString();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
    }

}
