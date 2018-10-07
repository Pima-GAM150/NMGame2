using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedAnt : EnemyBehaviour, ITakeDamage {

    GameObject playerRP;
    GameObject neutralRP;

    // Use this for initialization
    void Start () {

        playerRP = GameObject.Find("PlayerResourcePile");
        neutralRP = GameObject.Find("NeutralResourcePile");

        LocateFirstTarget();


    }
	
	// Update is called once per frame
	void Update () {
        MoveTowardTarget();
        LocatethePrimaryObjective();
        HealthCheck();
	}  

   

    void LocatethePrimaryObjective()
    {

        if (targetReached == true)
        {
            if (neutralRP == null)
            {
                targetObject = playerRP;
            }
            else
            {
                targetObject = neutralRP;
            }
        }
        
        // this is if the ant has made it to the objective and is heading back to spawn the ant should be carrying an item for visual.
        if (objectiveReached == true)
        {
            targetObject = GameObject.FindWithTag("EnemyObjective");
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
        if (other.gameObject.tag == "EnemyObjective")
        {
            targetReached = false;
            objectiveReached = false;
            LocateFirstTarget();
        }                    

    }

   



    
}



