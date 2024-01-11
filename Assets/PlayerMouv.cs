using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMouv : MonoBehaviour
{
    Vector3 dir;
    Rigidbody rb;

    [SerializeField]
    float speed = 5;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Keyboard k = Keyboard.current;

        if (k.sKey.wasPressedThisFrame) dir.z += 1;
        if (k.wKey.wasPressedThisFrame) dir.z -= 1;
        if (k.aKey.wasPressedThisFrame) dir.x += 1;
        if (k.dKey.wasPressedThisFrame) dir.x -= 1;

        if (k.sKey.wasReleasedThisFrame) dir.z -= 1;
        if (k.wKey.wasReleasedThisFrame) dir.z += 1;
        if (k.aKey.wasReleasedThisFrame) dir.x -= 1;
        if (k.dKey.wasReleasedThisFrame) dir.x += 1;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(transform.position + dir.normalized * speed * Time.fixedDeltaTime);
    }
}
