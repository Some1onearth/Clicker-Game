using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class News : MonoBehaviour
{
    float sheepCount;
    [SerializeField] Text news1;

    // Update is called once per frame
    void Update()
    {
        sheepCount = PlayerPrefs.GetInt("conspiracies");
        news();
    }
    void news()
    {
        if (sheepCount >= 10)
        {
            news1.text = "Disciples have gathered! Continue your research.";
        }
        if (sheepCount >= 100)
        {
            news1.text = "Government have proven to be hiding the truth!";
        }
        if (sheepCount >= 1000)
        {
            news1.text = "Newly discovered 6G in development, beware the new virus: Tooheysnuvirus!";
        }
        if (sheepCount >= 4000)
        {
            news1.text = "Choyner found to be the source of all problems!";
        }
        if (sheepCount >= 100000)
        {
            news1.text = "Cancel culture is wrong, these are the people responsible for that creation!";
        }
    }
}
