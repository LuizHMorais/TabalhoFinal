using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slug : EnemyController
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }

    void FixedUpdate()
    {
        if (isMoving)
        {
            rb2D.velocity = new Vector2(speed, rb2D.velocity.y);
        }
        
    }





}
