using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class AnimationController : MonoBehaviour
{
    private Animator animator;
    [SerializeField] private int animationNo = 0;

    private void Start()
    {
        this.animator = this.GetComponent<Animator>();
    }

    private void Update()
    {
        if (false) // Check if "Awww" triggered
        {
            
        }
        else if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
        {
            this.animationNo = Random.Range(2, 4) - 1;
        }
        
        this.animator.SetInteger("anim", this.animationNo);
    }
}
