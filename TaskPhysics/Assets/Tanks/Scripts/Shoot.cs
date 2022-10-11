using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject shellPrefab;
    [SerializeField] private GameObject shellSpawnPos;
    [SerializeField] private GameObject target;
    [SerializeField] private GameObject parent;

    private float speedRotation = 2f;
    private float speed = 15f;
    private bool canShoot = true;

    // Start is called before the first frame update
    void Start()
    {
    }

    private void CanShootAgain() { canShoot = true; }

    public void Fire() 
    {
        if (canShoot)
        {
            GameObject shell = Instantiate(shellPrefab, shellSpawnPos.transform.position, shellSpawnPos.transform.rotation);
            shell.GetComponent<Rigidbody>().velocity = speed * this.transform.forward;
            canShoot = false;
            Invoke("CanShootAgain", 0.5f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = (target.transform.position - parent.transform.position).normalized;
        Quaternion rotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        parent.transform.rotation = Quaternion.Slerp(parent.transform.rotation, rotation, Time.deltaTime * speedRotation);

        float? angel = RotateTurret();

        if(angel != null && Vector3.Angle(direction, parent.transform.forward) < 10)
            Fire();
    }

    private float? RotateTurret() 
    {
        float? angel = CalucaleAngel(true);

        if(angel != null) 
        {
            this.transform.localEulerAngles = new Vector3(360f - (float)angel, 0f, 0f);
        }
        return angel;
    } 

    private float? CalucaleAngel(bool low) 
    {
        Vector3 direction = target.transform.position - parent.transform.position;
        float y = direction.y;
        direction.y = 0;
        float x = direction.magnitude;
        float gravity = 9.81f;
        float sSqr = speed * speed;
        float underTheSqrRoot = (sSqr * sSqr) - gravity * (gravity * x * x + 2 * y * sSqr);


        if(underTheSqrRoot >= 0f) 
        {
            float root = Mathf.Sqrt(underTheSqrRoot);
            float hightAngel = sSqr + root;
            float lowAngel = sSqr - root;

            if (low)
                return Mathf.Atan2(lowAngel, gravity * x) * Mathf.Rad2Deg;
            else
                return Mathf.Atan2(hightAngel, gravity * x) * Mathf.Rad2Deg;
        }
        else
            return null;
    }
}
