using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InputAnswers : MonoBehaviour {

    public bool correct;

    public void getBtnText(Button button)
    {
        if (correct)
        {
            Decks.result = "Correct";       // called in PlayerTurns at end of each turn
            print("'" + button.name + "'" + " is correct");
        }
        else
        {
            Decks.result = "Incorrect";
            print("'" + button.name + "'" + " is incorrect");
        }
    }
}
