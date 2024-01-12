using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public Animator _animDoor;
    Animator _animButton;

    void Awake()
    {
        _animButton = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 3)
        {
            _animButton.SetTrigger("PressedButton");
            if (_animButton.isActiveAndEnabled)
            {
                _animDoor.SetTrigger("OpeningDoor");
            }
        }
    }
}
