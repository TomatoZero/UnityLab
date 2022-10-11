using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateDeltaTimeMove : MonoBehaviour
{
    void Update()
    {
        this.transform.Translate(0, 0, Time.deltaTime);
        Debug.DrawRay(this.transform.position, Vector3.left - new Vector3(20, 0, 0), Color.green);
    }
}
