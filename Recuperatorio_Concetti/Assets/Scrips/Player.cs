using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] GameObject ball;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
    }

    private void OnMouseDown()
    {
        CreateBalls();
    }

    void CreateBalls()
    {
        Instantiate(ball);
    }
}
