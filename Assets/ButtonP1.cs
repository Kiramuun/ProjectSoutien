using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class ButtonP1 : MonoBehaviour
{
    Animator _animButton;

    void Awake()
    {
        _animButton = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 3)
        {
            _animButton.SetBool("PressedButton1", true);
        }
    }
}
