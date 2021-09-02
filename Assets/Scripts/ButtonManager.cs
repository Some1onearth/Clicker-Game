using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public static int conspiracySpread;
    [SerializeField]
    Text conspiracyUICounter;
    // Start is called before the first frame update
    void Start()
    {
        conspiracySpread = PlayerPrefs.GetInt("conspiracies", 0); //loads in saved clicks
        UpdateText();
    }

    public void BigButtonPress() //can't have several paramaters (ie. adding "int i" after "string message" or Nukes launched
    {
        conspiracySpread += 1;
        Debug.Log(conspiracySpread + " Conspiracy Spread"); //saves clicks

        UpdateText();

        PlayerPrefs.SetInt("conspiracies", conspiracySpread);
    }
    void UpdateText()
    {
        if(conspiracySpread != 1)
        {
            conspiracyUICounter.text = conspiracySpread + " \n<size=50>Conspiracies Spread</size>";
        }
        else
        {
            conspiracyUICounter.text = conspiracySpread + " \n<size=50>Conspiracy Spread</size>";
        }
    }
}
