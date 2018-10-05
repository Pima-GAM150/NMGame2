using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FriendlySpawn : MonoBehaviour {

    public GameObject friendlyUnit;  

    public enum State {SpawnActive, SpawnInactive };
    public State SpawnsButtonState;
    
    	
   public void SpawnUnits()
    {
        Instantiate(friendlyUnit, transform.position, transform.rotation);
    }




}
