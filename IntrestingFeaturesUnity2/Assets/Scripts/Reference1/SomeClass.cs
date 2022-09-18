using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeClass : MonoBehaviour
{
    void Start()
    {
        List<BadGuy> badguys = new List<BadGuy>();

        //Here you add 3 BadGuys to the List
        badguys.Add(new BadGuy("Harvey", 50));
        badguys.Add(new BadGuy("Magneto", 100));
        badguys.Add(new BadGuy("Pip", 5));

        badguys.Sort();

        foreach (BadGuy guy in badguys)
        {
            print(guy.name + " " + guy.power);
        }

        badguys.Clear();
    }
}
