using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnable : MonoBehaviour {

    public float spd=4f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(Vector3.up * Time.deltaTime*spd);
    }
}
