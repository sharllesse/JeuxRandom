using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAnimation : MonoBehaviour
{
    public Animator Animator;

    public void StartTheAnimation()
    {
        Animator.SetBool("raccontrue", true);
    }
}
