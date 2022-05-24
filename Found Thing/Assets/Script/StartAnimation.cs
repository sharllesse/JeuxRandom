using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAnimation : MonoBehaviour
{
    public Animator Animator;
    public float Timer = 6f;
    public bool timers;
    public DialogueTrigger _dialogueTrigger;
    public GameObject Textfield;

    public void StartTheAnimation()
    {
        Animator.SetBool("raccontrue", true);
        timers = true;
    }

    public void Update()
    {
        if (timers == true)
        {
            Timer -= Time.deltaTime;
        }
        if (Timer <= 0)
        {
            timers = false;
            Timer = 6f;
            Textfield.SetActive(true);
            _dialogueTrigger.TriggerDialogue();
        }
    }
}
