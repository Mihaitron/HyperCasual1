using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator animator;
    private int animationNo = 0;

    private void Start()
    {
        this.animator = this.GetComponent<Animator>();
    }

    private void Update()
    {
        // do some stuff to check which animation
        
        this.animator.SetInteger("anim", this.animationNo);
    }
}
