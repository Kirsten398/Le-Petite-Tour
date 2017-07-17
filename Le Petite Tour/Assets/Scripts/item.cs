using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour {

    string name;
    int price;
    int exp;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public string getName()
    {
        return name;
    }

    public int getPrice()
    {
        return price;
    }

    public int getExp()
    {
        return exp;
    }
}
