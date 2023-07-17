/************************************************************
Author: Casey Rogers
Date: 7/16/2023
Name: EnemyBehavior.cs
Notes: A script that manages an enemy unit's behavioral AI.

*************************************************************/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum EnemyState { Asleep, Active, }

public class EnemyBehavior : MonoBehaviour
{
    public Collider Sensor;
    
    EnemyState UnitState;

    bool Detection = false;




    // Start is called before the first frame update
    void Start()
    {
        UnitState = EnemyState.Asleep;
    }

    // Update is called once per frame
    void Update()
    {
        Scanning();

        if (Input.GetKey(KeyCode.A))
        {
            Detection = true;
        }
        else Detection = false;
    }


    public void Scanning()
    {
        if(Detection == true)
        {
            UnitState = EnemyState.Active;

            Debug.Log("PLAYER DETECTED");
        }
    }

    /*
    private void OnTriggerEnter(Collider Sensor)
    {
        if (Sensor.gameObject.tag == "Player")
        {
            Detection = true;
        }
        else Detection = false;
    }*/

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Detection = true;
        }
        else Detection = false;
    }

}
