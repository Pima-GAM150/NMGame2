using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FriendlyBehaviour : MonoBehaviour {

    public int antHealth;
    public float movementSpeed;
    float distanceToTarget;

    public bool targetReached = false;
    public bool objectiveReached = false;
    public GameObject targetObject;
    public GameObject[] firstPointsOfInterest;

    public virtual void LocateTarget()
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

    public virtual void MoveTowardTarget()
    {
        float step = movementSpeed * Time.deltaTime;

        //this code makes the asset look at the target witht eh axis in the 2nd line
        Vector3 dirctToTarget = targetObject.transform.position - transform.position;
        
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(dirctToTarget), 0.1f);
        //end
        transform.position = Vector3.MoveTowards(transform.position, targetObject.transform.position, step);
        
    }

    public virtual void IdleMotion()
    {
        transform.Rotate(0, 0.3f, 0);
    }

    public virtual void TakeDamage(int damage)
    {
        antHealth -= damage;
        if (antHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

}
