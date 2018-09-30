using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyBehaviour : MonoBehaviour
{
    public GameObject targetObject;

    public GameObject[] firstPointsOfInterest = new GameObject[5];

    public float movementSpeed;
    public float distanceToTarget;

    public bool targetReached = false;
    public bool objectiveReached = false;

    void FindFirstTarget()
    {
       
    }

    void Movement()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "TurnPoint")
        {
            targetReached = true;
        }
        if (other.gameObject.tag == "Objective")
        {
            objectiveReached = true;
        }
    }




}


