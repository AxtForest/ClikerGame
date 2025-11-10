using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GlobalShop : MonoBehaviour
{


    public GameObject Fakebutton;
    public GameObject FakeText;
    public GameObject Realbutton;
    public GameObject RealText;
    public int currentCash;
    public static int ShopValue = 50;
    public static bool turnOffButton = false;
    public GameObject ShopStats;
    public static int NumberOfShops;
    public static int ShopPerSec;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentCash = GlobalCash.CashCount;
        ShopStats.GetComponent<Text>().text = "Shops:" + NumberOfShops + " @ " + ShopPerSec + " Per Second";
        FakeText.GetComponent<Text>().text = "Buy Shop - $" + ShopValue;
        RealText.GetComponent<Text>().text = "Buy Shop - $" + ShopValue;
        if (currentCash >= ShopValue)
        {
            Fakebutton.SetActive(false);
            Realbutton.SetActive(true);

        }

        if(turnOffButton == true)
        {
            Realbutton.SetActive(false);
            Fakebutton.SetActive(true);
            turnOffButton = false;
        }
    }
}
