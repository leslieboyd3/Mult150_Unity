using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    Light lightComponent; // A variable to store the light component.

    // Start is called before the first frame update
    void Start()
    {
        lightComponent = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (lightComponent.enabled == true)
            {
                lightComponent.enabled = false;
            }
            else 
            {
                lightComponent.enabled = true;
            }
        }
    }
}
