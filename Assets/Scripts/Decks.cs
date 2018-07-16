using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decks : MonoBehaviour {

    public GameObject[] blueDeck, greenDeck, redDeck, yellowDeck, purpleDeck;
    public static GameObject blueCard, greenCard, redCard, yellowCard, purpleCard;

    private void Start()
    {
        SelectRandom();
    }

    void SelectRandom ()    // selects random card from the deck
    {
        blueCard = blueDeck[Random.Range(0, blueDeck.Length)];
        blueCard.SetActive(false);

        greenCard = greenDeck[Random.Range(0, greenDeck.Length)];
        greenCard.SetActive(false);

        redCard = redDeck[Random.Range(0, redDeck.Length)];
        redCard.SetActive(false);

        yellowCard = yellowDeck[Random.Range(0, yellowDeck.Length)];
        yellowCard.SetActive(false);

        purpleCard = purpleDeck[Random.Range(0, purpleDeck.Length)];
        purpleCard.SetActive(false);
    }
}
