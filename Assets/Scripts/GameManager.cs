using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private ScoreManager scoreManager;
 
    // Start is called before the first frame update
     void Start()
    {
        
    }

    public void EnemyHit(Enemy enemy)
    {
        scoreManager.RefreshScore(enemy.scoreValue);
    }
}
