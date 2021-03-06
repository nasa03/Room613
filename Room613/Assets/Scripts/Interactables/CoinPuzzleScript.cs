﻿/*
 * Script used to update what coins the player has collected. upon collection of all coins and activating 
 * the coin box this script also enables the winning triggers at the stair doors.
 */ 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinPuzzleScript : MonoBehaviour, Interactable
{
    [SerializeField]
    private bool one;
    [SerializeField]
    private bool two;
    [SerializeField]
    private bool three;
    [SerializeField]
    private bool four;
    [SerializeField]
    private bool five;

    public Canvas thiscanvas;
    public Text needmorecoins;
    public Text youwin;

    public bool toggle = true;

    public GameObject finaltrig1;
    public GameObject finaltrig2;

    private int count = 0;
    //key stuff
    public GameObject Key; 

    private void Start()
    {
        Key.SetActive(false);
        one = false;
        two = false;
        three = false;
        four = false;
        five = false;
        finaltrig1.SetActive(false);
        finaltrig2.SetActive(false);
        thiscanvas.enabled = false;
        needmorecoins.enabled = false;
        youwin.enabled = false;
    }

    public void getcoin(int a) //TODO replace with switch
    {
        if (a == 1)
        {
            one = true;
            count++;
        }
        else if (a == 2)
        {
            two = true;
            count++;
        }
        else if (a == 3)
        {
            three = true;
            count++;
        }
        else if (a == 4)
        {
            four = true;
            count++;
        }
        else if (a == 5)
        {
            five = true;
            count++;
        }
    }

    public void Interact()
    {
        if (one && two && three && four && five)
        {
            if (toggle)
            {
                thiscanvas.enabled = true;
                youwin.enabled = true;
                Invoke("hidetext", 10);
                Key.SetActive(true);
                toggle = false;
            }

        } else
        {
            thiscanvas.enabled = true;
            needmorecoins.enabled = true;
            Invoke("hidetext", 5);
        }
    }

    private void hidetext()
    {
        needmorecoins.enabled = false;
        youwin.enabled = false;
    }

    public string coincount()
    {
        return count.ToString(); ;
    }
}
