using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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


    private int rizzMeter = 0;

    // Start is called before the first frame update
    void Start()
    {
        currentChoice = DialogueChoice.Introduction;
        DialogueOptions();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            HandleDialogue(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            HandleDialogue(2);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            HandleDialogue(3);
        }
    }

    // HANDLES DIALOGUE OPTIONS FROM ENUM
    public void DialogueOptions()
    {
        switch (currentChoice)
        {
            case DialogueChoice.Introduction:
                dialogueTextMesh.text = "Welcome! Choose wisely.";
                break;

            case DialogueChoice.Choice01:
                dialogueTextMesh.text = "You selected Choice 01.";
                chooseOne.text = "One";
                chooseTwo.text = "Two";
                chooseThree.text = "Three";
                break;

            case DialogueChoice.Choice02:
                dialogueTextMesh.text = "You selected Choice 02.";
                chooseOne.text = "One";
                chooseTwo.text = "Two";
                chooseThree.text = "Three";
                break;

            case DialogueChoice.Choice03:
                dialogueTextMesh.text = "You selected Choice 03.";
                chooseOne.text = "One";
                chooseTwo.text = "Two";
                chooseThree.text = "Three";
                break;

            case DialogueChoice.Ending:
                dialogueTextMesh.text = rizzMeter > 0 ? "Success!" : "Try again.";
                break;
        }
    }

    // HANDLES DIALOGUE BASED ON INPUT
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

            case DialogueChoice.Choice02:
                HandleSecondChoice(choice);
                break;

            case DialogueChoice.Choice03:
                HandleThirdChoice(choice);
                break;

            case DialogueChoice.Ending:
                HandleEndChoice(choice);
                break;
        }
    }

    // HANDLE INTRO
    public void HandleIntro(int choice)
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

        currentChoice = DialogueChoice.Choice01;
        Invoke("DialogueOptions", 2f);
    }

    // HANDLES THE FIRST CHOICE
    public void HandleFirstChoice(int choice)
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
    }

    // HANDLES THE SECOND CHOICE
    public void HandleSecondChoice(int choice)
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
    }

    // HANDLES THE THIRD CHOICE
    public void HandleThirdChoice(int choice)
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
    }

    // HANDLES THE ENDING
    public void HandleEndChoice(int choice)
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
    }
}
