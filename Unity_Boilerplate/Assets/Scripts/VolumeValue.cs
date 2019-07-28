/**
* VolumeValue.cs get the value of the slider to set for volume
* Author:  Lisa Walkosz-Migliacio  http://evilisa.com  12/18/2018
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeValue : MonoBehaviour {

    public float volume;

	// Use this for initialization
	void Start () {
		
	}

    public void onChange()
    {
        volume = GetComponent<Slider>().value;
        Debug.Log("volume being changed: " + volume);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
