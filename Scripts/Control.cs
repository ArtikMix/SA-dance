using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public GameObject start;
    public float mod = 0f;
    public bool top = false, bot = false, left = false, right = false;
    private void Start()
    {
        StartCoroutine(SpawnCorountine());
    }

    private void Update()
    {
        if (top)
        {
            Debug.Log("top true");
        }
        if (Input.touchCount == 0)
        {
            top = false;
            bot = false;
            left = false;
            right = false;
        }
    }

    IEnumerator SpawnCorountine()
    {
        while (true)
        {
            int n = Random.Range(0, 8);
            Instantiate(FindObjectOfType<Management>().objects[n], start.transform.position, start.transform.rotation);
            yield return new WaitForSeconds(1.5f);
            mod += 0.035f;
        }
    }
}
