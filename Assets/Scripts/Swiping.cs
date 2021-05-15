﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swiping : MonoBehaviour
{
    public GameObject stanga;
    public GameObject dreapta;
    public GameObject up;
    public GameObject down;

    private Vector2 fingerDownPosition;
    private Vector2 fingerUpPosition;
    private ArrowsGenerator manager;

    // Start is called before the first frame update
    void Start()
    {
        manager = this.GetComponent<ArrowsGenerator>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
                fingerDownPosition = touch.position;

            else if (touch.phase == TouchPhase.Moved)
            {
                fingerUpPosition = touch.position;
            }

            else if (touch.phase == TouchPhase.Ended)
            {
                fingerUpPosition = touch.position;
            }
        }

        if (fingerUpPosition.x < fingerDownPosition.x)
        {
            if ((fingerUpPosition.y < fingerDownPosition.y) && (fingerDownPosition.y - fingerUpPosition.y >
                                                                fingerDownPosition.x - fingerUpPosition.x))
            {
                manager.SwipeAction(1);
            }
            else if ((fingerUpPosition.y > fingerDownPosition.y) && (fingerUpPosition.y - fingerDownPosition.y >
                                                                     fingerDownPosition.x - fingerUpPosition.x))
            {
                manager.SwipeAction(0);
            }
            else
            {
                manager.SwipeAction(2);
            }
        }
        else
        {
            if ((fingerUpPosition.y < fingerDownPosition.y) && (fingerDownPosition.y - fingerUpPosition.y >
                                                                fingerUpPosition.x - fingerDownPosition.x))
            {
                manager.SwipeAction(1);
            }
            else if ((fingerUpPosition.y > fingerDownPosition.y) && (fingerUpPosition.y - fingerDownPosition.y >
                                                                     fingerUpPosition.x - fingerDownPosition.x))
            {
                manager.SwipeAction(0);
            }
            else
            {
                manager.SwipeAction(3);
            }
        }
    }
}
