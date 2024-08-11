using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueButtons : MonoBehaviour
{
    //variables
    public int rizzMeter;
    [SerializeField]private List<Sprite> reactions;
    public Image reactionImage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Response() //When button 1 is clicked
    {
        rizzMeter += 10; //makes the rizz meter increase depending on what option users pick
        reactionImage.sprite = reactions[0];

        ErikaDialogue.Instance.bachelorTextObj.text = "Thats cool.";
        StartCoroutine(ErikaDialogue.Instance.ReactionPause());

    }
        public void Response2() //When button 2 is clicked
    {
        rizzMeter += 20;
        reactionImage.sprite = reactions[1];

        ErikaDialogue.Instance.bachelorTextObj.text = "SUGOI!";
        StartCoroutine(ErikaDialogue.Instance.ReactionPause());
    }
        public void Response3()
    {
        rizzMeter -= 10;
        reactionImage.sprite = reactions[2];

        ErikaDialogue.Instance.bachelorTextObj.text = "Um... Ok?";
        StartCoroutine(ErikaDialogue.Instance.ReactionPause());
    }

    public void Continue()
    {
        ErikaDialogue.Instance.Responses1.SetActive(true);
    }
     
}
