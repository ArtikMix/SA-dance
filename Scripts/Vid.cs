using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Vid : MonoBehaviour, IPointerClickHandler
{
    int clicks = 0;
    public void OnPointerClick(PointerEventData data)
    {
        FindObjectOfType<Management>().score += 120;
        if (transform.name == "Vid_1(Clone)")
            Destroy(gameObject);
        clicks++;
        if (transform.name == "Vid_2(Clone)" && clicks == 2)
            Destroy(gameObject);
    }
}
