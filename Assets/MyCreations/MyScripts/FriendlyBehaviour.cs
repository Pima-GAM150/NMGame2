using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FriendlyBehaviour : MonoBehaviour {

    public int antHealth;
    public float movementSpeed;
    public float distanceToTarget;

    public bool targetReached = false;
    public bool objectiveReached = false;
    public GameObject targetObject;
    public GameObject[] firstPointsOfInterest = new GameObject[5];

    public virtual void LocateTarget()
    {

        firstPointsOfInterest[0] = GameObject.FindWithTag("Enemy");
        firstPointsOfInterest[1] = GameObject.FindWithTag("Enemy");
        firstPointsOfInterest[2] = GameObject.FindWithTag("Enemy");
        firstPointsOfInterest[3] = GameObject.FindWithTag("Enemy");
        firstPointsOfInterest[4] = GameObject.FindWithTag("Enemy");


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
        dirctToTarget.y = 0;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(dirctToTarget), 0.1f);
        //end



        transform.position = Vector3.MoveTowards(transform.position, targetObject.transform.position, step);
        //anim.SetBool("isRunning", true);
        //anim.SetBool("isIdle", false);
    }




}
