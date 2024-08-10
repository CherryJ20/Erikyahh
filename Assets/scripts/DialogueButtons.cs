using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueButtons : MonoBehaviour
{
    public int rizzMeter;
    public GameObject Responses1; //Parent objects of the buttons


    public GameObject Responses2;


    public GameObject Responses3;
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
        Responses1.SetActive(false); //makes the previous buttons disappear after users pick a option - takes them to new dialogue options
    }
        public void Response2() //When button 2 is clicked
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


    public void Beans()
    {
        Debug.Log("this is for response 3");
        rizzMeter += 10;
        Responses3.SetActive(false);
    }
     public void Beans2()
    {
        Debug.Log("this is for response 3");
        rizzMeter += 20;
        Responses3.SetActive(false);
    }
    public void Beans3()
    {
        Debug.Log("this is for response 3");
        rizzMeter -= 10;
        Responses3.SetActive(false);
    }
}
