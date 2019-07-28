/**
* Hover.cs when mouse is over button, audio is played, and console log displayed
* Author:  Lisa Walkosz-Migliacio  http://evilisa.com  12/18/2018
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hover : MonoBehaviour {

    public AudioSource audio;

    // Use this for initialization
    void Start () {
		
	}

    public void onHover()
    {
        if (audio) audio.Play();
        Debug.Log("hover");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
