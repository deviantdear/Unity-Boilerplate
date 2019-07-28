/**
 * Drag.cs Move around object on the Canvas
 * Author:  Lisa Walkosz-Migliacio  http://evilisa.com  11/28/2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour {

    public Canvas canvas;
    public AudioSource audio;

    // Use this for initialization
    void Start () {

    }
    
    public void onDrag()
    {
        Vector2 position;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            canvas.transform as RectTransform, Input.mousePosition, canvas.worldCamera, out position);
        transform.position = canvas.transform.TransformPoint(position);
    }

    public void onDrop()
    {
        if (audio) audio.Play();
        Debug.Log("dropped");
    }

    // Update is called once per frame
    void Update () {

    }
}
