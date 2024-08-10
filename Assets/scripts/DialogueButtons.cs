using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueButtons : MonoBehaviour
{
    public int rizzMeter;
    public GameObject Responses1;


    public GameObject Responses2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Response()
    {
        Debug.Log("this is for response 1");
        rizzMeter += 10;
        Responses1.SetActive(false);
    }
        public void Response2()
    {
        Debug.Log("this is for response 2");
        rizzMeter += 20;
        Responses1.SetActive(false);
    }
        public void Response3()
    {
        Debug.Log("this is for response 3");
        rizzMeter -= 10;
        Responses1.SetActive(false);
    }


        public void Oay()
    {
        Debug.Log("this is for response 1");
        rizzMeter += 10;
        Responses2.SetActive(false);
    }
        public void Oay2()
    {
        Debug.Log("this is for response 2");
        rizzMeter += 20;
         Responses2.SetActive(false);
    }
        public void Oay3()
    {
        Debug.Log("this is for response 3");
        rizzMeter -= 10;
         Responses2.SetActive(false);
    }
}
