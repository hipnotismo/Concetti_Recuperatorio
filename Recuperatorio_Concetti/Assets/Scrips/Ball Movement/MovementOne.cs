using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class MovementOne : BallMovement
{
    [SerializeField]GameObject ball;

    public override void movement()
    {
        Debug.Log("Estas en MovementOne");
        //transform.position += new Vector3(5, 0, 0) * Time.deltaTime;
     //   ball = Resources.Load<GameObject>("Assets/Resources/Sphere") as GameObject;
        Instantiate(ball);
    }
}
