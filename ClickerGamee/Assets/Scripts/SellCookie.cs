using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SellCookie : MonoBehaviour
{
    [SerializeField] GameObject TextBox;
    public GameObject StatusBox;
    public AudioSource CashSound1;
    public AudioSource CashSound2;
    public int RandomChose;
    public AudioSource NoCookie;
    


    public void ClickTheButton()
    {

        RandomChose = Random.Range(1, 3);
        if (GlobalCookies.CookieCount == 0)
        {
            NoCookie.Play();
            StatusBox.GetComponent<Text>().text = " Not enough cookies to sell.";
            StatusBox.GetComponent<Animation>().Play("StatusAnim");


        }


        else
        {

            if(RandomChose ==1)
            {
                CashSound1.Play();
            }
            if(RandomChose == 2)
            {
                CashSound2.Play();
            }


            GlobalCookies.CookieCount -= 1;
            GlobalCash.CashCount += 1;
        }
    }
}
