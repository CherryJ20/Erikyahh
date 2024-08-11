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
    public selectedBachelor bachelor;
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
        GameManager.currentBachelor = bachelors[selectedIndex].bachelor;
        photoObject.GetComponent<Image>().sprite = bachelors[selectedIndex].photo;
        photoObject.GetComponent<Image>().preserveAspect = true;
    }

    public void Like()
    {
        switch(GameManager.currentBachelor)
        {
            case selectedBachelor.Shakespeare:
                SceneManager.LoadScene("Shakespeare");
                break;
            case selectedBachelor.MarieAntoinette:
                SceneManager.LoadScene("MarieAntoinette");
                break;
            case selectedBachelor.GenghisKhan:
                SceneManager.LoadScene("GenghisKhan");
                break;
        }
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
