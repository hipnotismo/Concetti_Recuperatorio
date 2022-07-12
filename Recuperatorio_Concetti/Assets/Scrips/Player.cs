using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] GameObject ball;
    int ballState;

    void Start()
    {
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
        Instantiate(ball);
        if (ballState == 1)
        {
            Debug.Log("Es uno: " + ballState);
        }
        else
        {
            Debug.Log("Es Dos: " + ballState);

        }
    }
}
