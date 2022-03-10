using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]

/// <summary>
/// Base class for Obstacles
/// </summary>
public class Obstacle : TheGame // INHERITANCE
{
    public void Update()
    {
        Yoyo();
    }
}
