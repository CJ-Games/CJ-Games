/************************************************************
Author: Casey Rogers
Date: 7/16/2023
Name: EnemyData.cs
Notes: A script that manages an enemy unit's various attributes.

*************************************************************/



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyData : MonoBehaviour
{
    EnemyClass enemyclass;
    EnemyType UnitType;

    // Start is called before the first frame update
    void Start()
    {
        enemyclass = GetComponent<EnemyClass>();
        UnitType = enemyclass.Enemy;

        //Debug.Log(UnitType);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
