using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pantryStatus : MonoBehaviour {

    public bool status = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void changeStatus()
    {
        status = true;
    }
}
