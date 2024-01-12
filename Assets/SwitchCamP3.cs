using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamP3 : MonoBehaviour
{
    public Camera[] cam = new Camera[2];

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 3)
        {
            if (cam[0] == Camera.main)
            {
                cam[1].gameObject.SetActive(true);
                cam[0].gameObject.SetActive(false);
            }
            else
            {
                cam[0].gameObject.SetActive(true);
                cam[1].gameObject.SetActive(false);
            }
        }
    }
}
