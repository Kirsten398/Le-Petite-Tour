using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dove : MonoBehaviour {

    public levelControl stuff;
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void BonusDove()
    {
        stuff.UpdateXP(50);
    }
}
