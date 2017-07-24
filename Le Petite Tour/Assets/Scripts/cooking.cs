using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class cooking : MonoBehaviour {

    public Text CKSTingr1;
    public Text CKSTingr2;

    public masterList ingredientList;

    public Button cookSlot;

    private GameObject currentRecipe;

    private int chickenHave;
    private int waterHave;
    private int chickenNeed = 1;
    private int waterNeed = 1;

    private float timer = 30.0f;

    private bool isCooking = false;

    private string recipe;
    private string ingredient1;
    private string ingredient2;
    private string ingredient3;
    private string ingredient4;
    private string ingredient5;
    private string ingredient6;

    // Use this for initialization
    void Start () {
        chickenHave = ingredientList.FindIngredientQuantity("Chicken");
        waterHave = ingredientList.FindIngredientQuantity("Water");

        Debug.Log(chickenHave + ", " + waterHave);
	}
	
	// Update is called once per frame
	void Update () {
        CKSTingr1.text = "CK: " + chickenHave + "/" + chickenNeed;
        CKSTingr2.text = "WT: " + waterHave + "/" + waterNeed;

        if(isCooking)
        {
            timer -= Time.deltaTime;

            if(timer <= 0)
            {
                cookSlot.interactable = true;
                isCooking = false;
            }
        }
	}

    public void getRecipe()
    {
        currentRecipe = EventSystem.current.currentSelectedGameObject;

        if (currentRecipe.GetComponentInChildren<Text>().CompareTag("Title"))
        {
            recipe = currentRecipe.GetComponentInChildren<Text>().text;
        }
    }

    public void cook()
    {
        if(chickenHave >= chickenNeed && waterHave >= waterNeed)
        {
            isCooking = true;
            cookSlot.interactable = false;
        }
    }

    public void collect()
    {
        ingredientList.AddItem("Chicken Stock", 1, 5, 10);
        timer = 30.0f;
    }
}
