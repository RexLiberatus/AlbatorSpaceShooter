using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Viewport_Destroyer : MonoBehaviour
{

    public Transform m_target;
    public Vector2 m_viewport;


    void Update()
    {
        CheckDisablehPosition();
    }

    private void CheckDisablehPosition()
    {
  
        m_target = transform;
        m_viewport = Camera.main.WorldToViewportPoint(m_target.position);
        if (m_viewport.x<=-1)
        {
            Destroy(gameObject);
        }
    }
}
