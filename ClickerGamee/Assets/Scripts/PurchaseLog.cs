using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoCookie;
    public GameObject Autosell;
    public AudioSource PlaySound;


    public void StartAutoCookie()
    {


        PlaySound.Play();
        AutoCookie.SetActive(true);
        GlobalCash.CashCount -= GlobalBaker.bakerValue;
        GlobalBaker.bakerValue *= 2;
        GlobalBaker.turnOffButton = true;
        GlobalBaker.BakePerSec += 1;
        GlobalBaker.NumberOfBakers += 1;
    }
    public void StartAutoSell()
    {


        PlaySound.Play();
        Autosell.SetActive(true);
        GlobalCash.CashCount -= GlobalShop.ShopValue;
        GlobalShop.ShopValue *= 2;
        GlobalShop.turnOffButton = true;
        GlobalShop.ShopPerSec += 1;
        GlobalShop.NumberOfShops += 1;
    }
}
