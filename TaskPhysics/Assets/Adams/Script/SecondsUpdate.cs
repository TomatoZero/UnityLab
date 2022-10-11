using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondsUpdate : MonoBehaviour
{
    float timeStartOfset = 0;
    bool gotStartTime = false;

    void Update()
    {
        if (!gotStartTime)
        {
            timeStartOfset = Time.realtimeSinceStartup;
            gotStartTime = true;
        }

        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, Time.realtimeSinceStartup - timeStartOfset);

        Debug.DrawRay(this.transform.position, Vector3.left - new Vector3(20,0,0), Color.red);
    }
}
