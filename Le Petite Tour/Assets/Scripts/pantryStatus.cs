using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pantryStatus : MonoBehaviour {

    public masterList Master;
    public bool status = false;

    public GameObject baseButton;
    public GameObject page1, page2, page3, page4, page5, page6, page7, page8;
    public GameObject left;
    public GameObject right;

    private int[] pageCap = { 24, 49, 74, 99, 124, 149, 174, 199 };
    private List<GameObject> slots = new List<GameObject>();
    private int itemCount = 0;
    private int page;
    private int last;
    private bool onStartScreen = false;
    private bool onLastScreen = false;

    // Use this for initialization
    void Start () {
        onStartScreen = true;
        page = 0;
        last = 2;

        /*for (int x = 0; x < 25; x++)
        {
            Master.MasterAdd("CK");
        }

        foreach (string item in Master)
        {
            if (itemCount < 25)
            {
                slots.Add(Instantiate(baseButton, new Vector3(itemCount % 5 * 125 - 200, -itemCount / 5 * 125 + 800), Quaternion.identity, page1.transform));
                slots[itemCount].GetComponentInChildren<Text>().text = Master[itemCount];
                itemCount++;
            }
        }*/
    }

    // Update is called once per frame
    void Update () {
        //UpdatePantry();

        /*if (onLastScreen)
            right.SetActive(false);
        else right.SetActive(true);

        if (page == 0)
            onStartScreen = true;

        if (page == last)
            onLastScreen = true;

        if (page != last)
            onLastScreen = false;

        if (page != 0)
            onStartScreen = false;

        if (itemCount < 25 && onStartScreen)
        {
            left.SetActive(false);
            right.SetActive(false);
        }
        else
        {
            right.SetActive(true);
        }

        if(itemCount > 25 && !onStartScreen)
        {
            left.SetActive(true);
        }*/
    }

    /*void UpdatePantry()
    {
        foreach (string item in Master)
        {
            if (itemCount < 25)
            {
                slots.Add(Instantiate(baseButton, new Vector3(itemCount % 5 * 125 - 200, -itemCount / 5 * 125 + 800), Quaternion.identity, page1.transform));
                slots[itemCount].GetComponentInChildren<Text>().text = Master[itemCount];
                itemCount++;
            }
        }
    }*/

    public void PageInc()
    {
        page++;
    }

    public void PageDec()
    {
        page--;
    }

    public void Unlock(GameObject g)
    {
        g.SetActive(true);
        last++;
    }

    public void FinalUnlock(GameObject g)
    {
        g.SetActive(true);
    }

    public void killButton(GameObject b)
    {
        Destroy(b);
    }

    public void changeStatus()
    {
        status = true;
    }
}
