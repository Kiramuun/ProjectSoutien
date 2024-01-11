using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public Animator _anim;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == 3)
        {
            _anim.SetTrigger("OpeningButton");
        }
    }
}
