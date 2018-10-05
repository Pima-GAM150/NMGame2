using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBullets : MonoBehaviour {

    public int seconds;

    private void Start()
    {
        StartCoroutine(DestroyAfterSeconds(seconds));
    }

    private void OnTriggerEnter(Collider other)
    {
        ITakeDamage damagable = other.GetComponent<ITakeDamage>();
        if (damagable != null)
        {
            damagable.TakeDamage(1);
        }
        
    }    

    IEnumerator DestroyAfterSeconds(int seconds)
    {
        while (true)
        {           
            yield return new WaitForSeconds(seconds);
            Destroy(gameObject);
        }
    }




}
