using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaosGoalScript : MonoBehaviour
{
    public bool isSolved = false;
    public int chaosBalls = 10;

    void OnTriggerEnter(Collider collider)
    {
        GameObject collidedWith = collider.gameObject;
        if (collidedWith.tag == "Chaos")
        {
            Destroy(collidedWith);
            chaosBalls--;
            
            if (chaosBalls == 0)
            {
                isSolved = true;
                GetComponent<Light>().enabled = false;
            }
        }
    }
}
