﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class One_Gun_Enemy : Enemies
{
    [SerializeField]
    private GameObject One_Gun_Enemy_Bullet;

    [SerializeField]
    private GameObject Bullet_Exit_Point;

    float Current_Time;

    public override void Shooting()
    {
        Current_Time += Time.deltaTime;
        if (Current_Time >= Shooting_Time)
        {
            Current_Time = 0;
            Instantiate(One_Gun_Enemy_Bullet, Bullet_Exit_Point.transform.position, Quaternion.identity);
        }      
    }

    public override void Moving()
    {
        Enemy_Rigidbody.velocity = new Vector2(X_Speed, 0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "LeftWall")
        {
            Enemy_Rigidbody.velocity = new Vector2(X_Speed, 0);
        }
        if (other.tag == "RightWall")
        {
            Enemy_Rigidbody.velocity = new Vector2(-X_Speed, 0);
        }
    }
}
