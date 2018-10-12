using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static GameManager singleton;

    public int playerCurrentPoints;
    public int enemyCurrentPoints;
    public int numOfPointsForVictory = 20;
    public Text victoryBanner;

	
	void Start () {
        singleton = this;
	}
	
	void Update () {
        
        VictoryPointCheck();
	}
     
    void VictoryPointCheck()
    {

        if (enemyCurrentPoints == 20)
        {
            //victoryBanner = "You lose";
        }

        if (playerCurrentPoints == 20)
        {
            //player wins
        }
    }

    public void AddPlayerPoints(int pointAdded)
    {
        playerCurrentPoints += pointAdded;
    }
    public void AddEnemyPoints(int pointAdded)
    {
        enemyCurrentPoints += pointAdded;
    }
    public void SubPlayerPoints(int pointsTaken)
    {
        playerCurrentPoints -= pointsTaken;
    }
    public void SubEnemyPoints(int pointsTaken)
    {
        enemyCurrentPoints -= pointsTaken;
    }

}
