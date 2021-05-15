using System.Collections;
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

    // Start is called before the first frame update
    void Start()
    {
        
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
                down.SetActive(true);
                stanga.SetActive(false);
                dreapta.SetActive(false);
                up.SetActive(false);
            }
            else if ((fingerUpPosition.y > fingerDownPosition.y) && (fingerUpPosition.y - fingerDownPosition.y >
                                                                     fingerDownPosition.x - fingerUpPosition.x))
            {
                down.SetActive(false);
                stanga.SetActive(false);
                dreapta.SetActive(false);
                up.SetActive(true);
            }
            else
            {
                down.SetActive(false);
                stanga.SetActive(true);
                dreapta.SetActive(false);
                up.SetActive(false);
            }
        }
        else
        {
            if ((fingerUpPosition.y < fingerDownPosition.y) && (fingerDownPosition.y - fingerUpPosition.y >
                                                                fingerUpPosition.x - fingerDownPosition.x))
            {
                down.SetActive(true);
                stanga.SetActive(false);
                dreapta.SetActive(false);
                up.SetActive(false);
            }
            else if ((fingerUpPosition.y > fingerDownPosition.y) && (fingerUpPosition.y - fingerDownPosition.y >
                                                                     fingerUpPosition.x - fingerDownPosition.x))
            {
                down.SetActive(false);
                stanga.SetActive(false);
                dreapta.SetActive(false);
                up.SetActive(true);
            }
            else
            {
                down.SetActive(false);
                stanga.SetActive(false);
                dreapta.SetActive(true);
                up.SetActive(false);
            }
        }
    }
}
