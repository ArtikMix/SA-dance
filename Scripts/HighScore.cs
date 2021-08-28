using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    void Start()
    {
        transform.gameObject.GetComponent<Text>().text = "HIGH SCORE:\n" + PlayerPrefs.GetInt("high").ToString();
    }
}
