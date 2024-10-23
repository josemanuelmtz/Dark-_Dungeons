﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Collectable
{

    public Sprite emptyChest;
    public int gold = 10;


    protected override void OnCollect()
    {
        if (!collected)
        {
            collected = true;
            GetComponent<SpriteRenderer>().sprite = emptyChest;
            Debug.Log(gold + " Gold Acquired!");
        }
    }
}
