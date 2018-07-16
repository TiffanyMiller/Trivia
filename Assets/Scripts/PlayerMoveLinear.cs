using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMoveLinear : MonoBehaviour {

    public float moveDistance;
    Vector3 moveDirection;

    void MoveInLine()
    {
        moveDirection = Vector3.right;

        if (Dice.pressed)//button pressed is true
        {
            moveDistance = Dice.randNum;
            transform.Translate(moveDirection * moveDistance / 0.85f);
            Dice.pressed = false;
        }
    }

    private void Update()
    {
        MoveInLine();
    }
}
