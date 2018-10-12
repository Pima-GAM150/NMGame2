using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FriendlySpawn : MonoBehaviour {

    public GameObject friendlyUnit;
    public GameObject friendlySoldier;
    public Button spawnButton;

    public enum State {SpawnActive, SpawnInactive };
    public State SpawnsButtonState;

    int seconds = 1;
    	
   public void SpawnUnits()
    {
        Instantiate(friendlyUnit, transform.position, transform.rotation);
        StartCoroutine(EnableAfterSeconds(seconds));
        SpawnsButtonState = State.SpawnInactive;
    }

    public void SpawnSoldiers()
    {
        Instantiate(friendlySoldier, transform.position, transform.rotation);
        StartCoroutine(EnableAfterSeconds(seconds));
        SpawnsButtonState = State.SpawnInactive;
    }

    IEnumerator EnableAfterSeconds(int seconds)
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            SpawnsButtonState = State.SpawnActive;
        }
    }

    public void Update()
    {
         
        if (SpawnsButtonState == State.SpawnInactive)
        {
            spawnButton.enabled = false;
        }
        else
        {
            spawnButton.enabled = true;
        }
    }



}
