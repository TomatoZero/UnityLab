using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTarget : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float accurancy = 0.1f;
    [SerializeField] private float spead;

    private Transform transform;

    private void Start()
    {
        transform = GetComponent<Transform>();
    }

    private void Update()
    {
        transform.LookAt(target);
    }

    private void LateUpdate()
    {
        Vector3 direction = target.position - transform.position;
        Debug.DrawRay(transform.position, direction, Color.red);
        if(direction.magnitude > accurancy)
            transform.Translate(direction.normalized * spead * Time.deltaTime, Space.World);
    }
}
