using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sink : MonoBehaviour {

    public masterList ingredientList;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(ingredientList.FindIngredientQuantity("Water"));
	}

    public void AddWater()
    {
        ingredientList.AddItem("Water", 1, 1, 1);
    }
}
