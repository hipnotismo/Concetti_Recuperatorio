using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ballMovement();
        // transform.position += new Vector3(5, 0, 0) * Time.deltaTime;
        Destroy(gameObject,1f);
    }

    void ballMovement()
    {

    }
}
