using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelControl : MonoBehaviour {

    public Slider XpSlider;
    public Text Level;
    public Text XP;
    public Text Euros;
    public Text Gold;

    private static int currentXp = 0;
    private static int levelUpXp;
    private static int currentLevel = 0;
    private static int nextLevel;
    private static int currentMuns = 0;
    private static int currnetGold = 0;

	// Use this for initialization
	void Start () {
        CheckXP();
	}
	
	// Update is called once per frame
	void Update () {
        Level.text = currentLevel.ToString();
        XP.text = currentXp.ToString();
        Euros.text = currentMuns.ToString();
        Gold.text = currnetGold.ToString();

	}

    public void UpdateXP(int xp)
    {
        currentXp += xp;

        if (currentXp == levelUpXp)
        {
            currentLevel++;
            currentXp = 0;
        }

        nextLevel = currentLevel + 1;

        levelUpXp = nextLevel * 100;

        XpSlider.value = currentXp;
        XpSlider.maxValue = levelUpXp;
    }

    public void UpdateEuros(int muns)
    {
        currentMuns += muns;
    }

    public void UpdateGold(int gold)
    {
        currnetGold += gold;
    }

    public void CheckXP()
    {
        XpSlider.value = currentXp;
    }
}
