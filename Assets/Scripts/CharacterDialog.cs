using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CharacterDialog : MonoBehaviour
{
    public TMP_Text dialogueText;
    public TMP_Text nameText;
    public TMP_Text bioText;
    public Image photoImage;

    void Start()
    {
        int selectedIndex = PlayerPrefs.GetInt("SelectedCharacterIndex", 0);

        Bachelor selectedCharacter = GetCharacterByIndex(selectedIndex);

        nameText.text = selectedCharacter.name;
        bioText.text = selectedCharacter.bio;
        photoImage.sprite = selectedCharacter.photo;
        photoImage.preserveAspect = true;
        
        dialogueText.text = "Welcome to your new dialog!";
    }

    Bachelor GetCharacterByIndex(int index)
    {
        return new Bachelor(); // Placeholder
    }
}
