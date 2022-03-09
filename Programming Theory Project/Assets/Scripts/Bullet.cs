using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]

/// <summary>
/// Base class for Bullets
/// </summary>
public class Bullet : TheGame // INHERITANCE
{
    private GameObject[] targets = new GameObject [3]; // array that will host all targets supposing they are only 3

    public override void OnMouseDown()  // POLYMORPHISM
    {        
        Debug.Log("Clicked:" + gameObject.name);

        // create an array of targets in scene (supposing they have been tagged as "Target")
        targets = GameObject.FindGameObjectsWithTag("Target");

        // move the bullet toward the last target in the array
        GoTo(gameObject, targets[2]);
        
    }
}
