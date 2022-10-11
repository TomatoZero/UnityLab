using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    [SerializeField] private GameObject explosion;

    private Rigidbody rb;
    //private float mass = 10;
    //private float force = 200;
    //private float acceleration;
    //private float speedZ;
    //private float gravityAcceleration;
    //private float gravity = -9.8f;
    //private float speedY;



    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "tank")
        {
            GameObject exp = Instantiate(explosion, this.transform.position, Quaternion.identity);
            Destroy(exp, 0.5f);
            Destroy(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //acceleration = force / mass;
        //speedZ += acceleration * Time.deltaTime;

        //gravityAcceleration = gravity / mass;
        //speedY += gravityAcceleration * Time.deltaTime;

        //this.transform.Translate(0, speedY, speedZ);

        //force = 0;
        this.transform.forward = rb.velocity;
    }
}
