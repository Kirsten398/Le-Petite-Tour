using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PantryExp : MonoBehaviour {

    public const int numIngredientSlots = 16;

    public Image[] ingredientImages = new Image[numIngredientSlots];
    public Button[] ingredientButtons = new Button[numIngredientSlots];
    public Ingredient[] ingredients = new Ingredient[numIngredientSlots];
    public int[] amounts = new int[numIngredientSlots];

    //this function adds ingredients
    public void AddIngredient(Ingredient ingredientToAdd)
    {
        for(int i = 0; i < ingredients.Length; i++)
        {
            //first see if the ingredient already exists in the array
            if (ingredients[i] == ingredientToAdd)
            {
                amounts[i]++;
                return;
            }
            else if (ingredients[i] == null) //otherwise use the next null space
            {
                ingredients[i] = ingredientToAdd;
                ingredientImages[i].sprite = ingredientToAdd.sprite;
                ingredientImages[i].enabled = true;
                ingredientButtons[i].enabled = true;
                amounts[i]++;
                return;
            }
        }
    }

    public void RemoveIngredient(Ingredient ingredientToRemove, int amount)
    {
        for(int i = 0; i < ingredients.Length; i++)
        {
            if(ingredients[i] == ingredientToRemove)
            {
                if(amounts[i] > amount)
                {
                    amounts[i] = amounts[i] - amount;
                    return;
                }
                else if(amounts[i] == amount)
                {
                    ingredients[i] = null;
                    ingredientImages[i] = null;
                    ingredientImages[i].enabled = false;
                    amounts[i] = 0;
                    return;
                }
                else if (amounts[i] < amount)
                {
                    Debug.Log("You don't have enough of this ingredient");
                    return;
                }
            }
            else
            {
                Debug.Log("You don't have this ingredient");
                return;
            }
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
