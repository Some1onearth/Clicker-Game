using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public static int conspiracySpread = 0;
    public static int research = 20;
    public static int avoid5G = 80;
    public static int postTwit = 150;
    public static int uploadVideo = 4000;
    public static int stream = 100000;
    public static int hotTake = 100;
    public static int conspiracySpreadPlus = 0;
    public static int conspiracySpreadPerSec = 0;
    public bool autoSpread = false;
    [SerializeField] Text conspiracyUICounter;
    [SerializeField] Text researchUICounter;
    [SerializeField] Text avoid5GUICounter;
    [SerializeField] Text twitUICounter;
    [SerializeField] Text videoUICounter;
    [SerializeField] Text streamUICounter;
    [SerializeField] Text hotTakeUICounter;
    // Start is called before the first frame update
    void Start()
    {
        conspiracySpread = PlayerPrefs.GetInt("conspiracies", 0); //loads in saved clicks
        UpdateConspiracyText();
        research = PlayerPrefs.GetInt("research", 20);
        UpdateResearchText();
        avoid5G = PlayerPrefs.GetInt("avoid5G", 80);
        UpdateAvoid5GText();
        postTwit = PlayerPrefs.GetInt("twit", 150);
        UpdateTwitText();
        uploadVideo = PlayerPrefs.GetInt("video", 4000);
        UpdateVideoText();
        stream = PlayerPrefs.GetInt("strim", 100000);
        UpdateStreamText();
        hotTake = PlayerPrefs.GetInt("hottake", 100);
        UpdateHotTakeText();
        conspiracySpreadPlus = PlayerPrefs.GetInt("conspiracySpreadPlus", 0);
    }
    private void Update()
    {
        conspiracySpread = Mathf.Max(0, conspiracySpread);

        UpdateConspiracyText();

        if(autoSpread == false)
        {
            StartCoroutine(ConpiracySpreadAuto());
        }
    }

    public void BigButtonPress() //can't have several paramaters (ie. adding "int i" after "string message" or Nukes launched
    {
        conspiracySpread += 1 + conspiracySpreadPlus;
        Debug.Log(conspiracySpread + " Conspiracies Spread");

        UpdateConspiracyText();

        PlayerPrefs.SetInt("conspiracies", conspiracySpread);//saves clicks
    }
    public void ResearchButtonPress()
    {
        if (conspiracySpread >= research)
        {
            conspiracySpread -= research;
            research *= 2;
            conspiracySpreadPlus += 1;
            PlayerPrefs.SetInt("conspiracySpreadPlus", conspiracySpreadPlus);
            Debug.Log(research + "You've done your research");

            UpdateConspiracyText();
            UpdateResearchText();

            PlayerPrefs.SetInt("research", research);
        }
    }
    public void Avoid5GButtonPress()
    {
        if (conspiracySpread >= avoid5G)
        {
        conspiracySpread -= avoid5G;
        avoid5G *= 2;
        conspiracySpreadPlus += 3;
        PlayerPrefs.SetInt("conspiracySpreadPlus", conspiracySpreadPlus);
        Debug.Log(avoid5G + "You have avoided 5G towers");

        UpdateConspiracyText();
        UpdateAvoid5GText();

        PlayerPrefs.SetInt("avoid5G", avoid5G);
        }
    }
    public void TwitButtonPress()
    {
        if (conspiracySpread >= postTwit)
        {
            conspiracySpread -= postTwit;
            postTwit *= 2;
            conspiracySpreadPerSec += 1;
            PlayerPrefs.SetInt("conspiracyPerSec", conspiracySpreadPerSec);
            Debug.Log(postTwit + "You have twitted and shown your research");

            UpdateConspiracyText();
            UpdateTwitText();

            PlayerPrefs.SetInt("twit", postTwit);
        }
    }
    public void VideoButtonPress()
    {
        if (conspiracySpread >= uploadVideo)
        {
            conspiracySpread -= uploadVideo;
            uploadVideo *= 2;
            conspiracySpreadPerSec += 2;
            PlayerPrefs.SetInt("conspiracyPerSec", conspiracySpreadPerSec);
            Debug.Log(uploadVideo + "You have spouted your opinions");

            UpdateConspiracyText();
            UpdateVideoText();

            PlayerPrefs.SetInt("video", uploadVideo);
        }
    }
    public void StreamButtonPress()
    {
        if (conspiracySpread >= stream)
        {
            conspiracySpread -= stream;
            stream *= 2;
            conspiracySpreadPerSec += 5;
            PlayerPrefs.SetInt("conspiracyPerSec", conspiracySpreadPerSec);
            Debug.Log(stream + "You engaged with your sheep");

            UpdateConspiracyText();
            UpdateStreamText();

            PlayerPrefs.SetInt("strim", stream);
        }
    }
    public void HotTakeButtonPress()
    {
        if (conspiracySpread >= hotTake)
        {
            conspiracySpread -= hotTake;
            conspiracySpread = conspiracySpread + hotTake* Random.Range(0, 2);
            hotTake *= 2;
            Debug.Log(hotTake + "You have stated your risky opinion");

            UpdateConspiracyText();
            UpdateHotTakeText();

            PlayerPrefs.SetInt("hottake", hotTake);
        }
    }
    #region UpdateTexts
    void UpdateConspiracyText()
    {
        if(conspiracySpread != 1)
        {
            conspiracyUICounter.text = conspiracySpread + " \n<size=50>'Credibility' gained</size>";
        }
        else
        {
            conspiracyUICounter.text = conspiracySpread + " \n<size=50>'Credibility' gained</size>";
        }
    }
    void UpdateResearchText()
    {
        if (research != 20)
        {
            researchUICounter.text = research + " \n<size=46>Do more Research</size>";
        }
        else
        {
            researchUICounter.text = research + " \n<size=46>Do your Research</size>";
        }
    }
    void UpdateAvoid5GText()
    {
        if (avoid5G != 80)
        {
            avoid5GUICounter.text = avoid5G + " \n<size=46>Avoid 5G Towers</size>";
        }
        else
        {
            avoid5GUICounter.text = avoid5G + " \n<size=46>Avoid 5G Towers</size>";
        }
    }
    void UpdateTwitText()
    {
        if (postTwit != 150)
        {
            twitUICounter.text = postTwit + " \n<size=46>Post more Twit</size>";
        }
        else
        {
            twitUICounter.text = postTwit + " \n<size=46>Post Twit</size>";
        }
    }
    void UpdateVideoText()
    {
        if (uploadVideo != 4000)
        {
            videoUICounter.text = uploadVideo + " \n<size=44>Upload more Bideos</size>";
        }
        else
        {
            videoUICounter.text = uploadVideo + " \n<size=46>Upload Bideo</size>";
        }
    }
    void UpdateStreamText()
    {
        if (stream != 100000)
        {
            streamUICounter.text = stream + " \n<size=46>Strim</size>";
        }
        else
        {
            streamUICounter.text = stream + " \n<size=46>Strim</size>";
        }
    }
    void UpdateHotTakeText()
    {
        if (hotTake != 100)
        {
            hotTakeUICounter.text = hotTake + " \nRisk another Hot Take";
        }
        else
        {
            hotTakeUICounter.text = hotTake + " \nGive a  Hot Take";
        }
    }
    #endregion
    public void ResetInt()
    {
        conspiracySpread = 0;
        research = 20;
        avoid5G = 80;
        postTwit = 150;
        uploadVideo = 4000;
        stream = 100000;
        hotTake = 100;
        conspiracySpreadPlus = 0;
        conspiracySpreadPerSec = 0;
        PlayerPrefs.SetInt("conspiracies", conspiracySpread);
        PlayerPrefs.SetInt("research", research);
        PlayerPrefs.SetInt("avoid5G", avoid5G);
        PlayerPrefs.SetInt("twit", postTwit);
        PlayerPrefs.SetInt("video", uploadVideo);
        PlayerPrefs.SetInt("strim", stream);
        PlayerPrefs.SetInt("conspiracySpreadPlus", conspiracySpreadPlus);
        PlayerPrefs.SetInt("conspiracyPerSec", conspiracySpreadPerSec);
        UpdateConspiracyText();
        UpdateResearchText();
        UpdateAvoid5GText();
        UpdateTwitText();
        UpdateVideoText();
        UpdateStreamText();
        UpdateHotTakeText();
    }
    IEnumerator ConpiracySpreadAuto()
    {
        conspiracySpread += conspiracySpreadPerSec;
        yield return new WaitForSecondsRealtime(1);
        autoSpread = false;
    }
    public void ExitTheGame()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; //don't need UnityEditor at the beginning if UnityEditor is here. Easier to put up top if there are mutliple
        #endif
        Application.Quit();
    }

}
