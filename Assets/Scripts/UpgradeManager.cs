using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour
{
    public Button research, avoid5G, twit, video, stream, hotTake;
    int conspiraciesSpread;
    void Start()
    {
        conspiraciesSpread = PlayerPrefs.GetInt("conspiracies");
        unlockResearch();
        unlockAvoid5G();
        unlockTwit();
        unlockVideo();
        unlockStream();
        unlockHotTake();
        
    }
    void Update()
    {
        conspiraciesSpread = PlayerPrefs.GetInt("conspiracies");
        unlockResearch();
        unlockAvoid5G();
        unlockTwit();
        unlockVideo();
        unlockStream();
        unlockHotTake();
    }
    #region Unlocks
    public void unlockResearch()
    {
        if (conspiraciesSpread >= ButtonManager.research)
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
        if (conspiraciesSpread >= ButtonManager.avoid5G)
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
        if (conspiraciesSpread >= ButtonManager.postTwit)
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
        if (conspiraciesSpread >= ButtonManager.uploadVideo)
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
        if (conspiraciesSpread >= ButtonManager.stream)
        {
            stream.interactable = true;
        }
        else
        {
            stream.interactable = false;
        }
    }
    public void unlockHotTake()
    {
        if (conspiraciesSpread >= ButtonManager.hotTake)
        {
            hotTake.interactable = true;
        }
        else
        {
            hotTake.interactable = false;
        }
    }
    #endregion
}