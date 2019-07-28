/**
* InputText.cs grab from the input field the text that was inputted
* Author:  Lisa Walkosz-Migliacio  http://evilisa.com  12/18/2018
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputText : MonoBehaviour {

    public string nameValue;

	// Use this for initialization
	void Start () {
		
	}

    public void onChange()
    {
        nameValue = GetComponent<InputField>().text;
        Debug.Log("new things are being typed: " + nameValue);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
