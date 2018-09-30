﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunTurret : TurretBehaviour {

    
    public Transform turretProjectiveExitSpot;


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        AimAtEnemytoShoot();

        if (isEnemyInSights == true)
        {          
           
            ShootAtEnemyWithBullets();
        }

    }

    void ShootAtEnemyWithBullets()
    {
        firingRate =- Time.deltaTime;
        if (firingRate <= 0f)
        {
            Rigidbody projectileClone;
            projectileClone = Instantiate(projectile.GetComponent<Rigidbody>(), turretProjectiveExitSpot.position, turretProjectiveExitSpot.rotation) as Rigidbody;
            projectileClone.velocity = transform.TransformDirection(Vector3.forward * rateofFire);
           firingRate = rateofFire;
        }

    }

   
}