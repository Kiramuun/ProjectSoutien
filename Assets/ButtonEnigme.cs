using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEnigme : MonoBehaviour
{
    public Animator[] _animButton = new Animator[4];
    Animator _animDLaby;
    int _index = 0;

    void Awake()
    {
        _animDLaby = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        
    }
}
