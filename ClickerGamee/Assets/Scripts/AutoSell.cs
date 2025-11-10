using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSell : MonoBehaviour
{

    public bool SellingCookie = false;
    public static int CashIncrease = 1;
    public int InternalIncrease = 1;


    // Update is called once per frame
    void Update()
    {
        CashIncrease = GlobalShop.ShopPerSec;

        InternalIncrease = CashIncrease;

        if(SellingCookie == false)
        {
            SellingCookie = true;
            StartCoroutine(SellTheCookie());
        }

    }




    IEnumerator SellTheCookie()
    {

        if(GlobalCookies.CookieCount == 0)
        {

            //we cant sell

        }
        else { 
        GlobalCash.CashCount += InternalIncrease;
        GlobalCookies.CookieCount -= 1;
        yield return new WaitForSeconds(1);

        SellingCookie = false;
        }

    }







}
