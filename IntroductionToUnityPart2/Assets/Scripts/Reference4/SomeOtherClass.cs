using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Reference4
{
    public class SomeOtherClass : MonoBehaviour
    {
        void Start()
        {
            SomeClass myClass = new SomeClass();
            Debug.Log(myClass.GenericMethod<int>(5));
        }
    }
}
