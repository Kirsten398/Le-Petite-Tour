using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour {

    string itemName;
    int quantity;
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
        return itemName;
    }

    public void setName(string s)
    {
        itemName = s;
    }

    public int getPrice()
    {
        return price;
    }

    public int getQuantity()
    {
        return quantity;
    }

    public void setQuantity(int q)
    {
        quantity = q;
    }

    public void setPrice(int p)
    {
        price = p;
    }

    public int getExp()
    {
        return exp;
    }

    public void setExp(int e)
    {
        exp = e;
    }
}
