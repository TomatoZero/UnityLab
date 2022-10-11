using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellMovement : MonoBehaviour
{
    [SerializeField] private float speed = 1;

    private float yAxis;
    private float zAxis;
    private bool move = false;

    public float ZAxis 
    {
        set { zAxis = value; }
    }

    public float YAxis
    {
        set { yAxis = value; }
    }

    public bool Move 
    {
        set => move = value;    
    }

    void Update()
    {
        if(move)
            this.transform.Translate(0, (speed * Time.deltaTime) * yAxis, (speed * Time.deltaTime) * zAxis);
    }

    public void MyReset() 
    {
        move = false;
        this.transform.position = new Vector3(-10, -4, 0);
    }
}
