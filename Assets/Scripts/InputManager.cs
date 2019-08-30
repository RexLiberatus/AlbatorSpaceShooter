using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public UnityEvent onFire;

    // Start is called before the first frame update
    void Start()
    {

        //onFire.AddListener();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            onFire.Invoke();
        }
    }
    //public void Salut()
    //{
    //    Debug.Log("salut!");
    //}
}
