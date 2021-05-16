using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMove : MonoBehaviour
{
    [SerializeField] private float speed;
    private Vector3 aPos;
    private bool isPaused;
    private ArrowsGenerator arrows;

    private void Start()
    {
        arrows = GameObject.Find("ArrowManager").GetComponent<ArrowsGenerator>();
    }

    // Update is called once per frame
    void Update()
    {
        isPaused = arrows.GetPaused();
        if (!isPaused)
            transform.Translate(Vector3.left * speed);
    }
}
