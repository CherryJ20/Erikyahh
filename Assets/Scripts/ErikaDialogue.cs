using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[Serializable]
public struct DialogueOptions
{
    public string bachelorText;

    public string response1;
    public string response2;
    public string response3;
}

public class ErikaDialogue : MonoBehaviour
{
    public List<DialogueOptions> dialogueOptions;
    public TextMeshProUGUI bachelorTextObj;
    [SerializeField] private TextMeshProUGUI option1;
    [SerializeField] private TextMeshProUGUI option2;
    [SerializeField] private TextMeshProUGUI option3;
    public int index = 0;
    public GameObject Responses1; //Parent objects of the buttons
    public GameObject continueButton;


    public static ErikaDialogue Instance;

    void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        UpdateUI();
    }

    public void UpdateUI()
    {
        bachelorTextObj.text = dialogueOptions[index].bachelorText;
        option1.text = dialogueOptions[index].response1;
        option2.text = dialogueOptions[index].response2;
        option3.text = dialogueOptions[index].response3;
    }

    public void IterateConvo()
    {
        if (index < dialogueOptions.Count - 1)
        {
            index++;
            UpdateUI();
        }
        else
        {
            Rizzmeter.Instance.WinRizz();
        }
    }

    public IEnumerator ReactionPause()
    {
        Responses1.SetActive(false);
        yield return new WaitForSeconds(2);
        IterateConvo();
        continueButton.SetActive(true);
    }
    
}
