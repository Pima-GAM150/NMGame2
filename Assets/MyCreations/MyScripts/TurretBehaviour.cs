using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TurretBehaviour : MonoBehaviour {

    public GameObject targetEnemy;
    public GameObject projectile;

    public int turretCurrentHP;
    public int turrentMaxHP;

    //public enum State { Damaged, MaxStrength };
    //public State turrentsHPstate;

    public float speedofProjectile;
    public float rateofFire;
    public float timeBetweenProjectiles;
    public bool isEnemyInSights = false;

    // set up as a if then in the lower classes
    public virtual void IdleTurretMotion()
    {
        //if (targetEnemy == null)
        transform.Rotate(0, 0.3f, 0);
    }

    public virtual void AimAtEnemytoShoot()
    {
        
        Vector3 dirctToTarget = targetEnemy.transform.position - transform.position;
        dirctToTarget.y = 0;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(dirctToTarget), 1f);
    }

    private void OnTriggerStay(Collider inTargetRange)
    {

        if (inTargetRange.gameObject.tag == "Enemy")
        {
            targetEnemy = inTargetRange.gameObject;
            isEnemyInSights = true;
        }        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {

            isEnemyInSights = false;
        }
    }

}
