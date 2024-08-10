using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement; // For scene management

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
    public Image photoImage;
    public Button likeButton;
    public Button dislikeButton;
    public Button selectButton;

    private int selectedIndex = 0;

    void Start()
    {
        UpdateInfo();
        
        // Set up button listeners
        likeButton.onClick.AddListener(OnLike);
        dislikeButton.onClick.AddListener(OnDislike);
        selectButton.onClick.AddListener(OnSelect);
    }

    void UpdateInfo()
    {
        if (bachelors.Count == 0) return; // Avoid errors if no bachelors

        nameText.text = bachelors[selectedIndex].name;
        bioText.text = bachelors[selectedIndex].bio;
        photoImage.sprite = bachelors[selectedIndex].photo;
        photoImage.preserveAspect = true;
    }

    // Handle the Like button click
    void OnLike()
    {
        // Handle like logic 
        Debug.Log($"Liked: {bachelors[selectedIndex].name}");

        // Move to the next bachelor
        MoveToNextBachelor();
    }

    // Handle the Dislike button click
    void OnDislike()
    {
        // Handle dislike logic 
        Debug.Log($"Disliked: {bachelors[selectedIndex].name}");

        // Move to the next bachelor
        MoveToNextBachelor();
    }

    // Handle the Select button click
    void OnSelect()
    {
        // Handle character selection logic
        Debug.Log($"Selected: {bachelors[selectedIndex].name}");

        // Transition to the selected character's dialog
        PlayerPrefs.SetInt("SelectedCharacterIndex", selectedIndex); // Save the selected character index
        SceneManager.LoadScene("CharacterDialogScene"); // Load the dialog scene
    }

    // Move to the next bachelor
    void MoveToNextBachelor()
    {
        selectedIndex = (selectedIndex + 1) % bachelors.Count; // Rotate through the list
        UpdateInfo();
    }

    // Optional: Move to the previous bachelor
    void MoveToPreviousBachelor()
    {
        selectedIndex = (selectedIndex - 1 + bachelors.Count) % bachelors.Count; // Rotate through the list
        UpdateInfo();
    }
}
