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
        if (_animButton[1].isActiveAndEnabled || _animButton[0].isActiveAndEnabled || _animButton[3].isActiveAndEnabled)
        {
            //_index = 0;
        }

        switch (_index)
        {
            case 0:
                _animButton[0].SetTrigger("ErrorButton1");
                _animButton[1].SetTrigger("ErrorButton1");
                _animButton[2].SetTrigger("ErrorButton1");
                _animButton[3].SetTrigger("ErrorButton1");
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
