using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    private enum DialogueChoice
    {
        Introduction, Choice01, Choice02, Choice03, Ending
    }

    private DialogueChoice currentChoice;

    public TMP_Text dialogueTextMesh;
    public TMP_Text chooseOne;
    public TMP_Text chooseTwo;
    public TMP_Text chooseThree;
    public GameObject introScreen; // Reference to the intro screen GameObject
    public GameObject dialoguePanel; // Reference to the dialogue panel GameObject
    public DialogueButtons dialogueButtons; // Reference to the DialogueButtons script

    private int rizzMeter = 0;

    void Start()
    {
        currentChoice = DialogueChoice.Introduction;
        ShowIntroScreen();
    }

    void ShowIntroScreen()
    {
        introScreen.SetActive(true); // Show the intro screen
        dialoguePanel.SetActive(false); // Hide dialogue panel
    }

    public void StartDialogue()
    {
        introScreen.SetActive(false); // Hide the intro screen
        dialoguePanel.SetActive(true); // Show dialogue panel
        DialogueOptions();
    }

    public void DialogueOptions()
    {
        switch (currentChoice)
        {
            case DialogueChoice.Introduction:
                dialogueTextMesh.text = "Welcome! Choose wisely.";
                dialogueButtons.SetButtonTexts("Select Bachelor 1", "Select Bachelor 2", "Select Bachelor 3");
                break;

            case DialogueChoice.Choice01:
                dialogueTextMesh.text = "You selected Choice 01.";
                dialogueButtons.SetButtonTexts("Option A", "Option B", "Option C");
                break;


            case DialogueChoice.Ending:
                dialogueTextMesh.text = rizzMeter > 0 ? "Success!" : "Try again.";
                dialogueButtons.SetButtonTexts("", "", "");
                break;
        }
    }

    public void HandleDialogue(int choice)
    {
        switch (currentChoice)
        {
            case DialogueChoice.Introduction:
                HandleIntro(choice);
                break;

            case DialogueChoice.Choice01:
                HandleFirstChoice(choice);
                break;


            case DialogueChoice.Ending:
                HandleEndChoice(choice);
                break;
        }
    }

    private void HandleIntro(int choice)
    {
        UpdateRizzMeter(choice);
        currentChoice = DialogueChoice.Choice01;
        Invoke("DialogueOptions", 2f); // Delay for showing options
    }

    private void HandleFirstChoice(int choice)
    {
        UpdateRizzMeter(choice);
    }

    private void HandleEndChoice(int choice)
    {
        UpdateRizzMeter(choice);
    }

    private void UpdateRizzMeter(int choice)
    {
        if (choice == 1)
        {
            rizzMeter += 2;
        }
        else if (choice == 2)
        {
            rizzMeter += 1;
        }
        else
        {
            rizzMeter -= 1;
        }

        // Update the rizz meter in the other script
        dialogueButtons.UpdateRizzMeter(rizzMeter);
    }
}
