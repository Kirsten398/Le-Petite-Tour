using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadLevel : MonoBehaviour {

    public string nextLevel;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void load()
    {
        Application.LoadLevel(nextLevel);
    }
}
