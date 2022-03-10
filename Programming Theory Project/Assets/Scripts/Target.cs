using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]

/// <summary>
/// Base class for Targets
/// </summary>
public class Target : TheGame // INHERITANCE
{
    private float x;
    
    public override void Yoyo() // POLYMORPHISM
    {
        x =  -20  + Mathf.PingPong(Time.time * phaseX, 40);
        transform.position = new Vector3(startPos.x + x, transform.position.y , transform.position.z);       
    }

    public void Update()
    {
        Yoyo();
    }


}
