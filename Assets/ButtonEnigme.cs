using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEnigme : MonoBehaviour
{
    public Animator[] _animButton = new Animator[4];
    Animator _animDLaby;
    int _index;

    void Awake()
    {
        _animDLaby = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (_animButton[2].isActiveAndEnabled)
        {
            _index = 1;
        }
        /*if (_animButton[1].isActiveAndEnabled || _animButton[0].isActiveAndEnabled || _animButton[3].isActiveAndEnabled)
        {
            _index = 0;
        }*/

        switch (_index)
        {
            case 0:
                _animButton[0].SetBool("PressedButton1", false);
                _animButton[1].SetBool("PressedButton2", false);
                _animButton[2].SetBool("PressedButton3", false);
                _animButton[3].SetBool("PressedButton4", false);
                break;

            case 1:
                if (_animButton[2].isActiveAndEnabled)
                {
                    if (_animButton[0].isActiveAndEnabled) { _index = 2; }
                    else if(_animButton[1].isActiveAndEnabled || _animButton[3].isActiveAndEnabled) { _index = 0; }
                }
                break;
        }
    }
}
