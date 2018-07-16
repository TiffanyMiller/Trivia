using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour {

    public Text diceRollText;
    public Button diceButton;
    public static int randNum;
    public static bool pressed;

    public GameObject[] players;
    ShowCards tags;

    private void Start()
    {
        diceButton.onClick.AddListener(RandomNumber);
        players = GameObject.FindGameObjectsWithTag("Player");

        foreach (GameObject player in players)
        {
            tags = player.GetComponent<ShowCards>();
        }
    }

    public void RandomNumber()
    {
        tags.setTagsActive(true);

        randNum = Random.Range(1, 12);
        diceRollText.text = randNum.ToString();
        pressed = true;
    }
}
