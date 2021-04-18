using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollowing : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 direction;
    public int speed;
    public float maxSpeed;

    public TargetChangeLocation targetScript;
    public Transform target;

    private Quaternion _currentAngle, _nextAngle;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        targetScript.ChangePlace();

        GetNewAngle();
    }

    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        rb.AddRelativeForce(Vector3.forward * speed, ForceMode.Force);

        if (rb.velocity.z >= maxSpeed)
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, maxSpeed);
        } 

        if (Vector3.Distance(transform.position, target.position) < 20)
        {
            rb.velocity = Vector3.zero;
            targetScript.ChangePlace();
            GetNewAngle();
        }
    }

    private void GetNewAngle()
    {
        transform.LookAt(target);
    }
}
