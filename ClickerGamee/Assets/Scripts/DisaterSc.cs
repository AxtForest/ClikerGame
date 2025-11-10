using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisaterSc : MonoBehaviour
{
    public GameObject StatusBox;
    public float cookieCheck;
    public int genChance;
    public bool disasterActive = false;
    public int cookieLoss;


    // Update is called once per frame
    void Update()
    {
        cookieCheck = GlobalCookies.CookieCount / 10;

        if (disasterActive == false)
        {
            StartCoroutine(StartDisaster());
        }
    }
    IEnumerator StartDisaster()
    {
        disasterActive = true;
        genChance = Random.Range(1, 20);

        
            if (cookieCheck >= genChance)
            {
                cookieLoss = Mathf.RoundToInt(GlobalCookies.CookieCount * 0.25f);
                StatusBox.GetComponent<Text>().text = "You lost " + cookieLoss + "cookies in a factory fire";
                GlobalCookies.CookieCount -= cookieLoss;

                yield return new WaitForSeconds(3);

                StatusBox.GetComponent<Animation>().Play("StatusAnim");
            yield return new WaitForSeconds(1);
            StatusBox.SetActive(false);
            StatusBox.SetActive(true);


        }
            yield return new WaitForSeconds(10);
        disasterActive = false;
    }

}


 
