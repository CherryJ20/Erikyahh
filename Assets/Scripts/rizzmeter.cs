using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rizzmeter : MonoBehaviour
{
    public int rizz;
    public Transform colour;
    public int maxrizz = 100;
    public int minrizz = 0;
    public Image rizzimg;
    public Color startColor;
    public Color endColor;

    // Start is called before the first frame update
    void Start()
    {

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
}
