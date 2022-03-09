using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]

/// <summary>
/// Base class for Targets
/// </summary>
public class Target : TheGame // INHERITANCE
{
    private Vector3 startPos;
    private float k;

    public void Start()
    {
        k= Random.Range(5, 20);
        startPos = transform.position;
        print("startPos: " + startPos);
    }

    public void Update()
    {
        transform.position = new Vector3(startPos.x - 30 + Mathf.PingPong(Time.time * k, 60), transform.position.y, transform.position.z);
    }


}
