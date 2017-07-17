using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class grocer : MonoBehaviour {

    public string[] ingredientNames = { "Quail", "Rabbit", "Squab", "Deer", "Partridge", "Chamois", "Duck", "Mouflon", "Goose", "Boar", //Hunted Meats
                                        "Frog", "Snail", "Salmon", "Shrimp", "Cod", "Mussels", "Sardines", "Oysters", "Tuna", "Calamari", "Trout", "Herring", //Fish
                                        "Chicken", "Beef", "Pork", "Lamb", "Mutton", "Horse", //Grocery Meats
                                        "Lentil", "Chickpea", "Potato", "Garlic", "Artichoke", "Asparagus", "Beet Root", "Carrot", "Celery", "Cabbage", "Cucumber", "Pumpkin", "Shallot", "Endive",
                                            "Spinach", "Beans", "Melon", "Turnip", "Onion", "Peas", "Leek", "Radish", "Lettuce", "Mushroom", //Vegetables
                                        "Apricot", "Cherry", "Peach", "Nectarine", "Plum", "Cider Apple", "Apple", "Pear", "Grapes", "Almond", "Chestnut", "Walnut", "Hazelnut", "Clementine", "Orange",
                                            "Grapefruit", "Blackcurrant", "Raspberry", "Fig", "Tomato", "Strawberry", "Kiwi", //Fruits
                                        "Wheat", "Barley", "Corn", "Oats", //Grains
                                        "Salt", "Savory", "Tarragon", "Chives", "Chervil", "Parsley", "Oregano", "Marjoram", "Rosemary", "Thyme", "Lavender", "Bay Leaf", "Sage", "Peppercorns", "Saffron",
                                            "Nutmeg"}; //Spices

    // Use this for initialization
    void Start () {
        for(int i = 0; i < ingredientNames.Length; i++)
        {
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void UpdateQuantity(string name, int q)
    {
    }
}
