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
    public Text PlayerText;
    public Text EnemyText;

	
	void Start () {
        singleton = this;
	}
	
	void Update () {
        
        VictoryPointCheck();
        //PlayerText.text = (string)playerCurrentPoints;
        //EnemyText. = enemyCurrentPoints;

	}
     
    void VictoryPointCheck()
    {

        if (enemyCurrentPoints >= 20)
        {
            victoryBanner.text = "You lose";
        }

        if (playerCurrentPoints >= 20)
        {
            victoryBanner.text = "You win";
        }
    }

    public void TakeResources(int pointToTake)
    {
        numOfPointsForVictory -= pointToTake;
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
