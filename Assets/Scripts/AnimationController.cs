using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class AnimationController : MonoBehaviour
{
    private Animator animator;
    [SerializeField] private int animationNo = 0;
    private ArrowsGenerator arrows;

    private void Start()
    {
        this.animator = this.GetComponent<Animator>();
        arrows = GameObject.Find("ArrowManager").GetComponent<ArrowsGenerator>();
    }

    private void Update()
    {
        if (arrows.GetAww())
        {
            this.animationNo = 3;
        }
        else
        {
            this.animationNo = Random.Range(2, 4) - 1;
        }

        this.animator.SetInteger("anim", this.animationNo);
    }
}
