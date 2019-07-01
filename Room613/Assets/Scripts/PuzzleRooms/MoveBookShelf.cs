﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBookShelf : MonoBehaviour
{
    public Transform target;
    private bool activated = false;
    private bool moving = false;
    

    public void moveme(){
        if (!activated)
        {
            moving = true;
            activated = true;
        }
    }

    private void Update()
    {
        if (moving)
        {
            if (transform.position != target.position)
            {
                transform.position = Vector3.Slerp(transform.position, target.position, Time.deltaTime * 0.5f);
            } else
            {
                moving = false;
            }
        }
    }
}