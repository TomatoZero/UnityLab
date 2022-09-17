using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    void Start()
    {
        Player player = new Player();
        player.Experience = 5;
        int x = player.Experience;

        Debug.Log(x);
    }
}
