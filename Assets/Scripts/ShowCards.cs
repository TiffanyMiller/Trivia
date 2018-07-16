using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowCards : MonoBehaviour {

    public GameObject blueCardBG, greenCardBG, redCardBG, yellowCardBG, purpleCardBG;
    GameObject[] blueTags, greenTags, redTags, yellowTags, purpleTags;

    bool onBlue, onGreen, onRed, onYellow, onPurple;

    public Button answeredBtn;
    public static bool answered;

    private void Awake()
    {
        Initialising();
    }

    private void Start()
    {
        answeredBtn.onClick.AddListener(setCardsInactive);
        setTagsActive(false);  // this is so the card doesn't show at the start of the game
    }

    void Initialising()
    {
        blueCardBG.SetActive(false);
        blueTags = GameObject.FindGameObjectsWithTag("blue");

        greenCardBG.SetActive(false);
        greenTags = GameObject.FindGameObjectsWithTag("green");

        redCardBG.SetActive(false);
        redTags = GameObject.FindGameObjectsWithTag("red");

        yellowCardBG.SetActive(false);
        yellowTags = GameObject.FindGameObjectsWithTag("yellow");

        purpleCardBG.SetActive(false);
        purpleTags = GameObject.FindGameObjectsWithTag("purple");

        answeredBtn.gameObject.SetActive(false);
    }

    public void setTagsActive(bool activeTag)
    {
        if (activeTag)
        {
            foreach (GameObject blueTag in blueTags)
            {
                blueTag.SetActive(true);
            }
            foreach (GameObject greenTag in greenTags)
            {
                greenTag.SetActive(true);
            }
            foreach (GameObject redTag in redTags)
            {
                redTag.SetActive(true);
            }
            foreach (GameObject yellowTag in yellowTags)
            {
                yellowTag.SetActive(true);
            }
            foreach (GameObject purpleTag in purpleTags)
            {
                purpleTag.SetActive(true);
            }
        }
        else
        {
            foreach (GameObject blueTag in blueTags)
            {
                blueTag.SetActive(false);
            }
            foreach (GameObject greenTag in greenTags)
            {
                greenTag.SetActive(false);
            }
            foreach (GameObject redTag in redTags)
            {
                redTag.SetActive(false);
            }
            foreach (GameObject yellowTag in yellowTags)
            {
                yellowTag.SetActive(false);
            }
            foreach (GameObject purpleTag in purpleTags)
            {
                purpleTag.SetActive(false);
            }
        }
    }

    void ActivateBtn(bool activeBtn)
    {
        if (activeBtn)
        {
            answeredBtn.gameObject.SetActive(true);     // player must click 'done' to ensure when it is the next player's turn
            answered = false;       // ref PlayerTurns script
        }
        else
        {
            answeredBtn.gameObject.SetActive(false);    // hide button until card is shown again
            answered = true;        // ref PlayerTurns script
        }

    }

    void setCardsInactive()
    {
        if (onBlue)
        {
            blueCardBG.SetActive(false);     // shows the card background when a player lands on a colour
            Decks.blueCard.SetActive(false);     // shows the question texts
        }
        else if (onGreen)
        {
            greenCardBG.SetActive(false);     // shows the card background when a player lands on a colour
            Decks.greenCard.SetActive(false);     // shows the question texts
        }
        else if (onRed)
        {
            redCardBG.SetActive(false);     // shows the card background when a player lands on a colour
            Decks.redCard.SetActive(false);     // shows the question texts
        }
        else if (onYellow)
        {
            yellowCardBG.SetActive(false);     // shows the card background when a player lands on a colour
            Decks.yellowCard.SetActive(false);     // shows the question texts
        }
        else if (onPurple)
        {
            purpleCardBG.SetActive(false);     // shows the card background when a player lands on a colour
            Decks.purpleCard.SetActive(false);     // shows the question texts
        }
        ActivateBtn(false);
    }

    void setCardsActive()
    {
        if (onBlue)
        {
            blueCardBG.SetActive(true);     // shows the card background when a player lands on a colour
            Decks.blueCard.SetActive(true);     // shows the question texts
        }
        else if (onGreen)
        {
            greenCardBG.SetActive(true);     // shows the card background when a player lands on a colour
            Decks.greenCard.SetActive(true);     // shows the question texts
        }
        else if (onRed)
        {
            redCardBG.SetActive(true);     // shows the card background when a player lands on a colour
            Decks.redCard.SetActive(true);     // shows the question texts
        }
        else if (onYellow)
        {
            yellowCardBG.SetActive(true);     // shows the card background when a player lands on a colour
            Decks.yellowCard.SetActive(true);     // shows the question texts
        }
        else if (onPurple)
        {
            purpleCardBG.SetActive(true);     // shows the card background when a player lands on a colour
            Decks.purpleCard.SetActive(true);     // shows the question texts
        }
        ActivateBtn(true);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "blue" && 
            gameObject.name == PlayerTurns.playerName)   // define player name when it's their turn)    
        {
            onBlue = true; onGreen = false; onRed = false; onYellow = false; onPurple = false;
            setCardsActive();
        }
        if (other.gameObject.tag == "green" &&
            gameObject.name == PlayerTurns.playerName)   // define player name when it's their turn)    
        {
            onBlue = false; onGreen = true; onRed = false; onYellow = false; onPurple = false;
            setCardsActive();
        }
        if (other.gameObject.tag == "red" &&
            gameObject.name == PlayerTurns.playerName)   // define player name when it's their turn)    
        {
            onBlue = false; onGreen = false; onRed = true; onYellow = false; onPurple = false;
            setCardsActive();
        }
        if (other.gameObject.tag == "yellow" &&
            gameObject.name == PlayerTurns.playerName)   // define player name when it's their turn)    
        {
            onBlue = false; onGreen = false; onRed = false; onYellow = true; onPurple = false;
            setCardsActive();
        }
        if (other.gameObject.tag == "purple" &&
            gameObject.name == PlayerTurns.playerName)   // define player name when it's their turn)    
        {
            onBlue = false; onGreen = false; onRed = false; onYellow = false; onPurple = true;
            setCardsActive();
        }
    }
}
