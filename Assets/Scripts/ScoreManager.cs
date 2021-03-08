using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private Text textScore;
    [SerializeField] private Text textHiScore;
    
    private string scoreBase = "SCORE\n";
    private string hiScoreBase = "HI-SCORE\n";
    private int score = 0;
    private int hiScore = 0;


    
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        hiScore = 0;
        RefreshScore(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RefreshScore(int points)
    {
        score += points;
        textScore.text = scoreBase + score.ToString("D4");

        if(hiScore <= score)
        {
            hiScore = score;
            textHiScore.text = hiScoreBase + hiScore.ToString("D4");
        }
    }

    public void NewGame()
    {

    }


}
