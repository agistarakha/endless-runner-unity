using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{

    [Header("Score Highlight")]
    public int scoreHighlightRange;
    public CharacterSoundController sound;

    [Header("Collectible Reward")]
    public GameObject freezeSkillCol;

    private int lastScoreHighlight = 0;
    private int currentScore;
    // Start is called before the first frame update
    void Start()
    {
        lastScoreHighlight = 0;
        currentScore = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public float GetCurrentScore()
    {
        return currentScore;
    }
    public void IncreaseCurrentScore(int increment)
    {
        currentScore += increment;
        if (currentScore - lastScoreHighlight > scoreHighlightRange)
        {
            freezeSkillCol.SetActive(true);
            sound.PlayScoreHighlight();
            lastScoreHighlight += scoreHighlightRange;
        }
    }
    public void FinishScoring()
    {
        if (currentScore > ScoreData.highScore)
        {
            ScoreData.highScore = currentScore;
        }
    }
}
