using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncreaseScores : MonoBehaviour {

    public Text blueScoreText, greenScoreText, redScoreText, yellowScoreText;
    int blueScore, greenScore, redScore, yellowScore;

    void UpdateScores()
    {
        if (PlayerTurns.playerName == "Blue Player" && ShowCards.answered && Decks.result == "Correct")
        {
            blueScore++;
        }
        else if (PlayerTurns.playerName == "Green Player" && ShowCards.answered && Decks.result == "Correct")
        {
            greenScore++;
        }
        else if (PlayerTurns.playerName == "Red Player" && ShowCards.answered && Decks.result == "Correct")
        {
            redScore++;
        }
        else if (PlayerTurns.playerName == "Yellow Player" && ShowCards.answered && Decks.result == "Correct")
        {
            yellowScore++;
        }
    }

    void UpdateScoreTexts()
    {
        blueScoreText.text = blueScore.ToString();
        greenScoreText.text = greenScore.ToString();
        redScoreText.text = redScore.ToString();
        yellowScoreText.text = yellowScore.ToString();
    }

    private void Update()
    {
        UpdateScores();
        UpdateScoreTexts();   
    }
}
