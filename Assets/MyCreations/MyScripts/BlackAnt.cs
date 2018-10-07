using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackAnt : FriendlyBehaviour {

    GameObject neutralRP;
    GameObject enemyRP;


	void Start () {

        neutralRP = GameObject.Find("NeuralResourcePile");
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
            if(neutralRP == null)
            {
                targetObject = enemyRP;
            }
            else
            {
                targetObject = neutralRP;
            }
        }

        // this is if the ant has made it to the objective and is heading back to spawn the ant should be carrying an item for visual.
        if (objectiveReached == true && targetReached == true)
        {
            targetObject = GameObject.FindWithTag("PlayerObjective");
        }

    }


    //the trigger should only test for objectives
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
        if (other.gameObject.tag == "PlayerObjective")
        {
            targetReached = false;
            objectiveReached = false;
            LocateTarget();
        }

    }

    private void OnColliderEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            antHealth -= 1;
        }
    }


}
