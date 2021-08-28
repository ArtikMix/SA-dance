using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Marv : MonoBehaviour
{
    private void Start()
    {
        switch (Random.Range(0, 5))
        {
            case 0:
                transform.GetComponent<Text>().text = "NICE";
                break;
            case 1:
                transform.GetComponent<Text>().text = "WOW!";
                break;
            case 2:
                transform.GetComponent<Text>().text = "SUPER";
                break;
            case 3:
                transform.GetComponent<Text>().text = "COOL";
                break;
            case 4:
                transform.GetComponent<Text>().text = "MARVELOUS";
                break;
            case 5:
                transform.GetComponent<Text>().text = "UNSTOPPABLE";
                break;
        }
    }
}
