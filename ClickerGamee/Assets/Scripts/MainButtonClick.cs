using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainButtonClick : MonoBehaviour
{

    [SerializeField] GameObject TextBox;
    public AudioSource CookieSound;
    public void ClickTheButton()
    {
        CookieSound.Play();
        GlobalCookies.CookieCount += 1;

    }









}
