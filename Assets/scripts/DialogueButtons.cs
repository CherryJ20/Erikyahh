using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueButtons : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;

    public Dialogue dialogue; // Reference to the Dialogue script

    private void Start()
    {
        // Setup button listeners
        button1.onClick.AddListener(() => OnButtonClick(1));
        button2.onClick.AddListener(() => OnButtonClick(2));
        button3.onClick.AddListener(() => OnButtonClick(3));
    }

    public void SetButtonTexts(string text1, string text2, string text3)
    {
        button1.GetComponentInChildren<Text>().text = text1;
        button2.GetComponentInChildren<Text>().text = text2;
        button3.GetComponentInChildren<Text>().text = text3;

    }

    private void OnButtonClick(int choice)
    {
        dialogue.HandleDialogue(choice);
    }

    public void UpdateRizzMeter(int rizz)
    {
      
    }
}
