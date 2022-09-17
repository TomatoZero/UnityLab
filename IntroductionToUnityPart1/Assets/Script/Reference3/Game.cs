using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Reference3
{
    public class Game : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Enemy enemy1 = new Enemy();
            Enemy enemy2 = new Enemy();
            Enemy enemy3 = new Enemy();

            int x = Enemy.enemyCount;
            Debug.Log(x);
        }

    }
}