using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackAnt : FriendlyBehaviour {

	


	void Start () {
        
	}

    // Update is called once per frame
    void Update()
    {

        LocateTarget();    
        MoveTowardTarget();
        HealthCheck();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            antHealth -= 1;
        }
    }


}
