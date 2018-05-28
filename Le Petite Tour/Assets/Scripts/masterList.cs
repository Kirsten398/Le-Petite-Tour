using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class masterList : MonoBehaviour {

    private static masterList Master = null;
    private Dictionary<string, item> ItemMaster;

    public static masterList master
    {
        get
        {
            if (Master == null)
            {
                Debug.Log("Master is null");
                Master = GameObject.Find("Master").GetComponent<masterList>();
                if (Master == null)
                {
                    Debug.Log("Master is null");
                }
            }
            return Master;
        }
    }

    // Use this for initialization
    void Start() {
        Debug.Log("Start Master List");
        ItemMaster = new Dictionary<string, item>();
        Master = this;
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void AddItem(string n, int q, int p, int e)
    {
        item item;
        if (ItemMaster.TryGetValue(n, out item))
        {
            int quantity = item.getQuantity();

            quantity += q;

            item.setQuantity(quantity);

            Debug.Log("Updating Item " + item.getName() + " " + quantity);
        }
        else {
            item = new item(n, q, p, e);
            ItemMaster.Add(n, item);
            Debug.Log("Adding Item " + item.getName() + " " + q);
        }
    }

    public int FindIngredientQuantity(string name)
    {
        item item;

        if (ItemMaster.TryGetValue(name, out item))
        {
            Debug.Log("Found Item " + item.getName());
            return item.getQuantity();
        }
        else
        {
            Debug.Log("Unable to find Item " + name);
            return 0;
        }
    }

    public void CheckList()
    {
        foreach(KeyValuePair<string, item> pair in ItemMaster)
        {
            Debug.Log(pair.Key);
        }
    }
}
