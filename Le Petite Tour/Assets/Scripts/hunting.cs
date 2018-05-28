using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hunting : MonoBehaviour {

    public masterList master;

    public Text[] Texts = new Text[4];
    public Button quick, thorough;
    public Image frog;

    private float encounterChance = .5f;
    private float menuChance = .3f;
    private int meatCollected = 5;
    private int inc = 0;
    private bool isGame = false;
    
    // Use this for initialization
	void Start () {
        master = masterList.master;
        Texts[0].gameObject.SetActive(true);
        Texts[1].gameObject.SetActive(false);
        Texts[2].gameObject.SetActive(false);
        Texts[3].gameObject.SetActive(false);
        quick.gameObject.SetActive(false);
        thorough.gameObject.SetActive(false);
        frog.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AdvanceText()
    {
        if(inc < 2)
        {
            Texts[inc].gameObject.SetActive(false);
        }

        inc++;

        if(inc > 1)
        {
            DetermineEncounter();

            if (isGame)
            {
                frog.gameObject.SetActive(true);
                Texts[2].gameObject.SetActive(true);
                quick.gameObject.SetActive(true);
                thorough.gameObject.SetActive(true);
                thorough.interactable = false;
            }
            else
            {
                Texts[3].gameObject.SetActive(true);
            }
        }
        else
        {
            Texts[inc].gameObject.SetActive(true);
        }
    }

    /*public void QuickHunt(string s)
    {
        master.MasterAdd(s);

        Application.LoadLevel("Home");
    }*/

    public bool DetermineEncounter()
    {
        float rand = Random.value;

        if(rand > encounterChance)
        {
            isGame = true;
        }
        else
        {
            isGame = false;
        }

        return isGame;
    }
}
