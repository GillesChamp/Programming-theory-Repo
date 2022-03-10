
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Rigidbody))]

/// <summary>
/// Base class for all  components. 
/// This is a concepts game consisting in a green ball, some moving obstacles and a moving target.
/// Clicking on the ball it will fire toward the target
/// </summary>
public class TheGame : MonoBehaviour // ABSTRACTION
{
    private static float multiplier = 180.0f;
    protected Rigidbody myRB;
    protected Vector3 startPos;
    protected float phaseX;

    public static float Multiplier  // ENCAPSULATION
    {
        get
        {
            return multiplier;
        }
        set
        {
            if ((value > 80f) && (value <= 250f))
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
        phaseX = Random.Range(5, 20);
        startPos = transform.position;
    }
    public void GoTo(GameObject source, GameObject target)
    {
        if ((target != null) && (source != null))
        {
            print("Pushing the " + source.name + " toward the " + target.name + " with multiplier = " + multiplier);
            Vector3 direction = (target.transform.position - source.transform.position).normalized;
            myRB.AddForce(direction * multiplier / myRB.mass, ForceMode.Impulse);
        }
    }
    public virtual void OnMouseDown()
    {
        // default behaviour       
        Debug.Log("Clicked:" + gameObject.name);
    }
    public virtual void Yoyo()
    {
        transform.position = new Vector3(startPos.x - 30 + Mathf.PingPong(Time.time * phaseX, 60), transform.position.y, transform.position.z);
    }


}

