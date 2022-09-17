using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UtilitiesExample : MonoBehaviour
{
    void Start()
    {
        int x = Utilities.Add(5, 6);
        Debug.Log(x);
    }
}
