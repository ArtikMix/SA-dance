using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class First : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(letsgo());
    }

    IEnumerator letsgo()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(1);
    }
}
