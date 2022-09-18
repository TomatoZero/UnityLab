using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Reference2
{
    public class MotionScript : MonoBehaviour
    {
        public float speed = 3f;

        void Update()
        {
            transform.Translate(-Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);
        }
    }
}
