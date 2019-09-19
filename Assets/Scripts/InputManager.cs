using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public UnityEvent onFire;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            onFire.Invoke();
        }
    }

}
