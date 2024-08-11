using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Rizzmeter : MonoBehaviour
{
    public int rizz;
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
            SceneManager.LoadScene("Win-Shakespeare");
        }
        else if(GameManager.currentBachelor == selectedBachelor.Shakespeare && rizz <= 70)
        {
            SceneManager.LoadScene("Lose-Shakespeare");
        }

        if(GameManager.currentBachelor == selectedBachelor.MarieAntoinette && rizz >= 85)
        {
            //
        }
        else if(GameManager.currentBachelor == selectedBachelor.MarieAntoinette && rizz <= 85)
        {
            //
        }


        if(GameManager.currentBachelor == selectedBachelor.GenghisKhan && rizz >= 100)
        {
            SceneManager.LoadScene("Win-Genghis");
        }
        else if(GameManager.currentBachelor == selectedBachelor.GenghisKhan && rizz <= 100)
        {
            SceneManager.LoadScene("Lose-Genghis");
        }
        
    }
}
