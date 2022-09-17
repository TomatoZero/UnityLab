using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Reference3
{
    public class Enemy : MonoBehaviour
    {
        public static int enemyCount = 0;

        public Enemy()
        {
            enemyCount++;
        }
    }
}
