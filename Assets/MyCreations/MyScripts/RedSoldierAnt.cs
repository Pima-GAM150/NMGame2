using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedSoldierAnt : EnemyBehaviour, ITakeDamage {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        LocateAFriendlyToAttack();
        MoveTowardTarget();
        HealthCheck();
	}
    

   
}
