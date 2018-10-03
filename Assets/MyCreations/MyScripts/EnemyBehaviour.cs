using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyBehaviour : MonoBehaviour
{
   
    
    public int antHealth;
    public float movementSpeed;
    public float distanceToTarget;
    public float attackBumpEffect;

    public bool targetReached = false;
    public bool objectiveReached = false;
    public GameObject targetObject;
    public GameObject[] firstPointsOfInterest = new GameObject[5];

    public virtual void LocateFirstTarget()
    {

        firstPointsOfInterest[0] = GameObject.Find("PointA");
        firstPointsOfInterest[1] = GameObject.Find("PointB");
        firstPointsOfInterest[2] = GameObject.Find("PointC");
        firstPointsOfInterest[3] = GameObject.Find("PointD");
        firstPointsOfInterest[4] = GameObject.Find("PointE");

        targetObject = firstPointsOfInterest[Random.Range(0, 5)];
    }

    public virtual void HealthCheck()
    {
        if (antHealth <= 0)
        {
            Destroy(gameObject);
        }
    }



}


