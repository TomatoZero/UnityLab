using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour 
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private GameObject shield;

    private static int elientDead;
    private static int shieldBroken;
    private static int totalScore;

    public void AddScore(GameObject gameObject) 
    {
        if (gameObject == enemy.gameObject)
        {
            elientDead++;
            totalScore++;
        }
        else if (gameObject == shield.gameObject)
        {
            shieldBroken ++;
            totalScore += 9;
        }

        Debug.Log("Total score: " + totalScore);
    }
}
