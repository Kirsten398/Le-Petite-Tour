using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sink : MonoBehaviour {

    public masterList ingredientList;

	// Use this for initialization
	void Start () {
        ingredientList = masterList.master;
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void AddWater()
    {
        ingredientList.AddItem("Water", 1, 1, 1);
    }
}
