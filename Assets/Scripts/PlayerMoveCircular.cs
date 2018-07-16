using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveCircular : MonoBehaviour {

    public static float moveDistance;
    public float distMultiplier;

    void RotateByDice()
    {
        if (Dice.pressed)
        {
            if(gameObject.name == PlayerTurns.playerName) // define player for turn
            {
                moveDistance = Dice.randNum * distMultiplier;
                transform.RotateAround(Vector3.zero, Vector3.back, moveDistance);
                Dice.pressed = false;
            }
        }
    }

    void Update()
    {
        RotateByDice();
    }
}
