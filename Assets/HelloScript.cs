using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class HelloScript : MonoBehaviour
{

    private Text hellotext;

    // Use this for initialization
    void Start()
    {
        hellotext = GameObject.Find("Text").GetComponent<Text>();
        hellotext.text = "Hey Yo! Man";


    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
