using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace References4
{
    public class PlayerManeger : MonoBehaviour
    {
        void Start()
        {
            int x = Player.playerCount;
            Debug.Log(x);
        }
    }
}
