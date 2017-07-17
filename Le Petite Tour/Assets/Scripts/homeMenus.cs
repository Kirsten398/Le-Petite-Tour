using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class homeMenus : MonoBehaviour {

    public levelControl currentLevel;
    
    public Button[] characterButtons;

    private int level;
    
    // Use this for initialization
    void Start () {
        foreach(Button character in characterButtons)
        {
            bool availableAtStart = character.CompareTag("Start");

            if (!availableAtStart)
                character.gameObject.SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update () {
        level = int.Parse(currentLevel.Level.text.ToString());

        foreach (Button character in characterButtons)
        {
            if(level == 6)
            {
                bool availableLevel6 = character.CompareTag("Level 6");

                if (availableLevel6)
                    character.gameObject.SetActive(true);
            }

            if (level == 10)
            {
                bool availableLevel10 = character.CompareTag("Level 10");

                if (availableLevel10)
                    character.gameObject.SetActive(true);
            }

            if (level == 14)
            {
                bool availableLevel14 = character.CompareTag("Level 14");

                if (availableLevel14)
                    character.gameObject.SetActive(true);
            }

            if (level == 28)
            {
                bool availableLevel28 = character.CompareTag("Level 28");

                if (availableLevel28)
                    character.gameObject.SetActive(true);
            }
        }
    }

    public void OpenMenu (GameObject menu)
    {
        menu.SetActive(true);

        foreach (Button character in characterButtons)
        {
            character.interactable = false;
        }
    }

    public void CloseMenu(GameObject menu)
    {
        menu.SetActive(false);

        foreach(Button character in characterButtons)
        {
            character.interactable = true;
        }
    }

    public void OpenSubMenu (GameObject menu)
    {
        menu.SetActive(true);
    }

    public void CloseSubMenu(GameObject menu)
    {
        menu.SetActive(false);
    }
}
