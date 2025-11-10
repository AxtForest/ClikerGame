using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GlobalBaker : MonoBehaviour
{


    public GameObject Fakebutton;
    public GameObject FakeText;
    public GameObject Realbutton;
    public GameObject RealText;
    public int currentCash;
    public static int bakerValue = 50;
    public static bool turnOffButton = false;
    public GameObject bakerStats;
    public static int NumberOfBakers;
    public static int BakePerSec;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentCash = GlobalCash.CashCount;
        bakerStats.GetComponent<Text>().text = "Bakers:" + NumberOfBakers + " @ " + BakePerSec + " Per Second";
        FakeText.GetComponent<Text>().text = "Buy Baker - $" + bakerValue;
        RealText.GetComponent<Text>().text = "Buy Baker - $" + bakerValue;
        if (currentCash >= bakerValue)
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
