using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class grocerySelect : MonoBehaviour {

    public masterList master;
    public string[] Groceries = new string[15];
    public Button delivery;
    public Button Fen;

    private GameObject currentButton;
    private Color checkAlpha;
    private float timer = 5.0f;
    private bool timeStart = false;
    private DateTime date;

    // Use this for initialization
    void Start () {
        delivery.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update () {
        if (timeStart)
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
                delivery.gameObject.SetActive(true);
        }

        date = DateTime.Now;

        if (date.Hour == 8)
            Fen.gameObject.SetActive(true);

        Debug.Log(master.FindIngredientQuantity("Chicken"));
    }

    public void SelectGroceries(string s)
    {
        if (currentButton.name == "Meats 1")
            Groceries[0] = s;
        else if (currentButton.name == "Meats 2")
            Groceries[1] = s;
        else if (currentButton.name == "Meats 3")
            Groceries[2] = s;
        else if (currentButton.name == "Veg 1")
            Groceries[3] = s;
        else if (currentButton.name == "Veg 2")
            Groceries[4] = s;
        else if (currentButton.name == "Veg 3")
            Groceries[5] = s;
        else if (currentButton.name == "Fruit 1")
            Groceries[6] = s;
        else if (currentButton.name == "Fruit 2")
            Groceries[7] = s;
        else if (currentButton.name == "Fruit 3")
            Groceries[8] = s;
        else if (currentButton.name == "Grain 1")
            Groceries[9] = s;
        else if (currentButton.name == "Grain 2")
            Groceries[10] = s;
        else if (currentButton.name == "Grain 3")
            Groceries[11] = s;
        else if (currentButton.name == "Herb 1")
            Groceries[12] = s;
        else if (currentButton.name == "Herb 2")
            Groceries[13] = s;
        else if (currentButton.name == "Herb 3")
            Groceries[14] = s;
        else
            s = null;
    }

    public void getButton()
    {
        currentButton = EventSystem.current.currentSelectedGameObject;
    }

    public void CheckMark(Image i)
    {
        i.color = new Color(0, 0, 0, 0);
    }

    public void ChangePic(Sprite i)
    {
        currentButton.GetComponentInChildren<Image>().sprite = i;
    }

    //Declining clears the array for the next time and dismisss Fen
    public void Decline()
    {
        for(int i = 0; i < Groceries.Length; i++)
        {
            Groceries[i] = null;
        }

        Fen.gameObject.SetActive(false);
    }

    public void Select()
    {
        Fen.gameObject.SetActive(false);

        timeStart = true;
    }

    public void Delivery()
    {
        foreach(string ingredient in Groceries)
        {
            master.AddItem(ingredient, 5, 1, 5);   
        }

        for(int i = 0; i < Groceries.Length; i++)
        {
            Groceries[i] = null;
        }

        delivery.gameObject.SetActive(false);
        timeStart = false;
        timer = 5.0f;
    }
}
