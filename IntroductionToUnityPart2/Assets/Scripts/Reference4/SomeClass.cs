using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Reference4
{
    public class SomeClass : MonoBehaviour
    {
        public T GenericMethod<T>(T param)
        {
            return param;
        }
    }
}
