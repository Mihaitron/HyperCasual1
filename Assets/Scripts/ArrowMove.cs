using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMove : MonoBehaviour
{
    [SerializeField] private float speed;
    private Vector3 aPos;
    

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed);
    }
}
