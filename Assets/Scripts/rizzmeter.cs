using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rizzmeter : MonoBehaviour
{
    public int rizz;
    public Transform meterpercentage;
    public Transform colour;
    public int maxrizz = 100;
    public int minrizz = 0;
    public Color32 positivecolor;
    public Color32 negativecolor;
    Image rizzimg;
    // Start is called before the first frame update
    void Start()
    {
        rizzimg = colour.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        //rizz = rizz + Time.deltaTime/5;
        Debug.Log($"rizz is {rizz}");
        meterpercentage.localScale = new Vector3(1,rizz/(float)maxrizz,1);
        if (rizz > maxrizz)
        {
            rizz = maxrizz;
        }
        if (rizz < minrizz)
        {
            rizz = minrizz;
        }
        if (rizz < 0)
        {
            rizzimg.color = negativecolor;
        }
        else
        {
            rizzimg.color = positivecolor;
        }
    }
}
