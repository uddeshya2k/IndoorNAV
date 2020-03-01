﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackScript : MonoBehaviour
{
    public GameObject Panel;

    public void OpenPanel()
    {
        if (Panel != null)
        {
            Animator animator = Panel.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("back");
                animator.SetBool("back", !isOpen);
            }
        }
    }
}
