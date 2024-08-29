using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySquare : EnemyAbstract
{
    protected override void HitBehaviour(int strengh)
    {
        
    }

    protected override void TakeDamageBehaviour(int damage)
    {
        enemyName = "Square";
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
