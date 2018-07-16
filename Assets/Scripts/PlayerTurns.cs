using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurns : MonoBehaviour {

    public static string playerName;
    public GameObject cardsManager;

    public GameObject[] players;
    ShowCards tags;

    private void Start()
    {
        playerName = "Blue Player";
        players = GameObject.FindGameObjectsWithTag("Player");

        foreach (GameObject player in players)
        {
            tags = player.GetComponent<ShowCards>();
        }
    }

    void OnEachTurn()
    {
        tags.setTagsActive(false);
        RoundCounter.turnCount++;
        ShowCards.answered = false;
        print(RoundCounter.turnCount);
    }

    private void Update()
    {
        if(playerName == "Blue Player")
        {
            if (ShowCards.answered)
            {
                OnEachTurn();
                playerName = "Green Player";        // switch to the next player
            }
        }
        if(playerName == "Green Player")
        {
            if (ShowCards.answered)
            {
                OnEachTurn();
                playerName = "Red Player";        // switch to the next player
            }
        }
        if (playerName == "Red Player")
        {
            if (ShowCards.answered)
            {
                OnEachTurn();
                playerName = "Yellow Player";        // switch to the next player
            }
        }
        if (playerName == "Yellow Player")
        {
            if (ShowCards.answered)
            {
                OnEachTurn();
                playerName = "Blue Player";        // switch to the next player
            }
        }
    }
}
