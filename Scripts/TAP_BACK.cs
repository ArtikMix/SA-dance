using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TAP_BACK : MonoBehaviour, IPointerUpHandler
{
    public void OnPointerUp(PointerEventData data)
    {
        transform.gameObject.GetComponent<SpriteRenderer>().color = new Color(transform.gameObject.GetComponent<SpriteRenderer>().color.r+100, transform.gameObject.GetComponent<SpriteRenderer>().color.g, transform.gameObject.GetComponent<SpriteRenderer>().color.b, transform.gameObject.GetComponent<SpriteRenderer>().color.a);
    }
}
