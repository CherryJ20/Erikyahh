using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[Serializable]
public struct Bachelor
{
    public string name;
    public string bio;
    public Sprite photo;
}
public class BachRotation : MonoBehaviour
{
    public List<Bachelor> bachelors;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI bioText;
    public GameObject photoObject;

    private int selectedIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        UpdateInfo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateInfo()
    {
        nameText.text = bachelors[selectedIndex].name;
        bioText.text = bachelors[selectedIndex].bio;
        photoObject.GetComponent<SpriteRenderer>().sprite = bachelors[selectedIndex].photo;
    }

    public void Like()
    {
        // load next scene
    }

    public void Unlike()
    {
        //rotates bachelor
        if (selectedIndex < bachelors.Count - 1)
        {
            selectedIndex++;
        }
        else
        {
            selectedIndex = 0;
        }
        UpdateInfo();
    }
}
