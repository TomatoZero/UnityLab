using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace References4
{
    public class Player : MonoBehaviour
    {
        public static int playerCount;
        void Start()
        {
            playerCount++;
        }
    }
}