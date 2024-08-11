using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

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

    public void UpdateInfo()
    {
        nameText.text = bachelors[selectedIndex].name;
        bioText.text = bachelors[selectedIndex].bio;
        photoObject.GetComponent<Image>().sprite = bachelors[selectedIndex].photo;
        photoObject.GetComponent<Image>().preserveAspect = true;
    }

    public void Like()
    {
        // load next scene
        SceneManager.LoadScene("Shakespeare");
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
