using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackAnt : FriendlyBehaviour, ITakeDamage
{

    GameObject neutralRP;
    GameObject enemyRP;


	void Start () {

        neutralRP = GameObject.Find("NeutralResourcePile");
        enemyRP = GameObject.Find("EnemyResourcePile");
        
	}

    // Update is called once per frame
    void Update()
    {
        if (targetObject == null || firstPointsOfInterest == null)
        {
            LocateTarget();
            
        }

        MoveTowardTarget();
        HealthCheck();
        LocatethePrimaryObjective();

    }

    void LocatethePrimaryObjective()
    {
        //after the ant has made it to the random point of interest it will then head to the neutral resource pile
        //if there is no neutral resource pile then this unit will go after the enemy pile.
        if (targetReached == true)
        {
            if (neutralRP == null)
            {
                targetObject = enemyRP;
            }
            else
            {
                targetObject = neutralRP;
            }
        }

        // this is if the ant has made it to the objective and is heading back to spawn the ant should be carrying an item for visual.
        if (objectiveReached == true)
        {
            targetObject = GameObject.FindWithTag("PlayerObjective");
        }

        // this is if the ant has made it to the objective and is heading back to spawn the ant should be carrying an item for visual.
        //if (objectiveReached == true && targetReached == true)
        //{
        //    targetObject = 
        //}

    }


    //the trigger should only test for objectives
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "TurnPoint")
        {
            targetReached = true;
        }
        if (other.gameObject.tag == "Objective" || other.gameObject.tag == "EnemyObjective")
        {
            objectiveReached = true;
        }
        if (other.gameObject.tag == "PlayerObjective")
        {
            targetReached = false;
            objectiveReached = false;
            LocateTarget();
        }

    }

   
}

