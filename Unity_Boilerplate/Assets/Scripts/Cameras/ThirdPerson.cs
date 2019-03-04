using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPerson : MonoBehaviour
{
    //Creates the basic "Look-At" Camera script. No frills
    public GameObject target;

    void LateUpdate()
    {
        transform.LookAt(target.transform);
    }
}
