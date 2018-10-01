using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TurretBehaviour : MonoBehaviour {

    public GameObject targetEnemy;
    public GameObject projectile;

    public float speedofProjectile;
    public float rateofFire;
    public float timeBetweenProjectiles;
    public bool isEnemyInSights = false;

    public virtual void AimAtEnemytoShoot()
    {
        Vector3 dirctToTarget = targetEnemy.transform.position - transform.position;
        dirctToTarget.y = 0;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(dirctToTarget), 0.1f);
    }

    private void OnTriggerStay(Collider inTargetRange)
    {

        if (inTargetRange.gameObject.tag == "Ant")
        {
            targetEnemy = inTargetRange.gameObject;
            isEnemyInSights = true;
        }        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Ant")
        {

            isEnemyInSights = false;
        }
    }

}
