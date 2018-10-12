using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyBehaviour : MonoBehaviour
{
   
    
    public int antHealth;
    public float movementSpeed;
    float distanceToTarget;
   

    public bool targetReached = false;
    public bool objectiveReached = false;    
    public GameObject targetObject;
    public GameObject[] pointsOfInterest = new GameObject[5];
    public GameObject[] resourcesToCollect = new GameObject[5];

    public virtual void LocateFirstTarget()
    {        

        pointsOfInterest[0] = GameObject.Find("PointA");
        pointsOfInterest[1] = GameObject.Find("PointB");
        pointsOfInterest[2] = GameObject.Find("PointC");
        pointsOfInterest[3] = GameObject.Find("PointD");
        pointsOfInterest[4] = GameObject.Find("PointE");

        targetObject = pointsOfInterest[Random.Range(0, 5)];
    }

    public virtual void LocateAFriendlyToAttack()
    {
        int index;
        for (index = 0; index < 5; index++)
        {
            pointsOfInterest[index] = FindObjectOfType<FriendlyBehaviour>().gameObject;
        }

        targetObject = pointsOfInterest[Random.Range(0, 5)];

    }

    public virtual void MoveTowardTarget()
    {
        float step = movementSpeed * Time.deltaTime;

        //this code makes the asset look at the target witht eh axis in the 2nd line
        Vector3 dirctToTarget = targetObject.transform.position - transform.position;
        
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(dirctToTarget), 0.1f);
        //end


        //move toward the target object at the rate of the "step"
        transform.position = Vector3.MoveTowards(transform.position, targetObject.transform.position, step);
       
    }

    public virtual void HealthCheck()
    {
        if (antHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public virtual void TakeDamage(int damage)
    {
        antHealth -= damage;
        if (antHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.GetComponent<FriendlyBehaviour>())
        {
            TakeDamage(1);
        }
    }

}


