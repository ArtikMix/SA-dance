using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TAP : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData data)
    {
        transform.gameObject.GetComponent<SpriteRenderer>().color = new Color(transform.gameObject.GetComponent<SpriteRenderer>().color.r - 100, transform.gameObject.GetComponent<SpriteRenderer>().color.g, transform.gameObject.GetComponent<SpriteRenderer>().color.b, transform.gameObject.GetComponent<SpriteRenderer>().color.a);
        switch (transform.name)
        {
            case "Top":
                FindObjectOfType<Control>().top = true;
                break;
            case "Bottom":
                FindObjectOfType<Control>().bot = true;
                break;
            case "Left":
                FindObjectOfType<Control>().left = true;
                break;
            case "Right":
                FindObjectOfType<Control>().right = true;
                break;
        }
    }
}
