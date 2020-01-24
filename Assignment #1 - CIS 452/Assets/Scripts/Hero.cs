/*
* Kevon Long
* Hero.cs
* Assignment #1
* Contains the abstract superclass "Hero" along with it's subclasses: "Link", "Mario", and "Samus". 
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Hero
{
    public abstract void SaveTheWorld();
}

public class Link : Hero, ICanRun, ICanTaunt
{
    public void PlayOcarina()
    {
        Debug.Log("Link played the Song of Time!");
    }

    public override void SaveTheWorld()
    {
        Debug.Log("Link went on an adventure to save Hyrule!");
    }

    public void Taunt()
    {
        Debug.Log("Link taunts");
    }

    public void Run()
    {
        Debug.Log("Link starts to run");
    }
}

public class Mario: Hero, ICanRun, ICanTaunt
{
    public void Jump()
    {
        Debug.Log("Mario jumped like he always does");
    }

    public override void SaveTheWorld()
    {
        Debug.Log("Mario set out to save Princess Peach!");
    }

    public void Taunt()
    {
        Debug.Log("Mario taunts");
    }

    public void Run()
    {
        Debug.Log("Mario starts to run");
    }
}

public class Samus: Hero, ICanRun, ICanTaunt
{
    public void FireMissile()
    {
        Debug.Log("Samus fired a missle!");
    }

    public override void SaveTheWorld()
    {
        Debug.Log("Samus got ready for the final battle against Ridley!");
    }

    public void Taunt()
    {
        Debug.Log("Samus taunts");
    }

    public void Run()
    {
        Debug.Log("Samus starts to run");
    }
}

