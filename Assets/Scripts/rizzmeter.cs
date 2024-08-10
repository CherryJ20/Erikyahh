using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rizzmeter : MonoBehaviour
{
    public int rizz;
    public Transform meterpercentage;
    public int maxrizz = 100;
    public int minrizz = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rizz = rizz + Time.deltaTime/5;
        Debug.Log($"rizz is {rizz}");
        meterpercentage.localScale = new Vector3(1,rizz/(float)maxrizz,1);
        if (rizz > maxrizz) rizz = maxrizz;
        if (rizz < minrizz) rizz = minrizz;
    }
}
