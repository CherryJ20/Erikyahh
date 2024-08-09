using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rizzmeter : MonoBehaviour
{
    float rizz;
    public Transform meterpercentage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rizz = rizz + Time.deltaTime/5;
        Debug.Log($"rizz is {rizz}");
        meterpercentage.localScale = new Vector3(1,rizz,1);
    }
}
