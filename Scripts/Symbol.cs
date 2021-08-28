using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Symbol : MonoBehaviour
{
    public GameObject destroying;
    public float speed = 5f;
    private int vid_once = 0;
    Management management;

    private void Start()
    {
        destroying = GameObject.FindGameObjectWithTag("final");
        speed += FindObjectOfType<Control>().mod;
        if (transform.name == "Vid_1" || transform.name == "Vid_2")
            speed = speed / 2;
        management = FindObjectOfType<Management>();
    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, destroying.transform.position, speed * Time.deltaTime);
        if (transform.position.x <= destroying.transform.position.x)
        {
            Destroy(gameObject);
        }
        if (transform.position.x <= GameObject.FindGameObjectWithTag("actual").transform.position.x && transform.position.x >= GameObject.FindGameObjectWithTag("nactual").transform.position.x)
        {
            switch (transform.name)
            {
                case "Obj_1(Clone)": 
                    management.act = 0;
                    vid_once = 0;
                    break;
                case "Obj_2(Clone)":
                    management.act = 1;
                    vid_once = 0;
                    break;
                case "Obj_3(Clone)":
                    management.act = 2;
                    vid_once = 0;
                    break;
                case "Obj_4(Clone)":
                    management.act = 3;
                    vid_once = 0;
                    break;
                case "Obj_5(Clone)":
                    management.act = 4;
                    vid_once = 0;
                    break;
                case "Obj_6(Clone)":
                    management.act = 5;
                    vid_once = 0;
                    break;
                case "Vid_1(Clone)":
                    management.act = 6;
                    vid_once = 0;
                    break;
                case "Vid_2(Clone)":
                    management.act = 7;
                    vid_once = 0;
                    break;
            }
        }
        if (transform.position.x <= GameObject.FindGameObjectWithTag("nactual").transform.position.x)
        {
            management.act = -1;
            if (transform.name == "Vid_1(Clone)" && vid_once == 0 && management.fails<2)
            {
                vid_once = 1;
                management.fails++;
                management.fails_t[management.fails].SetActive(true);
            }
            if (transform.name == "Vid_2(Clone)" && vid_once == 0 && management.fails < 2)
            {
                vid_once = 1;
                management.fails++;
                management.fails_t[management.fails].SetActive(true);
            }
        }
    }
}
