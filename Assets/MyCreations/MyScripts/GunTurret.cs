using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunTurret : TurretBehaviour {

    
    public Transform turretProjectiveExitSpot;


	void Start () {
        turretCurrentHP = turrentMaxHP;
        IdleTurretMotion();
		
	}
	
	// Update is called once per frame
	void Update () {

        if (targetEnemy != null)
        {
            AimAtEnemytoShoot();
            if (isEnemyInSights == true)
            {

                ShootAtEnemyWithBullets();
            }
        }
        else
        {
            IdleTurretMotion();
        }

    }

    void ShootAtEnemyWithBullets()
    {
        StartCoroutine(ShootAfterSeconds((int)rateofFire));          
        
    }

    IEnumerator ShootAfterSeconds(int rateofFire)
    {
        while (true)
        {
          
            yield return new WaitForSeconds(rateofFire);

            Rigidbody projectileClone;
            projectileClone = Instantiate(projectile.GetComponent<Rigidbody>(), turretProjectiveExitSpot.position, turretProjectiveExitSpot.rotation) as Rigidbody;
            projectileClone.velocity = transform.TransformDirection(Vector3.forward * speedofProjectile);


        }

    }







    
    

   
}
