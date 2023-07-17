/************************************************************
Author: Casey Rogers
Date: 7/16/2023
Name: EnemyClass.cs
Notes: A script that references what stats and abilities are 
utilized by a particular enemy prefab.

*************************************************************/



using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum EnemyType { Turret, LightTank, Jeep, HeavyTank, Boss }


public class EnemyClass : MonoBehaviour
{
    public EnemyType Enemy = EnemyType.LightTank;

}
