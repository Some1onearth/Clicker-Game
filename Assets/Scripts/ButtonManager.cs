using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public static int conspiracySpread;
    public static int research;
    public static int avoid5G;
    public static int PostTwit;
    public static int uploadVideo;
    public static int stream;
    [SerializeField] Text conspiracyUICounter;
    [SerializeField] Text researchUICounter;
    // Start is called before the first frame update
    void Start()
    {
        conspiracySpread = PlayerPrefs.GetInt("conspiracies", 0); //loads in saved clicks
        UpdateConspiracyText();
        research = PlayerPrefs.GetInt("research", 0);
        UpdateResearchText();
    }

    public void BigButtonPress() //can't have several paramaters (ie. adding "int i" after "string message" or Nukes launched
    {
        conspiracySpread += 1;
        Debug.Log(conspiracySpread + " Conspiracy Spread"); //saves clicks

        UpdateConspiracyText();

        PlayerPrefs.SetInt("conspiracies", conspiracySpread);
    }
    public void ResearchButtonPress()
    {
        research += 1;
        Debug.Log(research + "You've done your research"); //saves clicks

        UpdateResearchText();

        PlayerPrefs.SetInt("research", research);
    }
    void UpdateConspiracyText()
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
    void UpdateResearchText()
    {
        if (research != 1)
        {
            researchUICounter.text = research + " \n<size=48>Do your research</size>";
        }
        else
        {
            researchUICounter.text = research + " \n<size=48>Do your research</size>";
        }
    }


}
