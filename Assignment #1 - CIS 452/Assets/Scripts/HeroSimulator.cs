/*
* Kevon Long
* HeroSimulator.cs
* Assignment #1
* The driver file that makes use of the methods of each Hero class
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroSimulator : MonoBehaviour
{

    public List<Hero> heroes;
    public List<Hero> heroes2;

    // Start is called before the first frame update
    void Start()
    {
  
        Link link = new Link();
        Mario mario = new Mario();
        Samus samus = new Samus();

        link.PlayOcarina();
        mario.Jump();
        samus.FireMissile();

        heroes = new List<Hero>
        {
            new Link(),
            new Mario(),
            new Link(),
            new Mario(),
            new Samus()
        };

        heroes2 = new List<Hero>
        {
            new Link(),
            new Mario(),
            new Link(),
            new Mario(),
            new Samus()
        };

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            foreach (var hero in heroes)
            {
                hero.SaveTheWorld();
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            foreach (ICanTaunt hero2 in heroes2)
            {
                hero2.Taunt();
            }
        }
    }
}
