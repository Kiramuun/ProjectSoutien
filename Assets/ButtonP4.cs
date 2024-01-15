using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonP4 : MonoBehaviour
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
            _animButton.SetBool("PressedButton4", true);
        }
    }
}
