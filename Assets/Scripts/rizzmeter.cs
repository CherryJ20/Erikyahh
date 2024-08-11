using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rizzmeter : MonoBehaviour
{
    public int rizz;
    public Transform colour;
    public int maxrizz = 100;
    public int minrizz = 0;
    public Image rizzimg;
    public Color startColor;
    public Color endColor;
    public static Rizzmeter Instance;

    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        rizzimg.fillAmount = rizz / (float)maxrizz;
        Debug.Log($"fill amount is {rizzimg.fillAmount}");
        if (rizz > maxrizz)
        {
            rizz = maxrizz;
        }
        if (rizz < minrizz)
        {
            rizz = minrizz;
        }
        rizzimg.color = Color.Lerp(startColor, endColor, rizzimg.fillAmount);
    }

    public void WinRizz()
    {
        if(GameManager.currentBachelor == selectedBachelor.Shakespeare && rizz >= 70)
        {
            //ending
            Debug.Log("You got the good ending!");
        }
        else if(GameManager.currentBachelor == selectedBachelor.Shakespeare && rizz <= 70)
        {
            //
            Debug.Log("You got the bad ending!");
        }

        if(GameManager.currentBachelor == selectedBachelor.MarieAntoinette && rizz >= 85)
        {
            //ending
        }
        else if(GameManager.currentBachelor == selectedBachelor.MarieAntoinette && rizz <= 85)
        {
            //
        }


        if(GameManager.currentBachelor == selectedBachelor.GenghisKhan && rizz >= 100)
        {
            //ending
        }
        else if(GameManager.currentBachelor == selectedBachelor.GenghisKhan && rizz <= 100)
        {
            //
        }
        
    }
}
