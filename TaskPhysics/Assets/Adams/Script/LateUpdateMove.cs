using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LateUpdateMove : MonoBehaviour
{
    void LateUpdate()
    {
        this.transform.Translate(0, 0, 0.01f);
        Debug.DrawRay(this.transform.position, Vector3.left - new Vector3(20, 0, 0), Color.blue);

    }
}
