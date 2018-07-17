using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultCard : MonoBehaviour {

    public GameObject resultCardBG;
    public Text resultText;

    private void Update()
    {
        resultText.text = Decks.result.ToString(); 
    }
}
