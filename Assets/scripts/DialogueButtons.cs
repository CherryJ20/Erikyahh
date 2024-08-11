using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueButtons : MonoBehaviour
{
    //variables
    [SerializeField]private List<Sprite> reactions;
    public List<string> bachResponses;
    public GameObject reactionImage;
    public GameObject continueButton;

    public void Response() //When button 1 is clicked
    {
        Rizzmeter.Instance.rizz += 10; //makes the rizz meter increase depending on what option users pick
        reactionImage.GetComponent<SpriteRenderer>().sprite = reactions[0];

        ErikaDialogue.Instance.bachelorTextObj.text = bachResponses[0];
        StartCoroutine(ErikaDialogue.Instance.ReactionPause());

    }
        public void Response2() //When button 2 is clicked
    {
        Rizzmeter.Instance.rizz += 20;
        reactionImage.GetComponent<SpriteRenderer>().sprite = reactions[1];

        ErikaDialogue.Instance.bachelorTextObj.text = bachResponses[1];
        StartCoroutine(ErikaDialogue.Instance.ReactionPause());
    }
        public void Response3()
    {
        Rizzmeter.Instance.rizz -= 10;
        reactionImage.GetComponent<SpriteRenderer>().sprite = reactions[2];

        ErikaDialogue.Instance.bachelorTextObj.text = bachResponses[2];
        StartCoroutine(ErikaDialogue.Instance.ReactionPause());
    }

    public void Continue()
    {
        ErikaDialogue.Instance.Responses1.SetActive(true);
        ErikaDialogue.Instance.continueButton.SetActive(false);
    }
     
}
