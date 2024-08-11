using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueButtons : MonoBehaviour
{
    //variables
    public int rizzMeter;
    [SerializeField]private List<Sprite> reactions;
    public GameObject reactionImage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Response() //When button 1 is clicked
    {
        rizzMeter += 10; //makes the rizz meter increase depending on what option users pick
        //reactionImage.sprite = reactions[0];
        reactionImage.GetComponent<SpriteRenderer>().sprite = reactions[0];

        ErikaDialogue.Instance.bachelorTextObj.text = "Splendid.";
        StartCoroutine(ErikaDialogue.Instance.ReactionPause());

    }
        public void Response2() //When button 2 is clicked
    {
        rizzMeter += 20;
        reactionImage.GetComponent<SpriteRenderer>().sprite = reactions[1];

        ErikaDialogue.Instance.bachelorTextObj.text = "Thy words shine as a beacon in the dark, revealing wisdom and kindred spirit. Let us continue to share such light and insight.";
        StartCoroutine(ErikaDialogue.Instance.ReactionPause());
    }
        public void Response3()
    {
        rizzMeter -= 10;
        reactionImage.GetComponent<SpriteRenderer>().sprite = reactions[2];

        ErikaDialogue.Instance.bachelorTextObj.text = "Thy words are as empty as a fool's boast—better spent elsewhere.";
        StartCoroutine(ErikaDialogue.Instance.ReactionPause());
    }

    public void Continue()
    {
        ErikaDialogue.Instance.Responses1.SetActive(true);
    }
     
}
