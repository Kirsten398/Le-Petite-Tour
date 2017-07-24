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

        for (i = 0; i < ItemMaster.Count && ItemMaster[i].getName() != n; i++)
        {
            if (ItemMaster[i].getName() != n)
                updateItem = false;
            else
                updateItem = true;
        }

        if (updateItem)
        {
            int quantity = ItemMaster[i].getQuantity();

            quantity += q;

            ItemMaster[i].setQuantity(quantity);
        }
        else
        {
            item newItem;

            newItem.setName(n);
            newItem.setQuantity(q);
            newItem.setPrice(p);
            newItem.setExp(e);

            ItemMaster.Add(newItem);
        }
    }

    public int FindIngredientQuantity(string name)
    {
        int i;
        bool found = false;

        for(i = 0; i < ItemMaster.Count && ItemMaster[i].getName() != name; i++)
        {
            if (ItemMaster[i].getName() != name)
                found = false;
            else
                found = true;
        }

        if (found)
            return ItemMaster[i].getQuantity();
        else
            return 0;
    }
}
