using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowText : MonoBehaviour
{
    public Text missatge;
    // Start is called before the first frame update
    void Start()
    {
        missatge = GetComponent<Text>();
        //Showing a text
        missatge.text="Start";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
