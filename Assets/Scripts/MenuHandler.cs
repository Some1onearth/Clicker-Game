using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuHandler : MonoBehaviour
{
    public void ExitTheGame()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; //don't need UnityEditor at the beginning if UnityEditor is here. Easier to put up top if there are mutliple
        #endif
        Application.Quit();
    }
}