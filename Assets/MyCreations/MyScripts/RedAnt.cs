using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedAnt : EnemyBehaviour {

    static Animator anim;

    // Use this for initialization
    void Start () {
        LocateFirstTarget();


    }
	
	// Update is called once per frame
	void Update () {
        MoveTowardTarget();
        LocatethePrimaryObjective();
            
	}

    void LocateFirstTarget()
    {

        firstPointsOfInterest[0] = GameObject.Find("PointA");
        firstPointsOfInterest[1] = GameObject.Find("PointB");
        firstPointsOfInterest[2] = GameObject.Find("PointC");
        firstPointsOfInterest[3] = GameObject.Find("PointD");
        firstPointsOfInterest[4] = GameObject.Find("PointE");

        targetObject = firstPointsOfInterest[Random.Range(0, 5)];
    }

    void MoveTowardTarget()
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

   

    void LocatethePrimaryObjective()
    {       

        if (targetReached == true)
        {
            targetObject = GameObject.FindWithTag("Objective");
            
                    
        }      
        
        if (objectiveReached == true)
        {
            targetObject = GameObject.FindWithTag("SpawnPoint");
        }
        
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
        if (other.gameObject.tag == "SpawnPoint")
        {
            targetReached = false;
            objectiveReached = false;
            LocateFirstTarget();
        }

    }




}
