using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuController : MonoBehaviour {

    public List<Button> counter = new List<Button>();
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OpenMenu(GameObject menu)
    {
        menu.SetActive(true);

        foreach (Button slot in counter)
        {
            slot.interactable = false;
        }
    }

    public void CloseMenu(GameObject menu)
    {
        menu.SetActive(false);

        foreach (Button slot in counter)
        {
            slot.interactable = true;
        }
    }

    public void OpenSubMenu(GameObject menu)
    {
        menu.SetActive(true);
    }

    public void CloseSubMenu(GameObject menu)
    {
        menu.SetActive(false);
    }

}
