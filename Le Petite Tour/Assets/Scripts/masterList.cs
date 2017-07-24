using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class masterList : MonoBehaviour {

    public static List<string> Master = new List<string>();
    public static List<item> ItemMaster = new List<item>();

    private bool updateItem = false;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        
    }

    public void AddItem(string n, int q, int p, int e)
    {
        int i;

        //this does not seem to be working
        for (i = 0; i < ItemMaster.Count && ItemMaster[i].getName() != n; i++)
        {
            if (ItemMaster[i].getName() != n)
                updateItem = false;
            else
                updateItem = true;
        }

        if (updateItem)
        {
            Debug.Log("Updating Item " + ItemMaster[i].getName());

            int quantity = ItemMaster[i].getQuantity();

            quantity += q;

            ItemMaster[i].setQuantity(quantity);
        }
        else
        {
            Debug.Log("Adding Item " + n);

            item newItem = new item(n, q, p, e);
            ItemMaster.Add(newItem);

            CheckList();
        }
    }

    public int FindIngredientQuantity(string name)
    {
        int i;
        bool found = false;

        //nor this
        for(i = 0; i < ItemMaster.Count && ItemMaster[i].getName() != name; i++)
        {
            if (ItemMaster[i].getName() != name)
                found = false;
            else
                found = true;
        }

        if (found)
        {
            Debug.Log("Found Item " + ItemMaster[i].getName());
            return ItemMaster[i].getQuantity();
        }
        else
        {
            Debug.Log("Unable to find Item " + name);
            return 0;
        }
    }

    public void CheckList()
    {
        foreach(item ingredient in ItemMaster)
        {
            Debug.Log(ingredient.getName());
        }
    }
}
