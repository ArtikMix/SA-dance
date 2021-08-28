using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForMarvelous : MonoBehaviour
{
    Management management;
    public GameObject marv;
    public bool once = true;

    private void Start()
    {
        management = FindObjectOfType<Management>();
    }
    private void Update()
    {
        if (management.score != 0 && management.score % 1000 == 0 && once == true)
        {
            once = false;
        }
    }
}
