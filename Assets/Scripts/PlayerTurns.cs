using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTurns : MonoBehaviour {

    public static string playerName;
    public Text turnPlayer;

    public GameObject cardsManager;
    GameObject resultCard; Text resultCardText;
    public float resultCardTimer = 1.00f;    // how long the result card is displayed before disappearing

    public GameObject[] players;
    ShowCards tags;

    private void Start()
    {
        playerName = "Blue";
        players = GameObject.FindGameObjectsWithTag("Player");

        resultCard = cardsManager.GetComponent<ResultCard>().resultCardBG;
        resultCard.SetActive(false);
        resultCardText = resultCard.GetComponentInChildren<Text>();

        foreach (GameObject player in players)
        {
            tags = player.GetComponent<ShowCards>();
        }
    }

    void DecreaseTimer()
    {
        if (resultCardTimer >= 0.00f)
        {
            resultCardTimer -= Time.deltaTime;
        }
        else
        {
            resultCardTimer = 0.00f;
            resultCard.SetActive(false);
        }
    }

    void DisplayResult()
    {
        resultCardTimer = 1.00f;

        resultCard.SetActive(true);
        resultCardText.text = Decks.result.ToString(); // display if answer is correct/incorrect
    }

    void DisplayTurnPlayer()
    {
        turnPlayer.text = playerName.ToString() + "'s" + " Turn";
    }

    void OnEachTurn()
    {
        tags.setTagsActive(false);
        RoundCounter.turnCount++;
        ShowCards.answered = false;

        DisplayResult();
    }

    void ChangeTurn()
    {
        if (playerName == "Blue")
        {
            DisplayTurnPlayer();

            if (ShowCards.answered)
            {
                OnEachTurn();
                playerName = "Green";        // switch to the next player
            }
        }
        if (playerName == "Green")
        {
            DisplayTurnPlayer();

            if (ShowCards.answered)
            {
                OnEachTurn();
                playerName = "Red";        // switch to the next player
            }
        }
        if (playerName == "Red")
        {
            DisplayTurnPlayer();

            if (ShowCards.answered)
            {
                OnEachTurn();
                playerName = "Yellow";        // switch to the next player
            }
        }
        if (playerName == "Yellow")
        {
            DisplayTurnPlayer();

            if (ShowCards.answered)
            {
                OnEachTurn();
                playerName = "Blue";        // switch to the next player
            }
        }
    }

    private void Update()
    {
        DecreaseTimer();
        ChangeTurn();
    }
}
