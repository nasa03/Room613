﻿/*
 *  Script thats placed on keys, that on collection disable the key object and unlock it's door
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour, Interactable
{
    public GameObject thiskey;
    public DoorScript doortounlock;


    public void Interact()
    {
        thiskey.SetActive(false);
        doortounlock.unlockme();
    }
}
