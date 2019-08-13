using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Viewport_Destroyer : MonoBehaviour
{

    Transform m_target;
    public Vector2 m_viewport;


    void Update()
    {
        CheckDisablePosition();
    }

    private void CheckDisablePosition()
    {
  
        m_target = transform;
        m_viewport = Camera.main.WorldToViewportPoint(m_target.position);
        if (m_viewport.x<=-2)
        {
            Destroy(gameObject);
        }
    }
}
