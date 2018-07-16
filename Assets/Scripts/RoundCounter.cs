using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundCounter : MonoBehaviour {

    public static int turnCount = 0, roundCount = 0;

    void IncreaseTurnCount()
    {
        if (Dice.pressed)
        {
            turnCount++;
        }
    }

    void IncreaseRoundCount()
    {
        if(turnCount>0 && turnCount%4 == 0)   // only show the card when the player is on the space the first time
        {
            print(roundCount);
            roundCount++;                       // show card for each player when it's the next round REF: ShowCards script
            turnCount = 0;
        }
    }

    void Update()
    {
        IncreaseRoundCount();
        //IncreaseTurnCount();
    }
}
