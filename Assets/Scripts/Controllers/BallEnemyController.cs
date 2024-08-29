using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallEnemyController : AbstractEnemyController
{
    private int upDown = 1;

    public int bounceSpeed = 5;

    void Update()
    {
        if (upDown == 1) {
            transform.Translate(Vector3.up * Time.deltaTime * bounceSpeed);
            upDown = 0;
        } else {
            transform.Translate(Vector3.down *  Time.deltaTime * bounceSpeed);
            upDown = 1;
        }
        
    }
}
