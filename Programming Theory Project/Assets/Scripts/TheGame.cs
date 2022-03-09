using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


[RequireComponent(typeof(Rigidbody))]

/// <summary>
/// Base class for all  components. 
/// </summary>
public abstract class TheGame : MonoBehaviour // ABSTRACTION
{
    
    private Rigidbody myRB;
    private static float multiplier = 90.0f;
    
    public  static float Multiplier  // ENCAPSULATION
    {
        get
        {
            return multiplier;
        }
        set 
        { 
            if ((value > 80f) && (value < 150f) )
            {
                multiplier = value;
                print("multiplier set to: " + multiplier);
            }
            else
            {
                print("ERROR: Multiplier must be between 80 and 150");
            }
        }
    }

    private void Awake()
    {
        myRB = GetComponent<Rigidbody>();     
    }

    protected void GoTo(GameObject source, GameObject target)
    {
        if ((target != null) && (source != null))
        {
            print("Push the " +  source.name + " toward the " + target.name + " with multiplier = " + multiplier);
            Vector3 direction = (target.transform.position - source.transform.position).normalized;
            myRB.AddForce(direction * multiplier/ myRB.mass, ForceMode.Impulse);
        }
    }

    public virtual void OnMouseDown()
    {
        // default behaviour       
        Debug.Log("Clicked:" + gameObject.name);
    }

}

