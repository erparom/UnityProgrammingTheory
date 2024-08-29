using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeEnemyController : AbstractEnemyController
{
    public int rotationSpeed = 20;
    void Update()
    {
        transform.Rotate(new Vector3(1,1,0), Time.deltaTime * rotationSpeed);
    }
}
