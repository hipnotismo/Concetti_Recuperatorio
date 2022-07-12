using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

     public int ballState;

    [SerializeField] BallMovement _ballMovement;
    [SerializeField] BallMovement _ballMovementTwo;
    [SerializeField] BallMovement _ballMovementThree;
    [SerializeField] BallMovement _ballMovementFour;



    void Start()
    {
      //  _ballMovement = MovementOne();
        ballState = 1;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ballState = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ballState = 2;
        }
    }

    private void OnMouseDown()
    {
        CreateBalls();
    }

    void CreateBalls()
    {
       // Instantiate(ball);
        
        if (ballState == 1)
        {
            Debug.Log("Es uno: " + ballState);
            _ballMovement.movement();
        }
        else
        {
            Debug.Log("Es Dos: " + ballState);
            _ballMovement.movement();
            _ballMovementTwo.movement();
            _ballMovementThree.movement();
            _ballMovementFour.movement();

        }
    }
}
