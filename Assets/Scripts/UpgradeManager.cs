using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour
{
    public Button research, avoid5G, twit, video, stream, hotTake;
    public GameObject hotTakeObj, streamObj;
    public static UpgradeManager theUpMan; //allows this script to be accessed by other scripts and therefore its' functions to be done.

    void Start()
    {
        if(theUpMan == null)
        {
            theUpMan = this;
        }
        else
        {
            Destroy(this);
        }
        //above makes sure there aren't more than one instance of this script running
        
        UpdateAll();
    }
    void Update()
    {
        UpdateAll();
    }
    #region Unlocks
    public void unlockResearch()
    {
        if (ButtonManager.conspiracySpread >= ButtonManager.research)
        {
            research.interactable = true;
        }
        else
        {
            research.interactable = false;
        }
    }
    public void unlockAvoid5G()
    {
        if (ButtonManager.conspiracySpread >= ButtonManager.avoid5G)
        {
            avoid5G.interactable = true;
        }
        else
        {
            avoid5G.interactable = false;
        }
    }
    public void unlockTwit()
    {
        if (ButtonManager.conspiracySpread >= ButtonManager.postTwit)
        {
            twit.interactable = true;
        }
        else
        {
            twit.interactable = false;
        }
    }
    public void unlockVideo()
    {
        if (ButtonManager.conspiracySpread >= ButtonManager.uploadVideo)
        {
            video.interactable = true;
        }
        else
        {
            video.interactable = false;
        }
    }
    public void unlockStream()
    {
        if (ButtonManager.conspiracySpread >= ButtonManager.stream)
        {
            stream.interactable = true;
            streamObj.SetActive(true);
        }
        else
        {
            stream.interactable = false;
        }
    }
    public void unlockHotTake()
    {
        if (ButtonManager.conspiracySpread >= ButtonManager.hotTake)
        {
            hotTake.interactable = true;
            hotTakeObj.SetActive(true);
        }
        else
        {
            hotTake.interactable = false;
            hotTakeObj.SetActive(false);
        }
    }
    #endregion
    public void UpdateAll()
    {
        unlockResearch();
        unlockAvoid5G();
        unlockTwit();
        unlockVideo();
        unlockStream();
        unlockHotTake();
    }
}