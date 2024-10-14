using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // This is the game object you want to access
    private GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag ("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        float mouseXVal = Input.GetAxis("Mouse X");
        float mouseYVal = Input.GetAxis("Mouse Y");

        if (mouseXVal != 0)
            print("Mouse X movement selected: " + mouseXVal);
        if (mouseYVal != 0)
            print("Mouse Y movement selected: " + mouseYVal);

        if (mouseXVal > 0)
            target.transform.Translate (mouseXVal, 0f, 0f);
        else
            target.transform.Translate (-mouseXVal, 0f, 0f);

        if (mouseYVal > 0)
            target.transform.Translate (0f, mouseYVal, 0f);
        else
            target.transform.Translate (0f, -mouseYVal, 0f);
    }
}
