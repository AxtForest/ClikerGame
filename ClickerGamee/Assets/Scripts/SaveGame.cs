using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SaveGame : MonoBehaviour
{

    public GameObject StatusBox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveTheGame()
    {
        PlayerPrefs.SetInt("SavedCookies",GlobalCookies.CookieCount);
        PlayerPrefs.SetInt("SavedCash", GlobalCash.CashCount);
        PlayerPrefs.SetInt("SavedShops", GlobalShop.NumberOfShops);
        PlayerPrefs.SetInt("SavedBakers", GlobalBaker.BakePerSec);

        StatusBox.GetComponent<Text>().text = " GAME SAVED";
        StatusBox.GetComponent<Animation>().Play("StatusAnim");

    }
}
