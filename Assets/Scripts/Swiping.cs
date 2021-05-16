using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swiping : MonoBehaviour
{
    private Vector2 fingerDownPosition;
    private Vector2 fingerUpPosition;
    private ArrowsGenerator manager;
    private bool isMoving;
    private bool oneMove;

    // Start is called before the first frame update
    void Start()
    {
        isMoving = false;
        oneMove = false;
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
                isMoving = true;
            }

            else if (touch.phase == TouchPhase.Ended)
            {
                fingerUpPosition = touch.position;
                isMoving = false;
                oneMove = true;
            }
        }

        if (oneMove)
        {
            if (!isMoving)
            {
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

            oneMove = false;

        }
    }
}
