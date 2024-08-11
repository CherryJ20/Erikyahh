using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueButtons : MonoBehaviour
{
    //variables
    public int rizzMeter;
    public GameObject Responses1; //Parent objects of the buttons
    public bool Genghis;
    public bool MarieAntoinette;
    public bool Shakespeare;

    int maxRizz;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Response() //When button 1 is clicked
    {
        Debug.Log("this is for response 1"); //Console check thing
        rizzMeter += 10; //makes the rizz meter increase depending on what option users pick
    }
        public void Response2() //When button 2 is clicked
    {
        Debug.Log("this is for response 2");
        rizzMeter += 20;
    }
        public void Response3()
    {
        Debug.Log("this is for response 3");
        rizzMeter -= 10;
    }

    public void characterIfs()
    {
        if(Shakespeare)
        {
            maxRizz=70;
        }
        else if (MarieAntoinette)
        {
            maxRizz=80;
        }
        else if (Genghis)
        {
            maxRizz=100;
        }
    }
}
